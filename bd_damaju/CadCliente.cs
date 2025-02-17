using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bd_damaju
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNomeCompleto.Text = "";
            textBoxSenha.Text = "";
            maskedTextBoxCPF.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxNomeCompleto.Focus();
        }

        private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdFoto_Click(object sender, EventArgs e)
        {
            // Abrir o OpenFileDialog para selecionar a imagem
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            // Filtro para arquivos de imagem
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exibir a imagem no PictureBox
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF VÁLIDO";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {

                labelAlert.Text = "CPF INVÁLIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
            }

   

            //Defina sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            //Defina a inserção de registro no banco de dados

            string query = "INSERT INTO tb_clientes (NomeCompleto, Senha, Email, CPF, CEP, Numero, Telefone, Imagem) VALUES " +
                "(@NomeCompleto, @Senha, @Email, @CPF, @CEP, @Numero, @Telefone, @Imagem)";

            //Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                try
                {
                    // Converter a imagem para um array de bytes
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();

                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parametros com os valores des TextBox
                        comando.Parameters.AddWithValue("@NomeCompleto", textBoxNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@Senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@CPF", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@CEP", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@Imagem", imageBytes);

                        //Executa o comando de inserção

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");


                    }


                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem de erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        
    }
}
