
namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    partial class TabelaDevolucaoControl
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
            this.gridDevolucao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDevolucao
            // 
            this.gridDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevolucao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevolucao.Location = new System.Drawing.Point(0, 0);
            this.gridDevolucao.MultiSelect = false;
            this.gridDevolucao.Name = "gridDevolucao";
            this.gridDevolucao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDevolucao.Size = new System.Drawing.Size(281, 231);
            this.gridDevolucao.TabIndex = 0;
            // 
            // TabelaDevolucaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDevolucao);
            this.Name = "TabelaDevolucaoControl";
            this.Size = new System.Drawing.Size(281, 231);
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDevolucao;
    }
}
