
namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    partial class TabelaAbrirLocacaoControl
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
            this.dataGridViewLocaoesAbertas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocaoesAbertas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLocaoesAbertas
            // 
            this.dataGridViewLocaoesAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocaoesAbertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLocaoesAbertas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLocaoesAbertas.MultiSelect = false;
            this.dataGridViewLocaoesAbertas.Name = "dataGridViewLocaoesAbertas";
            this.dataGridViewLocaoesAbertas.RowHeadersWidth = 51;
            this.dataGridViewLocaoesAbertas.RowTemplate.Height = 24;
            this.dataGridViewLocaoesAbertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocaoesAbertas.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewLocaoesAbertas.TabIndex = 0;
            // 
            // TabelaAbrirLocacaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewLocaoesAbertas);
            this.Name = "TabelaAbrirLocacaoControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocaoesAbertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLocaoesAbertas;
    }
}
