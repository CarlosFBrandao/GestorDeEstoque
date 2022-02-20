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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelCadastroUnidadeMedida.Visible = true;
            PainelBotoes.Visible = true;
            panelCadastroProduto.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PainelCadastroUnidadeMedida.Visible = false;
            PainelBotoes.Visible = false;
            panelCadastroProduto.Visible = false;

        }


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCadastroProduto.Visible = true;
            PainelBotoes.Visible = true;
            PainelCadastroUnidadeMedida.Visible = false;
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
                }

                else if (PainelCadastroUnidadeMedida.Visible == true)
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

                if(id.Equals("0"))
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

    }
}
