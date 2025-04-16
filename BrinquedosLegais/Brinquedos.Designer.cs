namespace BrinquedosLegais
{
    partial class Brinquedos
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtNome = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtCodBarra = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtIdadeMinima = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtCategoria = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtDescricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-------FABRICANTE-------";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(53, 25);
            this.mtxtCnpj.Mask = "99999999999999";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(156, 20);
            this.mtxtCnpj.TabIndex = 2;
            this.mtxtCnpj.Validating += new System.ComponentModel.CancelEventHandler(this.btnCpnjValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOME:";
            // 
            // mtxtNome
            // 
            this.mtxtNome.Location = new System.Drawing.Point(53, 51);
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.Size = new System.Drawing.Size(156, 20);
            this.mtxtNome.TabIndex = 4;
            this.mtxtNome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNome_MaskInputRejected);
            this.mtxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.btnNomeValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PREÇO:";
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Location = new System.Drawing.Point(63, 147);
            this.mtxtPreco.Mask = "9999,99";
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(146, 20);
            this.mtxtPreco.TabIndex = 9;
            this.mtxtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPreco_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "COD BARRAS:";
            // 
            // mtxtCodBarra
            // 
            this.mtxtCodBarra.Location = new System.Drawing.Point(96, 121);
            this.mtxtCodBarra.Mask = "9999999999999";
            this.mtxtCodBarra.Name = "mtxtCodBarra";
            this.mtxtCodBarra.Size = new System.Drawing.Size(113, 20);
            this.mtxtCodBarra.TabIndex = 7;
            this.mtxtCodBarra.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtCodBarraValidating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "-------PRODUTO-------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "IDADE MÍNIMA:";
            // 
            // mtxtIdadeMinima
            // 
            this.mtxtIdadeMinima.Location = new System.Drawing.Point(363, 51);
            this.mtxtIdadeMinima.Mask = "99";
            this.mtxtIdadeMinima.Name = "mtxtIdadeMinima";
            this.mtxtIdadeMinima.Size = new System.Drawing.Size(100, 20);
            this.mtxtIdadeMinima.TabIndex = 14;
            this.mtxtIdadeMinima.Validating += new System.ComponentModel.CancelEventHandler(this.btnIdadeMinimaValidating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CATEGORIA:";
            // 
            // mtxtCategoria
            // 
            this.mtxtCategoria.Location = new System.Drawing.Point(350, 25);
            this.mtxtCategoria.Name = "mtxtCategoria";
            this.mtxtCategoria.Size = new System.Drawing.Size(113, 20);
            this.mtxtCategoria.TabIndex = 12;
            this.mtxtCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.btnCategoriaValidating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "-------BRINQUEDO-------";
            // 
            // mtxtDescricao
            // 
            this.mtxtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxtDescricao.Location = new System.Drawing.Point(12, 186);
            this.mtxtDescricao.Multiline = true;
            this.mtxtDescricao.Name = "mtxtDescricao";
            this.mtxtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mtxtDescricao.Size = new System.Drawing.Size(197, 80);
            this.mtxtDescricao.TabIndex = 16;
            this.mtxtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.btnDescricaovalidating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "DESCRIÇÃO:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.Location = new System.Drawing.Point(215, 311);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 21;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(6, 314);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(203, 20);
            this.txtCaminho.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Caminho:";
            // 
            // Brinquedos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtxtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtIdadeMinima);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtCodBarra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtCnpj);
            this.Controls.Add(this.label2);
            this.Name = "Brinquedos";
            this.Text = "Cadastro Brinquedo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtCodBarra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtIdadeMinima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mtxtDescricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label11;
    }
}