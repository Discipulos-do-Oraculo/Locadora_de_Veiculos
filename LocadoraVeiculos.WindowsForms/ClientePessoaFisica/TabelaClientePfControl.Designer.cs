
namespace LocadoraVeiculos.WindowsForms.ClientePessoaFisica
{
    partial class TabelaClientePfControl
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
            this.gridClientePF = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientePF)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientePF
            // 
            this.gridClientePF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientePF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClientePF.Location = new System.Drawing.Point(0, 0);
            this.gridClientePF.Margin = new System.Windows.Forms.Padding(4);
            this.gridClientePF.Name = "gridClientePF";
            this.gridClientePF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientePF.Size = new System.Drawing.Size(281, 231);
            this.gridClientePF.TabIndex = 0;
            // 
            // TabelaClientePfControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridClientePF);
            this.Name = "TabelaClientePfControl";
            this.Size = new System.Drawing.Size(281, 231);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientePF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientePF;
    }
}
