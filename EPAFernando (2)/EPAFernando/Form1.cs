using System;
using System.Windows.Forms;

namespace EPAFernando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDadosExibidos.Text = "Preencha os dados e clique em Salvar.";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criar variáveis e pegar valores dos componentes
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            int idade = (int)txtIdade.Value;
            string cpf = txtCPF.Text;

            // Exibir valores no Label
            lblDadosExibidos.Text = $"Nome: {nome}\nTelefone: {telefone}\nE-mail: {email}\nIdade: {idade}\nCPF: {cpf}";

            // Limpar campos
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtIdade.Value = 0;
            txtCPF.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
