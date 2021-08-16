
namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    partial class TabelaCondutorControl
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
            this.gridCondutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondutor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCondutor
            // 
            this.gridCondutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCondutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCondutor.Location = new System.Drawing.Point(0, 0);
            this.gridCondutor.Margin = new System.Windows.Forms.Padding(4);
            this.gridCondutor.Name = "gridCondutor";
            this.gridCondutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCondutor.Size = new System.Drawing.Size(281, 231);
            this.gridCondutor.TabIndex = 0;
            // 
            // TabelaCondutorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCondutor);
            this.Name = "TabelaCondutorControl";
            this.Size = new System.Drawing.Size(281, 231);
            ((System.ComponentModel.ISupportInitialize)(this.gridCondutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCondutor;
    }
}
