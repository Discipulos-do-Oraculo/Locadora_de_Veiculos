
namespace LocadoraVeiculos.WindowsForms.Features.CondutorForm
{
    partial class TelaCondutorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCondutorForm));
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(142, 142);
            this.maskedTextBoxTelefone.Mask = "(000) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBoxTelefone.TabIndex = 6;
            this.maskedTextBoxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxTelefone_KeyPress);
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(300, 141);
            this.maskedTextBoxCelular.Mask = "(000) 0000-00000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBoxCelular.TabIndex = 7;
            this.maskedTextBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCelular_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(296, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 24);
            this.label13.TabIndex = 237;
            this.label13.Text = "Data de Vencimento :";
            // 
            // dateDataVencimento
            // 
            this.dateDataVencimento.Location = new System.Drawing.Point(300, 240);
            this.dateDataVencimento.Name = "dateDataVencimento";
            this.dateDataVencimento.Size = new System.Drawing.Size(296, 20);
            this.dateDataVencimento.TabIndex = 13;
            // 
            // txtCnh
            // 
            this.txtCnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnh.Location = new System.Drawing.Point(142, 240);
            this.txtCnh.MaxLength = 20;
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(138, 20);
            this.txtCnh.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(138, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 234;
            this.label12.Text = "CNH :";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Location = new System.Drawing.Point(300, 89);
            this.txtRg.MaxLength = 14;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(138, 20);
            this.txtRg.TabIndex = 4;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(296, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 24);
            this.label11.TabIndex = 232;
            this.label11.Text = "RG :";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.LightGray;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(374, 271);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(265, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(458, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(300, 191);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(138, 20);
            this.txtCidade.TabIndex = 10;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(296, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 227;
            this.label8.Text = "Cidade:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Location = new System.Drawing.Point(458, 191);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(138, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(454, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 225;
            this.label9.Text = "Endereço :";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(142, 191);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(138, 20);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(138, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 223;
            this.label10.Text = "Estado :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 222;
            this.label5.Text = "Celular :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(454, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 221;
            this.label6.Text = "E-mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(138, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 220;
            this.label7.Text = "Telefone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(454, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 218;
            this.label4.Text = "CPF :";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(142, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(138, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 216;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 215;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(142, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(41, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 240;
            this.label3.Text = "Empresa :";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(300, 36);
            this.comboBoxEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(138, 21);
            this.comboBoxEmpresa.TabIndex = 2;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.maskedTextBoxCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(458, 89);
            this.maskedTextBoxCpf.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxCpf.Mask = "###.###.###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBoxCpf.TabIndex = 5;
            this.maskedTextBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpf_KeyPress);
            // 
            // TelaCondutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(734, 305);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCelular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateDataVencimento);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCondutorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Condutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDataVencimento;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
    }
}