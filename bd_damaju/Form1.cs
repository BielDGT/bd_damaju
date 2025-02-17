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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadCliente_Click(object sender, EventArgs e)
        {
            CadCliente form = new CadCliente();
            form.ShowDialog();
        }

        private void buttonCadProduto_Click(object sender, EventArgs e)
        {
            CadProduto form = new CadProduto();
            form.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGerenciar_Click(object sender, EventArgs e)
        {
            Gerenciamento form = new Gerenciamento();
            form.ShowDialog();
        }
    }
}
