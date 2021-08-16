
namespace LocadoraVeiculos.WindowsForms.Features.VeiculosModule.CadastroDeVeiculos
{
    partial class FiltroTabelaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroTabelaVeiculo));
            this.rdbAgruparPorGrupo = new System.Windows.Forms.RadioButton();
            this.rdbNaoAgrupar = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbAgruparPorGrupo
            // 
            this.rdbAgruparPorGrupo.AutoSize = true;
            this.rdbAgruparPorGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAgruparPorGrupo.ForeColor = System.Drawing.Color.White;
            this.rdbAgruparPorGrupo.Location = new System.Drawing.Point(115, 57);
            this.rdbAgruparPorGrupo.Name = "rdbAgruparPorGrupo";
            this.rdbAgruparPorGrupo.Size = new System.Drawing.Size(252, 24);
            this.rdbAgruparPorGrupo.TabIndex = 0;
            this.rdbAgruparPorGrupo.Text = "Agrupar por Grupo de Veículo";
            this.rdbAgruparPorGrupo.UseVisualStyleBackColor = true;
            // 
            // rdbNaoAgrupar
            // 
            this.rdbNaoAgrupar.AutoSize = true;
            this.rdbNaoAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNaoAgrupar.ForeColor = System.Drawing.Color.White;
            this.rdbNaoAgrupar.Location = new System.Drawing.Point(115, 103);
            this.rdbNaoAgrupar.Name = "rdbNaoAgrupar";
            this.rdbNaoAgrupar.Size = new System.Drawing.Size(124, 24);
            this.rdbNaoAgrupar.TabIndex = 1;
            this.rdbNaoAgrupar.Text = "Não Agrupar";
            this.rdbNaoAgrupar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(239, 181);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(117, 181);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FiltroTabelaVeiculo
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
            this.Name = "FiltroTabelaVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Veiculo";
            this.Load += new System.EventHandler(this.FiltroTabelaVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAgruparPorGrupo;
        private System.Windows.Forms.RadioButton rdbNaoAgrupar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}