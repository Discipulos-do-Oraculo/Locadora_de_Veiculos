
namespace LocadoraVeiculos.WindowsForms.Features.CupomModule
{
    partial class FiltroCupomForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroCupomForm));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbNaoAgrupar = new System.Windows.Forms.RadioButton();
            this.rbdPorParceiro = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(185, 137);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(93, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbNaoAgrupar
            // 
            this.rdbNaoAgrupar.AutoSize = true;
            this.rdbNaoAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNaoAgrupar.ForeColor = System.Drawing.Color.White;
            this.rdbNaoAgrupar.Location = new System.Drawing.Point(92, 86);
            this.rdbNaoAgrupar.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNaoAgrupar.Name = "rdbNaoAgrupar";
            this.rdbNaoAgrupar.Size = new System.Drawing.Size(107, 21);
            this.rdbNaoAgrupar.TabIndex = 6;
            this.rdbNaoAgrupar.Text = "Não Agrupar";
            this.rdbNaoAgrupar.UseVisualStyleBackColor = true;
            // 
            // rbdPorParceiro
            // 
            this.rbdPorParceiro.AutoSize = true;
            this.rbdPorParceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdPorParceiro.ForeColor = System.Drawing.Color.White;
            this.rbdPorParceiro.Location = new System.Drawing.Point(92, 40);
            this.rbdPorParceiro.Margin = new System.Windows.Forms.Padding(2);
            this.rbdPorParceiro.Name = "rbdPorParceiro";
            this.rbdPorParceiro.Size = new System.Drawing.Size(159, 21);
            this.rbdPorParceiro.TabIndex = 9;
            this.rbdPorParceiro.Text = "Agrupar por Parceiro";
            this.rbdPorParceiro.UseVisualStyleBackColor = true;
            // 
            // FiltroCupomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(352, 196);
            this.Controls.Add(this.rbdPorParceiro);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdbNaoAgrupar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroCupomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroCupomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbNaoAgrupar;
        private System.Windows.Forms.RadioButton rbdPorParceiro;
    }
}