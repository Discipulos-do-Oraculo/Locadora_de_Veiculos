
namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    partial class TelaSelecionarPessoaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSelecionarPessoaForm));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdicionar.Location = new System.Drawing.Point(509, 320);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(28, 54);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(909, 250);
            this.panelCentral.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(383, 320);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbPessoaJuridica
            // 
            this.rdbPessoaJuridica.AutoSize = true;
            this.rdbPessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.rdbPessoaJuridica.Location = new System.Drawing.Point(150, 27);
            this.rdbPessoaJuridica.Name = "rdbPessoaJuridica";
            this.rdbPessoaJuridica.Size = new System.Drawing.Size(129, 21);
            this.rdbPessoaJuridica.TabIndex = 16;
            this.rdbPessoaJuridica.TabStop = true;
            this.rdbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rdbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdbPessoaJuridica_CheckedChanged);
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.ForeColor = System.Drawing.Color.White;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(28, 27);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(116, 21);
            this.rdbPessoaFisica.TabIndex = 17;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Pessoa Física";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            this.rdbPessoaFisica.CheckedChanged += new System.EventHandler(this.rdbPessoaFisica_CheckedChanged);
            // 
            // TelaSelecionarPessoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(979, 375);
            this.Controls.Add(this.rdbPessoaFisica);
            this.Controls.Add(this.rdbPessoaJuridica);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaSelecionarPessoaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbPessoaJuridica;
        private System.Windows.Forms.RadioButton rdbPessoaFisica;
    }
}