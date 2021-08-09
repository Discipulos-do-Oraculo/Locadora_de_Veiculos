
namespace LocadoraVeiculos.WindowsForms.Features.Clientes
{
    partial class TabelaClienteCondutorControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridClienteCondutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClienteCondutor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClienteCondutor
            // 
            this.gridClienteCondutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClienteCondutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClienteCondutor.Location = new System.Drawing.Point(0, 0);
            this.gridClienteCondutor.Margin = new System.Windows.Forms.Padding(4);
            this.gridClienteCondutor.Name = "gridClienteCondutor";
            this.gridClienteCondutor.RowHeadersWidth = 51;
            this.gridClienteCondutor.Size = new System.Drawing.Size(448, 372);
            this.gridClienteCondutor.TabIndex = 0;
            // 
            // TabelaClienteCondutorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridClienteCondutor);
            this.Name = "TabelaClienteCondutorControl";
            this.Size = new System.Drawing.Size(448, 372);
            ((System.ComponentModel.ISupportInitialize)(this.gridClienteCondutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClienteCondutor;
    }
}
