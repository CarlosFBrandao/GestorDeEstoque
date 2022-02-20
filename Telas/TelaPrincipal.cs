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
                    //Valida se os campos estão prenchidos

                    if (txtCodigoProduto.Text.Equals("") || txtDescricaoProduto.Text.Equals(""))
                    {
                        MessageBox.Show("Favor preencher todos os campos");
                    }
                    else
                    {
                        Modelo.ModeloProduto produto = new Modelo.ModeloProduto();
                        produto.CodigoProduto = Int32.Parse(txtCodigoProduto.Text);
                        produto.DescricaoProduto = txtDescricaoProduto.Text;
                        produto.QuantidadeEstoque = Convert.ToDouble(txtQuantidade.Value);
                        produto.Valor = Convert.ToDouble(txtvalor.Value);
                        produto.IdUnidadeMedida = 1;

                        id = new BLL.ProdutoBLL().Incluir(produto).ToString();

                        //Apagando campos
                        txtCodigoProduto.Text = "";
                        txtDescricaoProduto.Text = "";
                        txtQuantidade.Value = 0;
                        txtvalor.Value = 0;
                        comboUnd.Text = "";

                    }
                }

                else if (PainelCadastroUnidadeMedida.Visible == true)
                {
                    if (txtCodigo.Text.Equals("") || txtDescricao.Text.Equals("") || txtSigla.Text.Equals(""))
                    {
                        MessageBox.Show("Favor preencher todos os campos");
                    }
                    else
                    {
                        Modelo.ModeloUnidadeMedida unidadeMedida = new Modelo.ModeloUnidadeMedida();
                        unidadeMedida.CodigoUnidadeMedida = Int32.Parse(txtCodigo.Text);
                        unidadeMedida.DescricaoUnidadeMedida = txtDescricao.Text;
                        unidadeMedida.SiglaUnidadeMedida = txtSigla.Text;

                        id = new BLL.UnidadeMedidaBLL().Incluir(unidadeMedida).ToString();

                        //Apagando campos
                        txtCodigo.Text = "";
                        txtDescricao.Text = "";
                        txtSigla.Text = "";

                    }
                }

                CarregaGrid();

                if (id.Equals("0"))
                {
                    MessageBox.Show("Falha ao Incluir Registro!");
                }
                else
                {
                    MessageBox.Show("Registro incluído com sucesso!");
                }

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
            CarregaGrid();
        }

        private void comboUnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
