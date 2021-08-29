
namespace LocadoraVeiculos.WindowsForms.Features.ParceiroModule
{
    partial class TabelaParceiroControl
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
            this.gridParceiro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridParceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // gridParceiro
            // 
            this.gridParceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParceiro.Location = new System.Drawing.Point(0, 0);
            this.gridParceiro.MultiSelect = false;
            this.gridParceiro.Name = "gridParceiro";
            this.gridParceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParceiro.Size = new System.Drawing.Size(150, 150);
            this.gridParceiro.TabIndex = 0;
            // 
            // TabelaParceiroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridParceiro);
            this.Name = "TabelaParceiroControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridParceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridParceiro;
    }
}
