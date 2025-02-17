using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_damaju
{
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            //Defina a inserção de registro no banco de dados

            string query = "INSERT INTO tb_produto (Nome, Valor, Categoria, Descrição, Imagem) VALUES " +
                "(@Nome, @Valor, @Categoria, @Descrição, @Imagem)";

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
                        comando.Parameters.AddWithValue("@Nome", textBoxNomeProduto.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Categoria", comboBoxCategoria.Text);
                        comando.Parameters.AddWithValue("@Descrição", richTextBoxDesc.Text);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNomeProduto.Text = "";
            maskedTextBoxValor.Text = "";
            comboBoxCategoria.Text = "";
            richTextBoxDesc.Text = "";
            textBoxNomeProduto.Focus();
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
    }
}
