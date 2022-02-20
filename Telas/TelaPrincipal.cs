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

        private void PainelCadastroUnidadeMedida_Paint(object sender, PaintEventArgs e)
        {

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

        private void PainelBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            PainelBotoes.Visible = false;
            PainelCadastroUnidadeMedida.Visible = false;
            panelCadastroProduto.Visible = false;
        }
    }
}
