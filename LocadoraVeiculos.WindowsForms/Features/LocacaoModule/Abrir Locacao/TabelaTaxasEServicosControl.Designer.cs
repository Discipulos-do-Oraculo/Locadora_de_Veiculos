
namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    partial class TabelaTaxasEServicosControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbTaxas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbTaxas
            // 
            this.clbTaxas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTaxas.FormattingEnabled = true;
            this.clbTaxas.Location = new System.Drawing.Point(0, 0);
            this.clbTaxas.Name = "clbTaxas";
            this.clbTaxas.Size = new System.Drawing.Size(343, 241);
            this.clbTaxas.TabIndex = 0;
            // 
            // TabelaTaxasEServicosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clbTaxas);
            this.Name = "TabelaTaxasEServicosControl";
            this.Size = new System.Drawing.Size(343, 241);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTaxas;
    }
}
