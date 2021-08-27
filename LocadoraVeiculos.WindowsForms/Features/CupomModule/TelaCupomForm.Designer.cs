
namespace LocadoraVeiculos.WindowsForms
{
    partial class TelaCupomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCupomForm));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecionarParceiro = new System.Windows.Forms.Button();
            this.lblParceiro = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.rdbCalculoPorcentagem = new System.Windows.Forms.RadioButton();
            this.rdbCalculoReal = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.LightGray;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(408, 275);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(302, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(220, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 258;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 257;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(220, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(41, 20);
            this.textBoxId.TabIndex = 256;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Location = new System.Drawing.Point(220, 129);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(151, 20);
            this.dtpInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(404, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 269;
            this.label3.Text = "Data Final:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(408, 129);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(151, 20);
            this.dtpFinal.TabIndex = 4;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataInicio.Location = new System.Drawing.Point(216, 106);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(101, 24);
            this.lblDataInicio.TabIndex = 271;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(404, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 272;
            this.label4.Text = "Parceiro:";
            // 
            // btnSelecionarParceiro
            // 
            this.btnSelecionarParceiro.Location = new System.Drawing.Point(484, 60);
            this.btnSelecionarParceiro.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarParceiro.Name = "btnSelecionarParceiro";
            this.btnSelecionarParceiro.Size = new System.Drawing.Size(74, 19);
            this.btnSelecionarParceiro.TabIndex = 2;
            this.btnSelecionarParceiro.Text = "Selecionar";
            this.btnSelecionarParceiro.UseVisualStyleBackColor = true;
            this.btnSelecionarParceiro.Click += new System.EventHandler(this.btnSelecionarParceiro_Click);
            // 
            // lblParceiro
            // 
            this.lblParceiro.AutoSize = true;
            this.lblParceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParceiro.ForeColor = System.Drawing.Color.White;
            this.lblParceiro.Location = new System.Drawing.Point(404, 78);
            this.lblParceiro.Name = "lblParceiro";
            this.lblParceiro.Size = new System.Drawing.Size(0, 24);
            this.lblParceiro.TabIndex = 274;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(408, 223);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 20);
            this.txtValor.TabIndex = 8;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtValorMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorMinimo.Location = new System.Drawing.Point(220, 223);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(150, 20);
            this.txtValorMinimo.TabIndex = 7;
            this.txtValorMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMinimo_KeyPress);
            // 
            // rdbCalculoPorcentagem
            // 
            this.rdbCalculoPorcentagem.AutoSize = true;
            this.rdbCalculoPorcentagem.ForeColor = System.Drawing.Color.White;
            this.rdbCalculoPorcentagem.Location = new System.Drawing.Point(408, 168);
            this.rdbCalculoPorcentagem.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCalculoPorcentagem.Name = "rdbCalculoPorcentagem";
            this.rdbCalculoPorcentagem.Size = new System.Drawing.Size(126, 17);
            this.rdbCalculoPorcentagem.TabIndex = 6;
            this.rdbCalculoPorcentagem.Text = "Cálculo Porcentagem";
            this.rdbCalculoPorcentagem.UseVisualStyleBackColor = true;
            this.rdbCalculoPorcentagem.Click += new System.EventHandler(this.rdbCalculoPorcentagem_Click);
            // 
            // rdbCalculoReal
            // 
            this.rdbCalculoReal.AutoSize = true;
            this.rdbCalculoReal.Checked = true;
            this.rdbCalculoReal.ForeColor = System.Drawing.Color.White;
            this.rdbCalculoReal.Location = new System.Drawing.Point(220, 168);
            this.rdbCalculoReal.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCalculoReal.Name = "rdbCalculoReal";
            this.rdbCalculoReal.Size = new System.Drawing.Size(85, 17);
            this.rdbCalculoReal.TabIndex = 5;
            this.rdbCalculoReal.TabStop = true;
            this.rdbCalculoReal.Text = "Cálculo Real";
            this.rdbCalculoReal.UseVisualStyleBackColor = true;
            this.rdbCalculoReal.Click += new System.EventHandler(this.rdbCalculoReal_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(404, 196);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 24);
            this.lblValor.TabIndex = 279;
            this.lblValor.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 280;
            this.label5.Text = "Valor Mínimo: ";
            // 
            // TelaCupomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(732, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.rdbCalculoReal);
            this.Controls.Add(this.rdbCalculoPorcentagem);
            this.Controls.Add(this.txtValorMinimo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblParceiro);
            this.Controls.Add(this.btnSelecionarParceiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCupomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cupom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecionarParceiro;
        private System.Windows.Forms.Label lblParceiro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.RadioButton rdbCalculoPorcentagem;
        private System.Windows.Forms.RadioButton rdbCalculoReal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label5;
    }
}