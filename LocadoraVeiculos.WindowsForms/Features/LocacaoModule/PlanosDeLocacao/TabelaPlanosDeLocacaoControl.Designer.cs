
namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.PlanosDeLocacao
{
    partial class TabelaPlanosDeLocacaoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPlanoDeLocacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlanoDeLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPlanoDeLocacao
            // 
            this.gridPlanoDeLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlanoDeLocacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPlanoDeLocacao.Location = new System.Drawing.Point(0, 0);
            this.gridPlanoDeLocacao.Margin = new System.Windows.Forms.Padding(4);
            this.gridPlanoDeLocacao.Name = "gridPlanoDeLocacao";
            this.gridPlanoDeLocacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPlanoDeLocacao.Size = new System.Drawing.Size(150, 150);
            this.gridPlanoDeLocacao.TabIndex = 0;
            // 
            // TabelaPlanosDeLocacaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPlanoDeLocacao);
            this.Name = "TabelaPlanosDeLocacaoControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridPlanoDeLocacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPlanoDeLocacao;
    }
}
