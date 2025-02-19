using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_damaju
{
    public partial class Login : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }

        private void buttonMostrarSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMenssagem.Text = "Login bem-sucedido";
                labelMenssagem.ForeColor = Color.Green;
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                labelMenssagem.Text = "Usuário ou senha Invalida";
                labelMenssagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }
    }
}
