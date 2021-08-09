
namespace LocadoraVeiculos.WindowsForms
{
    partial class TelaPrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFísicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaJuridicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.colaboradorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFísicaToolStripMenuItem,
            this.pessoaJuridicaToolStripMenuItem,
            this.condutorToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // pessoaFísicaToolStripMenuItem
            // 
            this.pessoaFísicaToolStripMenuItem.Name = "pessoaFísicaToolStripMenuItem";
            this.pessoaFísicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoaFísicaToolStripMenuItem.Text = "Pessoa Física";
            this.pessoaFísicaToolStripMenuItem.Click += new System.EventHandler(this.pessoaFísicaToolStripMenuItem_Click);
            // 
            // pessoaJuridicaToolStripMenuItem
            // 
            this.pessoaJuridicaToolStripMenuItem.Name = "pessoaJuridicaToolStripMenuItem";
            this.pessoaJuridicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pessoaJuridicaToolStripMenuItem.Text = "Pessoa Juridica";
            // 
            // condutorToolStripMenuItem
            // 
            this.condutorToolStripMenuItem.Name = "condutorToolStripMenuItem";
            this.condutorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.condutorToolStripMenuItem.Text = "Condutor";
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.colaboradorToolStripMenuItem.Text = "Colaborador";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 703);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(890, 733);
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaFísicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaJuridicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
    }
}