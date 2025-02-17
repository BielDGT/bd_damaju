namespace bd_damaju
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCadProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGerenciar = new System.Windows.Forms.Button();
            this.buttonCadCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadProduto
            // 
            this.buttonCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadProduto.Location = new System.Drawing.Point(458, 169);
            this.buttonCadProduto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadProduto.Name = "buttonCadProduto";
            this.buttonCadProduto.Size = new System.Drawing.Size(230, 59);
            this.buttonCadProduto.TabIndex = 17;
            this.buttonCadProduto.Text = "Cadastro de Produto";
            this.buttonCadProduto.UseVisualStyleBackColor = true;
            this.buttonCadProduto.Click += new System.EventHandler(this.buttonCadProduto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(458, 328);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(230, 59);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGerenciar
            // 
            this.buttonGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerenciar.Location = new System.Drawing.Point(458, 253);
            this.buttonGerenciar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerenciar.Name = "buttonGerenciar";
            this.buttonGerenciar.Size = new System.Drawing.Size(230, 59);
            this.buttonGerenciar.TabIndex = 13;
            this.buttonGerenciar.Text = "Gerenciamento";
            this.buttonGerenciar.UseVisualStyleBackColor = true;
            this.buttonGerenciar.Click += new System.EventHandler(this.buttonGerenciar_Click);
            // 
            // buttonCadCliente
            // 
            this.buttonCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadCliente.Location = new System.Drawing.Point(458, 88);
            this.buttonCadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadCliente.Name = "buttonCadCliente";
            this.buttonCadCliente.Size = new System.Drawing.Size(230, 59);
            this.buttonCadCliente.TabIndex = 12;
            this.buttonCadCliente.Text = "Cadastrar Cliente";
            this.buttonCadCliente.UseVisualStyleBackColor = true;
            this.buttonCadCliente.Click += new System.EventHandler(this.buttonCadCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu Principal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCadProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGerenciar);
            this.Controls.Add(this.buttonCadCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGerenciar;
        private System.Windows.Forms.Button buttonCadCliente;
        private System.Windows.Forms.Label label1;
    }
}

