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
            else if (panelMovimento.Visible == true)
            {
                List<Modelo.ModeloMovimento> movimento = new BLL.MovimentoBLL().Buscar(strWhere);
                dataGridMovimento.AutoGenerateColumns = false;
                dataGridMovimento.DataSource = movimento;
                dataGridMovimento.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridMovimento.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

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
            panelMovimento.Visible = false;
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
            panelMovimento.Visible = false;
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
                            btnBuscar.Enabled = true;
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
                    if (dataGridUnidadeMedida.Enabled == false)
                    {
                        Modelo.ModeloUnidadeMedida unidadeMedida = new Modelo.ModeloUnidadeMedida();

                        unidadeMedida.IdUnidadeMedida = int.Parse(dataGridUnidadeMedida.CurrentRow.Cells[0].Value.ToString());
                        unidadeMedida.DescricaoUnidadeMedida = txtDescricao.Text;
                        unidadeMedida.SiglaUnidadeMedida = txtSigla.Text;

                        id = unidadeMedida.IdUnidadeMedida.ToString();

                        bool retorno = new BLL.UnidadeMedidaBLL().Alterar(unidadeMedida);

                        if (retorno)
                        {
                            btnExcluir.Enabled = true;
                            btnVoltar.Enabled = true;
                            dataGridUnidadeMedida.Enabled = true;
                            btnBuscar.Enabled = true;

                        }
                        else
                            MessageBox.Show("Favor verificar os parametros e tentar novamente");

                    }
                    else
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

            result = MessageBox.Show(message, "", buttons);

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
            btnBuscar.Enabled = false;
            dataGridProduto.Enabled = false;

            txtDescricaoProduto.Text = dataGridProduto.CurrentRow.Cells[1].Value.ToString();
            txtvalor.Value = decimal.Parse(dataGridProduto.CurrentRow.Cells[3].Value.ToString());
            txtQuantidade.Value = decimal.Parse(dataGridProduto.CurrentRow.Cells[4].Value.ToString());
            comboUnd.Text = dataGridProduto.CurrentRow.Cells[2].Value.ToString();

        }

        private void dataGridUnidadeMedida_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnExcluir.Enabled = false;
            btnVoltar.Enabled = false;
            btnBuscar.Enabled = false;
            dataGridUnidadeMedida.Enabled = false;

            txtSigla.Text = dataGridUnidadeMedida.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dataGridUnidadeMedida.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strWhere;

            if (panelCadastroProduto.Visible == true)
            {
                strWhere = txtDescricaoProduto.Text;

                List<Modelo.ModeloProduto> listaProduto = new BLL.ProdutoBLL().BuscarProdutos(strWhere);
                dataGridProduto.AutoGenerateColumns = false;
                dataGridProduto.DataSource = listaProduto;
                dataGridProduto.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            }
            else
            {
                strWhere = txtDescricao.Text;

                List<Modelo.ModeloUnidadeMedida> listaUnidadeMedida = new BLL.UnidadeMedidaBLL().Buscar(strWhere);
                dataGridUnidadeMedida.AutoGenerateColumns = false;
                dataGridUnidadeMedida.DataSource = listaUnidadeMedida;
                dataGridUnidadeMedida.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridUnidadeMedida.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            }

        }

        private void btnVoltarMovimento_Click(object sender, EventArgs e)
        {
            panelMovimento.Visible = false;
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMovimento.Visible = true;
            PainelBotoes.Visible = false;
            CarregaGrid();
            List<Modelo.ModeloProduto> listaProduto = new BLL.ProdutoBLL().BuscarProdutos("");
            comboProduto.DataSource = listaProduto;
            comboProduto.DisplayMember = "DescricaoProduto";
            comboProduto.ValueMember = "IdProduto";
            comboProduto.Text = "";

        }


        //Métodos da tela movimento
        private void btnSalvarMovimento_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(numericQuantidade.Value.ToString());
            string tipo;

            if (!comboProduto.SelectedText.Equals("") || quantidade > 0)
            {
                int idProduto = int.Parse(comboProduto.SelectedValue.ToString());
                Modelo.ModeloProduto produto = new Modelo.ModeloProduto();
                produto = new BLL.ProdutoBLL().RetrornaPorID(idProduto);

                if (radioSaida.Checked)
                {
                    if (produto.QuantidadeEstoque < quantidade)
                    {
                        MessageBox.Show("Quantidade em Estoque insuficiente");
                        return;
                    }
                    else
                    {
                        produto.QuantidadeEstoque = produto.QuantidadeEstoque - quantidade;
                        tipo = "S";

                    }
                }
                else
                {
                    produto.QuantidadeEstoque = produto.QuantidadeEstoque + quantidade;
                    tipo = "E";
                }
                Modelo.ModeloMovimento movimento = new Modelo.ModeloMovimento();
                movimento.idProduto = idProduto;
                movimento.Quantidade = quantidade;
                movimento.ValorTotal = double.Parse(textValorTotalMovimento.Text);
                movimento.Tipo = tipo;

                new BLL.MovimentoBLL().Incluir(movimento);
                new BLL.ProdutoBLL().Alterar(produto);

                CarregaGrid();

                //Limpa campos
                comboProduto.Text = "";
                numericQuantidade.Value = 0;
                textUndMovimento.Text = "";

            }
            else
                MessageBox.Show("Favor preencher os campos");

            CarregaGrid();
        }

        private void comboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Modelo.ModeloProduto produto = new Modelo.ModeloProduto();
                produto = new BLL.ProdutoBLL().RetrornaPorID(Convert.ToInt32(comboProduto.SelectedValue));

                textUndMovimento.Text = produto.UND;
                textValorUnitarioMovimento.Text = produto.Valor.ToString();
            }
            catch (Exception)
            {
            }

        }

        private void numericQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                double valorTotal;
                valorTotal = double.Parse(numericQuantidade.Value.ToString()) * double.Parse(textValorUnitarioMovimento.Text);
                textValorTotalMovimento.Text = valorTotal.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void comboProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboUnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExcluirMovimento_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Tem certeza que deseja excluir o registro selecionado?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, "", buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Modelo.ModeloMovimento movimento = new Modelo.ModeloMovimento();
                    movimento.idMovimento = int.Parse(dataGridMovimento.CurrentRow.Cells[1].Value.ToString());
                    movimento.Quantidade = double.Parse(dataGridMovimento.CurrentRow.Cells[4].Value.ToString());
                    movimento.Tipo = dataGridMovimento.CurrentRow.Cells[0].Value.ToString();

                    bool retorno = new BLL.MovimentoBLL().Excluir(movimento);

                    if (retorno)
                        MessageBox.Show("Registro excluído com sucesso");
                    else
                        MessageBox.Show("Falha ao tentar excluir o registro");
                }

                CarregaGrid();
            }
            catch
            {
                MessageBox.Show("Selecione o registro que deseja excluir!");
            }

        }

    }
}
