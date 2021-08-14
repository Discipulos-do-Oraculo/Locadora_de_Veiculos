
namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    partial class TelaCadastroDeVeiculo
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fotoCarro = new System.Windows.Forms.PictureBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.cmbPortaMalas = new System.Windows.Forms.ComboBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.selecionarFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(827, 327);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 108;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(700, 327);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCapacidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidade.Location = new System.Drawing.Point(477, 315);
            this.txtCapacidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(183, 22);
            this.txtCapacidade.TabIndex = 106;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(472, 281);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 29);
            this.label13.TabIndex = 105;
            this.label13.Text = "Capacidade :";
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtLitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLitros.Location = new System.Drawing.Point(56, 315);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(183, 22);
            this.txtLitros.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 281);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 29);
            this.label11.TabIndex = 103;
            this.label11.Text = "Litros Tanque :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Location = new System.Drawing.Point(267, 315);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(183, 22);
            this.txtPlaca.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(261, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 29);
            this.label12.TabIndex = 101;
            this.label12.Text = "Placa :";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Location = new System.Drawing.Point(267, 252);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(183, 22);
            this.txtAno.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(261, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 29);
            this.label8.TabIndex = 99;
            this.label8.Text = "Ano :";
            // 
            // txtChassi
            // 
            this.txtChassi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtChassi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChassi.Location = new System.Drawing.Point(477, 252);
            this.txtChassi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(183, 22);
            this.txtChassi.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(472, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 29);
            this.label9.TabIndex = 97;
            this.label9.Text = "Chassi :";
            // 
            // txtPortas
            // 
            this.txtPortas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPortas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortas.Location = new System.Drawing.Point(57, 252);
            this.txtPortas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(183, 22);
            this.txtPortas.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 29);
            this.label10.TabIndex = 95;
            this.label10.Text = "Portas :";
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(477, 190);
            this.cmbVeiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(183, 24);
            this.cmbVeiculos.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(261, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 92;
            this.label5.Text = "Porta Malas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 91;
            this.label6.Text = "Grupo de Veiculo :";
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKm.Location = new System.Drawing.Point(57, 190);
            this.txtKm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(183, 22);
            this.txtKm.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 89;
            this.label7.Text = "Km Atual :";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(267, 127);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(183, 22);
            this.txtMarca.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(261, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 87;
            this.label4.Text = "Marca :";
            // 
            // txtCor
            // 
            this.txtCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCor.Location = new System.Drawing.Point(477, 127);
            this.txtCor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(183, 22);
            this.txtCor.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "Cor :";
            // 
            // fotoCarro
            // 
            this.fotoCarro.Location = new System.Drawing.Point(700, 92);
            this.fotoCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoCarro.Name = "fotoCarro";
            this.fotoCarro.Size = new System.Drawing.Size(227, 133);
<<<<<<< HEAD:LocadoraVeiculos.WindowsForms/Features/VeiculosModule/CadastroDeVeiculos/TelaCadastroDeVeiculo.Designer.cs
            this.fotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
=======
>>>>>>> NovasTelas:LocadoraVeiculos.WindowsForms/Features/Veiculos/CadastroDeVeiculos/TelaCadastroDeVeiculo.Designer.cs
            this.fotoCarro.TabIndex = 84;
            this.fotoCarro.TabStop = false;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVeiculo.Location = new System.Drawing.Point(57, 127);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(183, 22);
            this.txtVeiculo.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Veiculo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 81;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(57, 52);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(54, 22);
            this.textBoxId.TabIndex = 80;
            // 
            // cmbPortaMalas
            // 
            this.cmbPortaMalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbPortaMalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPortaMalas.FormattingEnabled = true;
            this.cmbPortaMalas.Location = new System.Drawing.Point(267, 188);
            this.cmbPortaMalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPortaMalas.Name = "cmbPortaMalas";
            this.cmbPortaMalas.Size = new System.Drawing.Size(183, 24);
            this.cmbPortaMalas.TabIndex = 109;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(827, 233);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(100, 28);
            this.btnCarregarImagem.TabIndex = 110;
            this.btnCarregarImagem.Text = "Carregar";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
<<<<<<< HEAD:LocadoraVeiculos.WindowsForms/Features/VeiculosModule/CadastroDeVeiculos/TelaCadastroDeVeiculo.Designer.cs
            // 
            // selecionarFoto
            // 
            this.selecionarFoto.FileName = "openFileDialog1";
            this.selecionarFoto.Title = "Selecione a Foto do Veículo";
=======
>>>>>>> NovasTelas:LocadoraVeiculos.WindowsForms/Features/Veiculos/CadastroDeVeiculos/TelaCadastroDeVeiculo.Designer.cs
            // 
            // TelaCadastroDeVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(976, 374);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.cmbPortaMalas);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fotoCarro);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroDeVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox fotoCarro;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox cmbPortaMalas;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.OpenFileDialog selecionarFoto;
    }
}