namespace BrinquedosLegais
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrinquedo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstMenuVizualizacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tstMenuCadBrinquedo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVizualizacao = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomes: Miguel e Pablo";
            // 
            // btnBrinquedo
            // 
            this.btnBrinquedo.Location = new System.Drawing.Point(12, 28);
            this.btnBrinquedo.Name = "btnBrinquedo";
            this.btnBrinquedo.Size = new System.Drawing.Size(75, 23);
            this.btnBrinquedo.TabIndex = 1;
            this.btnBrinquedo.Text = "Brinquedo";
            this.btnBrinquedo.UseVisualStyleBackColor = true;
            this.btnBrinquedo.Click += new System.EventHandler(this.btnBrinquedo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstMenu
            // 
            this.tstMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstMenuVizualizacao,
            this.tstMenuCadBrinquedo});
            this.tstMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(51, 22);
            this.tstMenu.Text = "Menu";
            // 
            // tstMenuVizualizacao
            // 
            this.tstMenuVizualizacao.Name = "tstMenuVizualizacao";
            this.tstMenuVizualizacao.Size = new System.Drawing.Size(184, 22);
            this.tstMenuVizualizacao.Text = "Vizualização";
            this.tstMenuVizualizacao.Click += new System.EventHandler(this.tstMenuVizualizacao_Click);
            // 
            // tstMenuCadBrinquedo
            // 
            this.tstMenuCadBrinquedo.Name = "tstMenuCadBrinquedo";
            this.tstMenuCadBrinquedo.Size = new System.Drawing.Size(184, 22);
            this.tstMenuCadBrinquedo.Text = "Cadastro Brinquedos";
            this.tstMenuCadBrinquedo.Click += new System.EventHandler(this.tstMenuCadBrinquedo_Click);
            // 
            // btnVizualizacao
            // 
            this.btnVizualizacao.Location = new System.Drawing.Point(12, 57);
            this.btnVizualizacao.Name = "btnVizualizacao";
            this.btnVizualizacao.Size = new System.Drawing.Size(75, 23);
            this.btnVizualizacao.TabIndex = 4;
            this.btnVizualizacao.Text = "Vizualizacao";
            this.btnVizualizacao.UseVisualStyleBackColor = true;
            this.btnVizualizacao.Click += new System.EventHandler(this.btnVizualizacao_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrinquedosLegais.Properties.Resources.Fundo_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 372);
            this.Controls.Add(this.btnVizualizacao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBrinquedo);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Loja de Brinquedos";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrinquedo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tstMenu;
        private System.Windows.Forms.ToolStripMenuItem tstMenuVizualizacao;
        private System.Windows.Forms.ToolStripMenuItem tstMenuCadBrinquedo;
        private System.Windows.Forms.Button btnVizualizacao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

