
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroDeVeiculo));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.labelCapacidade = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.labelLitrosTanque = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.labelChassi = new System.Windows.Forms.Label();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.labelPortas = new System.Windows.Forms.Label();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.labelPortaMalas = new System.Windows.Forms.Label();
            this.labelGrupoVeiculo = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.labelKmAtual = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.labelCor = new System.Windows.Forms.Label();
            this.fotoCarro = new System.Windows.Forms.PictureBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbPortaMalas = new System.Windows.Forms.ComboBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.selecionarFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(846, 327);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(722, 327);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCapacidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidade.Location = new System.Drawing.Point(477, 315);
            this.txtCapacidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidade.MaxLength = 2;
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(183, 22);
            this.txtCapacidade.TabIndex = 13;
            this.txtCapacidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacidade_KeyPress);
            // 
            // labelCapacidade
            // 
            this.labelCapacidade.AutoSize = true;
            this.labelCapacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidade.ForeColor = System.Drawing.Color.White;
            this.labelCapacidade.Location = new System.Drawing.Point(472, 281);
            this.labelCapacidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCapacidade.Name = "labelCapacidade";
            this.labelCapacidade.Size = new System.Drawing.Size(155, 29);
            this.labelCapacidade.TabIndex = 105;
            this.labelCapacidade.Text = "Capacidade :";
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtLitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLitros.Location = new System.Drawing.Point(56, 315);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(4);
            this.txtLitros.MaxLength = 3;
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(183, 22);
            this.txtLitros.TabIndex = 11;
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitros_KeyPress);
            // 
            // labelLitrosTanque
            // 
            this.labelLitrosTanque.AutoSize = true;
            this.labelLitrosTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitrosTanque.ForeColor = System.Drawing.Color.White;
            this.labelLitrosTanque.Location = new System.Drawing.Point(51, 281);
            this.labelLitrosTanque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLitrosTanque.Name = "labelLitrosTanque";
            this.labelLitrosTanque.Size = new System.Drawing.Size(173, 29);
            this.labelLitrosTanque.TabIndex = 103;
            this.labelLitrosTanque.Text = "Litros Tanque :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(267, 315);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(183, 22);
            this.txtPlaca.TabIndex = 12;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.ForeColor = System.Drawing.Color.White;
            this.labelPlaca.Location = new System.Drawing.Point(261, 281);
            this.labelPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(85, 29);
            this.labelPlaca.TabIndex = 101;
            this.labelPlaca.Text = "Placa :";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Location = new System.Drawing.Point(267, 252);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(183, 22);
            this.txtAno.TabIndex = 9;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.ForeColor = System.Drawing.Color.White;
            this.labelAno.Location = new System.Drawing.Point(261, 218);
            this.labelAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(67, 29);
            this.labelAno.TabIndex = 99;
            this.labelAno.Text = "Ano :";
            // 
            // txtChassi
            // 
            this.txtChassi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtChassi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Location = new System.Drawing.Point(477, 252);
            this.txtChassi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(183, 22);
            this.txtChassi.TabIndex = 10;
            // 
            // labelChassi
            // 
            this.labelChassi.AutoSize = true;
            this.labelChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChassi.ForeColor = System.Drawing.Color.White;
            this.labelChassi.Location = new System.Drawing.Point(472, 218);
            this.labelChassi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChassi.Name = "labelChassi";
            this.labelChassi.Size = new System.Drawing.Size(98, 29);
            this.labelChassi.TabIndex = 97;
            this.labelChassi.Text = "Chassi :";
            // 
            // txtPortas
            // 
            this.txtPortas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPortas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortas.Location = new System.Drawing.Point(57, 252);
            this.txtPortas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortas.MaxLength = 2;
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(183, 22);
            this.txtPortas.TabIndex = 8;
            this.txtPortas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortas_KeyPress);
            // 
            // labelPortas
            // 
            this.labelPortas.AutoSize = true;
            this.labelPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortas.ForeColor = System.Drawing.Color.White;
            this.labelPortas.Location = new System.Drawing.Point(52, 218);
            this.labelPortas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortas.Name = "labelPortas";
            this.labelPortas.Size = new System.Drawing.Size(94, 29);
            this.labelPortas.TabIndex = 95;
            this.labelPortas.Text = "Portas :";
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(477, 190);
            this.cmbVeiculos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeiculos.MaxDropDownItems = 50;
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(183, 24);
            this.cmbVeiculos.TabIndex = 7;
            // 
            // labelPortaMalas
            // 
            this.labelPortaMalas.AutoSize = true;
            this.labelPortaMalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortaMalas.ForeColor = System.Drawing.Color.White;
            this.labelPortaMalas.Location = new System.Drawing.Point(261, 155);
            this.labelPortaMalas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortaMalas.Name = "labelPortaMalas";
            this.labelPortaMalas.Size = new System.Drawing.Size(152, 29);
            this.labelPortaMalas.TabIndex = 92;
            this.labelPortaMalas.Text = "Porta Malas :";
            // 
            // labelGrupoVeiculo
            // 
            this.labelGrupoVeiculo.AutoSize = true;
            this.labelGrupoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupoVeiculo.ForeColor = System.Drawing.Color.White;
            this.labelGrupoVeiculo.Location = new System.Drawing.Point(472, 155);
            this.labelGrupoVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrupoVeiculo.Name = "labelGrupoVeiculo";
            this.labelGrupoVeiculo.Size = new System.Drawing.Size(212, 29);
            this.labelGrupoVeiculo.TabIndex = 91;
            this.labelGrupoVeiculo.Text = "Grupo de Veiculo :";
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKm.Location = new System.Drawing.Point(57, 190);
            this.txtKm.Margin = new System.Windows.Forms.Padding(4);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(183, 22);
            this.txtKm.TabIndex = 5;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // labelKmAtual
            // 
            this.labelKmAtual.AutoSize = true;
            this.labelKmAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmAtual.ForeColor = System.Drawing.Color.White;
            this.labelKmAtual.Location = new System.Drawing.Point(52, 155);
            this.labelKmAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKmAtual.Name = "labelKmAtual";
            this.labelKmAtual.Size = new System.Drawing.Size(120, 29);
            this.labelKmAtual.TabIndex = 89;
            this.labelKmAtual.Text = "Km Atual :";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(267, 127);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(183, 22);
            this.txtMarca.TabIndex = 3;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(261, 92);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(91, 29);
            this.labelMarca.TabIndex = 87;
            this.labelMarca.Text = "Marca :";
            // 
            // txtCor
            // 
            this.txtCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCor.Location = new System.Drawing.Point(477, 127);
            this.txtCor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(183, 22);
            this.txtCor.TabIndex = 4;
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCor.ForeColor = System.Drawing.Color.White;
            this.labelCor.Location = new System.Drawing.Point(472, 92);
            this.labelCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(64, 29);
            this.labelCor.TabIndex = 85;
            this.labelCor.Text = "Cor :";
            // 
            // fotoCarro
            // 
            this.fotoCarro.Location = new System.Drawing.Point(692, 127);
            this.fotoCarro.Margin = new System.Windows.Forms.Padding(4);
            this.fotoCarro.Name = "fotoCarro";
            this.fotoCarro.Size = new System.Drawing.Size(254, 113);
            this.fotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCarro.TabIndex = 84;
            this.fotoCarro.TabStop = false;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVeiculo.Location = new System.Drawing.Point(57, 127);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(183, 22);
            this.txtVeiculo.TabIndex = 2;
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeiculo.ForeColor = System.Drawing.Color.White;
            this.labelVeiculo.Location = new System.Drawing.Point(52, 92);
            this.labelVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(105, 29);
            this.labelVeiculo.TabIndex = 82;
            this.labelVeiculo.Text = "Veiculo :";
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
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(57, 52);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 22);
            this.txtId.TabIndex = 1;
            // 
            // cmbPortaMalas
            // 
            this.cmbPortaMalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbPortaMalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortaMalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPortaMalas.FormattingEnabled = true;
            this.cmbPortaMalas.Location = new System.Drawing.Point(267, 188);
            this.cmbPortaMalas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPortaMalas.Name = "cmbPortaMalas";
            this.cmbPortaMalas.Size = new System.Drawing.Size(183, 24);
            this.cmbPortaMalas.TabIndex = 6;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(846, 252);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(100, 28);
            this.btnCarregarImagem.TabIndex = 14;
            this.btnCarregarImagem.Text = "Carregar";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // selecionarFoto
            // 
            this.selecionarFoto.FileName = "openFileDialog1";
            this.selecionarFoto.Title = "Selecione a Foto do Veículo";
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
            this.Controls.Add(this.labelCapacidade);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.labelLitrosTanque);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.labelChassi);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.labelPortas);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.labelPortaMalas);
            this.Controls.Add(this.labelGrupoVeiculo);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.labelKmAtual);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.labelCor);
            this.Controls.Add(this.fotoCarro);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.labelVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroDeVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar  Veículo";
            this.Load += new System.EventHandler(this.TelaCadastroDeVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label labelCapacidade;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label labelLitrosTanque;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label labelChassi;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.Label labelPortas;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label labelPortaMalas;
        private System.Windows.Forms.Label labelGrupoVeiculo;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label labelKmAtual;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.PictureBox fotoCarro;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbPortaMalas;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.OpenFileDialog selecionarFoto;
    }
}