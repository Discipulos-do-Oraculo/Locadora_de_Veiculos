
namespace LocadoraVeiculos.WindowsForms.Features.Extras.CadastroDeCombustivel
{
    partial class TabelaCombustivelControl
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
            this.dataGridViewCombustivelControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombustivelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCombustivelControl
            // 
            this.dataGridViewCombustivelControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCombustivelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCombustivelControl.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCombustivelControl.MultiSelect = false;
            this.dataGridViewCombustivelControl.Name = "dataGridViewCombustivelControl";
            this.dataGridViewCombustivelControl.RowHeadersWidth = 51;
            this.dataGridViewCombustivelControl.RowTemplate.Height = 24;
            this.dataGridViewCombustivelControl.Size = new System.Drawing.Size(324, 250);
            this.dataGridViewCombustivelControl.TabIndex = 0;
            // 
            // TabelaCombustivelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCombustivelControl);
            this.Name = "TabelaCombustivelControl";
            this.Size = new System.Drawing.Size(324, 250);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombustivelControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCombustivelControl;
    }
}
