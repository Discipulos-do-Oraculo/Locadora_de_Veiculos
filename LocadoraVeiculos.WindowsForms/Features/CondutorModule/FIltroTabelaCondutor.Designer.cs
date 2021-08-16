
namespace LocadoraVeiculos.WindowsForms.Features.CondutorModule
{
    partial class FIltroTabelaCondutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIltroTabelaCondutor));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbNaoAgrupar = new System.Windows.Forms.RadioButton();
            this.rdbAgruparPorGrupo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(233, 168);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(111, 168);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbNaoAgrupar
            // 
            this.rdbNaoAgrupar.AutoSize = true;
            this.rdbNaoAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNaoAgrupar.ForeColor = System.Drawing.Color.White;
            this.rdbNaoAgrupar.Location = new System.Drawing.Point(109, 90);
            this.rdbNaoAgrupar.Name = "rdbNaoAgrupar";
            this.rdbNaoAgrupar.Size = new System.Drawing.Size(124, 24);
            this.rdbNaoAgrupar.TabIndex = 2;
            this.rdbNaoAgrupar.Text = "Não Agrupar";
            this.rdbNaoAgrupar.UseVisualStyleBackColor = true;
            // 
            // rdbAgruparPorGrupo
            // 
            this.rdbAgruparPorGrupo.AutoSize = true;
            this.rdbAgruparPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAgruparPorGrupo.ForeColor = System.Drawing.Color.White;
            this.rdbAgruparPorGrupo.Location = new System.Drawing.Point(109, 44);
            this.rdbAgruparPorGrupo.Name = "rdbAgruparPorGrupo";
            this.rdbAgruparPorGrupo.Size = new System.Drawing.Size(190, 24);
            this.rdbAgruparPorGrupo.TabIndex = 1;
            this.rdbAgruparPorGrupo.Text = "Agrupar por Empresa";
            this.rdbAgruparPorGrupo.UseVisualStyleBackColor = true;
            // 
            // FIltroTabelaCondutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdbNaoAgrupar);
            this.Controls.Add(this.rdbAgruparPorGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FIltroTabelaCondutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Condutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbNaoAgrupar;
        private System.Windows.Forms.RadioButton rdbAgruparPorGrupo;
    }
}