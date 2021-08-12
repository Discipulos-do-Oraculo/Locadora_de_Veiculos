
namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    partial class TabelaGrupoVeiculosControl
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
            this.dataGridViewGrupoVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupoVeiculos
            // 
            this.dataGridViewGrupoVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupoVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrupoVeiculos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGrupoVeiculos.Name = "dataGridViewGrupoVeiculos";
            this.dataGridViewGrupoVeiculos.RowHeadersWidth = 51;
            this.dataGridViewGrupoVeiculos.RowTemplate.Height = 24;
            this.dataGridViewGrupoVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupoVeiculos.Size = new System.Drawing.Size(281, 231);
            this.dataGridViewGrupoVeiculos.TabIndex = 0;
            // 
            // TabelaGrupoVeiculosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGrupoVeiculos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TabelaGrupoVeiculosControl";
            this.Size = new System.Drawing.Size(281, 231);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrupoVeiculos;
    }
}
