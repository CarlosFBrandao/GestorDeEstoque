using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcoes;

namespace GestorDeEstoque.Telas
{
    public partial class frmConfiguraConexao : Form
    {
        public frmConfiguraConexao()
        {
            InitializeComponent();
        }

        string instancia, banco, usuario, senha;

        private void frmConfiguraConexao_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBancoDados.dll");
                txtInstancia.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();

            }
            catch
            {

                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                "Acesse as configurações do banco de dados e informe os parâmetros de conexao");

            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtInstancia.Text) || string.IsNullOrWhiteSpace(txtBanco.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                if (txtInstancia.Text == "")
                {
                    instancia = "instancia";
                }
                if (txtBanco.Text == "")
                {
                    instancia = "";
                    banco = "banco";
                }
                MessageBox.Show("Campo Obrigatório ");
            }
            else
            {
                try
                {
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=" + txtInstancia.Text + ";Initial Catalog=" + txtBanco.Text + ";User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text + "";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    MessageBox.Show("Conectado com sucesso!");
                    cnn.Close();
                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                   "Verifique os dados informados" + erro);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDados.dll", false);
                arquivo.WriteLine(txtInstancia.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                new CriaTabelas().Criar();
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }


}

