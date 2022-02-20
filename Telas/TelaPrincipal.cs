using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstoque.Telas
{
    public partial class TelaPrincipal : Form
    {

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            string strWhere = "";

            if (panelCadastroProduto.Visible == true)
            {
                List<Modelo.ModeloProduto> listaProduto = new BLL.ProdutoBLL().BuscarProdutos(strWhere);
                dataGridProduto.AutoGenerateColumns = false;
                dataGridProduto.DataSource = listaProduto;
                dataGridProduto.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            }
            else
            {
                List<Modelo.ModeloUnidadeMedida> listaUnidadeMedida = new BLL.UnidadeMedidaBLL().Buscar(strWhere);
                dataGridUnidadeMedida.AutoGenerateColumns = false;
                dataGridUnidadeMedida.DataSource = listaUnidadeMedida;
                dataGridUnidadeMedida.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridUnidadeMedida.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;


            }
        }


        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelCadastroUnidadeMedida.Visible = true;
            PainelBotoes.Visible = true;
            panelCadastroProduto.Visible = false;
            CarregaGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PainelCadastroUnidadeMedida.Visible = false;
            PainelBotoes.Visible = false;
            panelCadastroProduto.Visible = false;

        }


        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCadastroProduto.Visible = true;
            PainelBotoes.Visible = true;
            PainelCadastroUnidadeMedida.Visible = false;
            CarregaGrid();

            
            List<Modelo.ModeloUnidadeMedida> listaUnidadeMedida = new BLL.UnidadeMedidaBLL().Buscar("");
            comboUnd.DataSource = listaUnidadeMedida;
            comboUnd.DisplayMember = "SiglaUnidadeMedida";
            comboUnd.ValueMember = "IdUnidadeMedida";
            comboUnd.Text = "";


        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            PainelBotoes.Visible = false;
            PainelCadastroUnidadeMedida.Visible = false;
            panelCadastroProduto.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";

                if (panelCadastroProduto.Visible == true)
                {
                    if (dataGridProduto.Enabled == false)
                    {
                        Modelo.ModeloProduto produto = new Modelo.ModeloProduto();

                        produto.IdProduto = int.Parse(dataGridProduto.CurrentRow.Cells[0].Value.ToString());
                        produto.DescricaoProduto = txtDescricaoProduto.Text;
                        produto.QuantidadeEstoque = Convert.ToDouble(txtQuantidade.Value);
                        produto.Valor = Convert.ToDouble(txtvalor.Value);
                        produto.IdUnidadeMedida = Convert.ToInt32(comboUnd.SelectedValue);

                        id = produto.IdProduto.ToString();

                        bool retorno = new BLL.ProdutoBLL().Alterar(produto);

                        if (retorno)
                        {
                            btnExcluir.Enabled = true;
                            btnVoltar.Enabled = true;
                            dataGridProduto.Enabled = true;

                        }
                        else
                            MessageBox.Show("Favor verificar os parametros e tentar novamente");
                    }
                    else
                    {
                        //Valida se os campos estão prenchidos

                        if (txtDescricaoProduto.Text.Equals("") || comboUnd.Text.Equals(""))
                        {
                            MessageBox.Show("Favor preencher todos os campos");
                        }
                        else
                        {
                            Modelo.ModeloProduto produto = new Modelo.ModeloProduto();
                            produto.DescricaoProduto = txtDescricaoProduto.Text;
                            produto.QuantidadeEstoque = Convert.ToDouble(txtQuantidade.Value);
                            produto.Valor = Convert.ToDouble(txtvalor.Value);
                            produto.IdUnidadeMedida = Convert.ToInt32(comboUnd.SelectedValue);

                            id = new BLL.ProdutoBLL().Incluir(produto).ToString();

                            //Apagando campos
                            txtDescricaoProduto.Text = "";
                            txtQuantidade.Value = 0;
                            txtvalor.Value = 0;
                            comboUnd.Text = "";

                        }
                    }
                }

                else if (PainelCadastroUnidadeMedida.Visible == true)
                {
                    if (txtDescricao.Text.Equals("") || txtSigla.Text.Equals(""))
                    {
                        MessageBox.Show("Favor preencher todos os campos");
                    }
                    else
                    {
                        Modelo.ModeloUnidadeMedida unidadeMedida = new Modelo.ModeloUnidadeMedida();
                        unidadeMedida.DescricaoUnidadeMedida = txtDescricao.Text;
                        unidadeMedida.SiglaUnidadeMedida = txtSigla.Text;

                        id = new BLL.UnidadeMedidaBLL().Incluir(unidadeMedida).ToString();

                        //Apagando campos
                        txtDescricao.Text = "";
                        txtSigla.Text = "";

                    }
                }

                if (id.Equals("0"))
                {
                    MessageBox.Show("Falha ao Incluir Registro!");
                }
                else
                {
                    MessageBox.Show("Registro incluído com sucesso!");
                }

                CarregaGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao incluir registro");
            }

        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja excluir o registro selecionado?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, "",buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                if (panelCadastroProduto.Visible == true)
                {
                    Modelo.ModeloProduto produto = new Modelo.ModeloProduto();
                    produto.IdProduto = int.Parse(dataGridProduto.CurrentRow.Cells[0].Value.ToString());
                    new BLL.ProdutoBLL().Excluir(Convert.ToInt32(produto.IdProduto));
                }
                else
                {
                    Modelo.ModeloUnidadeMedida und = new Modelo.ModeloUnidadeMedida();
                    und.IdUnidadeMedida = int.Parse(dataGridUnidadeMedida.CurrentRow.Cells[0].Value.ToString());
                    new BLL.UnidadeMedidaBLL().Excluir(Convert.ToInt32(und.IdUnidadeMedida));
                }
            }
            CarregaGrid();

        }

        private void comboUnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnExcluir.Enabled = false;
            btnVoltar.Enabled = false;
            dataGridProduto.Enabled = false;

            txtDescricaoProduto.Text = dataGridProduto.CurrentRow.Cells[1].Value.ToString();
            txtvalor.Value = decimal.Parse(dataGridProduto.CurrentRow.Cells[3].Value.ToString());
            txtQuantidade.Value = decimal.Parse(dataGridProduto.CurrentRow.Cells[4].Value.ToString());
            comboUnd.Text = dataGridProduto.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
