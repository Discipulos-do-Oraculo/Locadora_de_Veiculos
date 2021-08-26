
namespace LocadoraVeiculos.WindowsForms.Features.MidiaModule
{
    partial class TabelaMidiaControl
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
            this.gridMidia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMidia)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMidia
            // 
            this.gridMidia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMidia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMidia.Location = new System.Drawing.Point(0, 0);
            this.gridMidia.MultiSelect = false;
            this.gridMidia.Name = "gridMidia";
            this.gridMidia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMidia.Size = new System.Drawing.Size(150, 150);
            this.gridMidia.TabIndex = 0;
            // 
            // TabelaMidiaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridMidia);
            this.Name = "TabelaMidiaControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridMidia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMidia;
    }
}
