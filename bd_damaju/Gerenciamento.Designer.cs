namespace bd_damaju
{
    partial class Gerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemoverProduto = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.dgvGerenciamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerenciamento)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoverProduto
            // 
            this.buttonRemoverProduto.Location = new System.Drawing.Point(352, 41);
            this.buttonRemoverProduto.Name = "buttonRemoverProduto";
            this.buttonRemoverProduto.Size = new System.Drawing.Size(103, 23);
            this.buttonRemoverProduto.TabIndex = 4;
            this.buttonRemoverProduto.Text = "Remover Produto";
            this.buttonRemoverProduto.UseVisualStyleBackColor = true;
            this.buttonRemoverProduto.Visible = false;
            this.buttonRemoverProduto.Click += new System.EventHandler(this.buttonRemoverProduto_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(546, 18);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 35);
            this.labelText.TabIndex = 14;
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(352, 13);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(97, 23);
            this.buttonPesquisarProduto.TabIndex = 3;
            this.buttonPesquisarProduto.Text = "Produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(455, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciamento\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.Location = new System.Drawing.Point(238, 41);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(107, 23);
            this.buttonRemoverClientes.TabIndex = 2;
            this.buttonRemoverClientes.Text = "Remover Cliente";
            this.buttonRemoverClientes.UseVisualStyleBackColor = true;
            this.buttonRemoverClientes.Visible = false;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(238, 13);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(107, 23);
            this.buttonPesquisarClientes.TabIndex = 1;
            this.buttonPesquisarClientes.Text = "Clientes";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click);
            // 
            // dgvGerenciamento
            // 
            this.dgvGerenciamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGerenciamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGerenciamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerenciamento.Location = new System.Drawing.Point(12, 70);
            this.dgvGerenciamento.Name = "dgvGerenciamento";
            this.dgvGerenciamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGerenciamento.Size = new System.Drawing.Size(1016, 367);
            this.dgvGerenciamento.TabIndex = 8;
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.buttonRemoverProduto);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonPesquisarProduto);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverClientes);
            this.Controls.Add(this.buttonPesquisarClientes);
            this.Controls.Add(this.dgvGerenciamento);
            this.Name = "Gerenciamento";
            this.Text = "Gerenciamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerenciamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoverProduto;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.DataGridView dgvGerenciamento;
    }
}