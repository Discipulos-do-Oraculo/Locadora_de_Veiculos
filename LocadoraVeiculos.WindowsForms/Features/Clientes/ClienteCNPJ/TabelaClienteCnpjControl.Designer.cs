﻿
namespace LocadoraVeiculos.WindowsForms.Features.Clientes.ClienteCNPJ
{
    partial class TabelaClienteCnpjControl
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
            this.gridClienteCnpj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClienteCnpj)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClienteCnpj
            // 
            this.gridClienteCnpj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClienteCnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClienteCnpj.Location = new System.Drawing.Point(0, 0);
            this.gridClienteCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.gridClienteCnpj.Name = "gridClienteCnpj";
            this.gridClienteCnpj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClienteCnpj.Size = new System.Drawing.Size(281, 231);
            this.gridClienteCnpj.TabIndex = 0;
            // 
            // TabaleaClienteCnpjControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridClienteCnpj);
            this.Name = "TabaleaClienteCnpjControl";
            this.Size = new System.Drawing.Size(281, 231);
            ((System.ComponentModel.ISupportInitialize)(this.gridClienteCnpj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClienteCnpj;
    }
}
