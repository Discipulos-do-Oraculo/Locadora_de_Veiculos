
namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    partial class TabelaCupomControl
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
            this.gridCupom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCupom)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCupom
            // 
            this.gridCupom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCupom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCupom.Location = new System.Drawing.Point(0, 0);
            this.gridCupom.MultiSelect = false;
            this.gridCupom.Name = "gridCupom";
            this.gridCupom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCupom.Size = new System.Drawing.Size(150, 150);
            this.gridCupom.TabIndex = 0;
            // 
            // TabelaCupomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCupom);
            this.Name = "TabelaCupomControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridCupom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCupom;
    }
}
