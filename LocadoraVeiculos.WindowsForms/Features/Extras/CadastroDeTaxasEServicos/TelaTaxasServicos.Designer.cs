﻿
namespace LocadoraVeiculos.WindowsForms.Features.Extras
{
    partial class TelaTaxasServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTaxasServicos));
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.radioDiaria = new System.Windows.Forms.RadioButton();
            this.radioFixo = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValor.Location = new System.Drawing.Point(539, 132);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(183, 22);
            this.textBoxValor.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(533, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 29);
            this.label7.TabIndex = 109;
            this.label7.Text = "Valor :";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(272, 132);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(183, 22);
            this.textBoxNome.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 106;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(272, 57);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(54, 22);
            this.textBoxId.TabIndex = 105;
            // 
            // radioDiaria
            // 
            this.radioDiaria.AutoSize = true;
            this.radioDiaria.ForeColor = System.Drawing.Color.White;
            this.radioDiaria.Location = new System.Drawing.Point(272, 196);
            this.radioDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.radioDiaria.Name = "radioDiaria";
            this.radioDiaria.Size = new System.Drawing.Size(139, 21);
            this.radioDiaria.TabIndex = 111;
            this.radioDiaria.TabStop = true;
            this.radioDiaria.Text = "Cálculo por diária";
            this.radioDiaria.UseVisualStyleBackColor = true;
            // 
            // radioFixo
            // 
            this.radioFixo.AutoSize = true;
            this.radioFixo.ForeColor = System.Drawing.Color.White;
            this.radioFixo.Location = new System.Drawing.Point(272, 239);
            this.radioFixo.Margin = new System.Windows.Forms.Padding(4);
            this.radioFixo.Name = "radioFixo";
            this.radioFixo.Size = new System.Drawing.Size(100, 21);
            this.radioFixo.TabIndex = 112;
            this.radioFixo.TabStop = true;
            this.radioFixo.Text = "Cálculo fixo";
            this.radioFixo.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(501, 311);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 114;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(375, 311);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTaxasServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(979, 375);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.radioFixo);
            this.Controls.Add(this.radioDiaria);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTaxasServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Taxas e Serviços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.RadioButton radioDiaria;
        private System.Windows.Forms.RadioButton radioFixo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}