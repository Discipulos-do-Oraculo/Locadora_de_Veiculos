
namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeTaxasEServicos
{
    partial class TabelaTaxasEServicos
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
            this.dataGridViewTaxasEServicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxasEServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTaxasEServicos
            // 
            this.dataGridViewTaxasEServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaxasEServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTaxasEServicos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTaxasEServicos.MultiSelect = false;
            this.dataGridViewTaxasEServicos.Name = "dataGridViewTaxasEServicos";
            this.dataGridViewTaxasEServicos.RowHeadersWidth = 51;
            this.dataGridViewTaxasEServicos.RowTemplate.Height = 24;
            this.dataGridViewTaxasEServicos.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewTaxasEServicos.TabIndex = 0;
            // 
            // TabelaTaxasEServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTaxasEServicos);
            this.Name = "TabelaTaxasEServicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaxasEServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTaxasEServicos;
    }
}
