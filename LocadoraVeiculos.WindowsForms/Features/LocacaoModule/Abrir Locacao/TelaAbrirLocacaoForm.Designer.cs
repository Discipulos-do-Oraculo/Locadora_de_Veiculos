
namespace LocadoraVeiculos.WindowsForms.Features.LocacaoModule.Abrir_Locacao
{
    partial class TelaAbrirLocacaoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAbrirLocacaoForm));
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerRetorno = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.txtCaucao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.cmbPlanos = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.btnSelecionarTaxas = new System.Windows.Forms.Button();
            this.btnSelecionarVeiculo = new System.Windows.Forms.Button();
            this.lblTaxas = new System.Windows.Forms.Label();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.btnSelecionarCondutor = new System.Windows.Forms.Button();
            this.btnSelecionarPessoa = new System.Windows.Forms.Button();
            this.locadoraDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelecionarCupom = new System.Windows.Forms.Button();
            this.lblCupom = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(408, 294);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(191, 22);
            this.txtValorTotal.TabIndex = 11;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 271;
            this.label3.Text = "Valor Total  R$:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(403, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 29);
            this.label13.TabIndex = 270;
            this.label13.Text = "Data Retorno:";
            // 
            // dateTimePickerRetorno
            // 
            this.dateTimePickerRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRetorno.Location = new System.Drawing.Point(408, 231);
            this.dateTimePickerRetorno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRetorno.Name = "dateTimePickerRetorno";
            this.dateTimePickerRetorno.Size = new System.Drawing.Size(191, 22);
            this.dateTimePickerRetorno.TabIndex = 9;
            this.dateTimePickerRetorno.ValueChanged += new System.EventHandler(this.dateTimePickerRetorno_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(405, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 29);
            this.label11.TabIndex = 268;
            this.label11.Text = "Condutor :";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.LightGray;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(524, 338);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 28);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(383, 338);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.txtKmInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmInicial.Enabled = false;
            this.txtKmInicial.Location = new System.Drawing.Point(699, 170);
            this.txtKmInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(187, 22);
            this.txtKmInicial.TabIndex = 7;
            // 
            // txtCaucao
            // 
            this.txtCaucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCaucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaucao.Location = new System.Drawing.Point(699, 231);
            this.txtCaucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCaucao.Name = "txtCaucao";
            this.txtCaucao.Size = new System.Drawing.Size(187, 22);
            this.txtCaucao.TabIndex = 10;
            this.txtCaucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaucao_KeyPress);
            this.txtCaucao.Leave += new System.EventHandler(this.txtCaucao_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(693, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 29);
            this.label9.TabIndex = 264;
            this.label9.Text = "Valor Garantia :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(87, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 263;
            this.label10.Text = "Data Saída :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(403, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 262;
            this.label5.Text = "Planos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(693, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 261;
            this.label6.Text = "Km Inicial :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(84, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 29);
            this.label7.TabIndex = 260;
            this.label7.Text = "Taxas e Serviços :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(694, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 259;
            this.label4.Text = "Veículo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 258;
            this.label2.Text = "Pessoa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 257;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(92, 42);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(54, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // cmbPlanos
            // 
            this.cmbPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbPlanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanos.FormattingEnabled = true;
            this.cmbPlanos.ItemHeight = 16;
            this.cmbPlanos.Items.AddRange(new object[] {
            "Diário",
            "Km Controlado",
            "Km Livre"});
            this.cmbPlanos.Location = new System.Drawing.Point(408, 166);
            this.cmbPlanos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPlanos.Name = "cmbPlanos";
            this.cmbPlanos.Size = new System.Drawing.Size(191, 24);
            this.cmbPlanos.TabIndex = 6;
            this.cmbPlanos.SelectedIndexChanged += new System.EventHandler(this.cmbPlanos_SelectedIndexChanged);
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Enabled = false;
            this.dateTimePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaida.Location = new System.Drawing.Point(92, 231);
            this.dateTimePickerSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(204, 22);
            this.dateTimePickerSaida.TabIndex = 8;
            // 
            // btnSelecionarTaxas
            // 
            this.btnSelecionarTaxas.Location = new System.Drawing.Point(91, 164);
            this.btnSelecionarTaxas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarTaxas.Name = "btnSelecionarTaxas";
            this.btnSelecionarTaxas.Size = new System.Drawing.Size(203, 28);
            this.btnSelecionarTaxas.TabIndex = 5;
            this.btnSelecionarTaxas.Text = "Clique para Selecionar";
            this.btnSelecionarTaxas.UseVisualStyleBackColor = true;
            this.btnSelecionarTaxas.Click += new System.EventHandler(this.btnSelecionarTaxas_Click);
            // 
            // btnSelecionarVeiculo
            // 
            this.btnSelecionarVeiculo.Location = new System.Drawing.Point(805, 70);
            this.btnSelecionarVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarVeiculo.Name = "btnSelecionarVeiculo";
            this.btnSelecionarVeiculo.Size = new System.Drawing.Size(80, 28);
            this.btnSelecionarVeiculo.TabIndex = 4;
            this.btnSelecionarVeiculo.Text = "...";
            this.btnSelecionarVeiculo.UseVisualStyleBackColor = true;
            this.btnSelecionarVeiculo.Click += new System.EventHandler(this.btnSelecionarVeiculo_Click);
            // 
            // lblTaxas
            // 
            this.lblTaxas.AutoSize = true;
            this.lblTaxas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxas.ForeColor = System.Drawing.Color.White;
            this.lblTaxas.Location = new System.Drawing.Point(87, 167);
            this.lblTaxas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxas.Name = "lblTaxas";
            this.lblTaxas.Size = new System.Drawing.Size(0, 29);
            this.lblTaxas.TabIndex = 284;
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeiculo.ForeColor = System.Drawing.Color.White;
            this.labelVeiculo.Location = new System.Drawing.Point(694, 96);
            this.labelVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(0, 29);
            this.labelVeiculo.TabIndex = 285;
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondutor.ForeColor = System.Drawing.Color.White;
            this.lblCondutor.Location = new System.Drawing.Point(411, 96);
            this.lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(0, 29);
            this.lblCondutor.TabIndex = 286;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.ForeColor = System.Drawing.Color.White;
            this.lblPessoa.Location = new System.Drawing.Point(84, 100);
            this.lblPessoa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(0, 29);
            this.lblPessoa.TabIndex = 287;
            // 
            // btnSelecionarCondutor
            // 
            this.btnSelecionarCondutor.Enabled = false;
            this.btnSelecionarCondutor.Location = new System.Drawing.Point(524, 70);
            this.btnSelecionarCondutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarCondutor.Name = "btnSelecionarCondutor";
            this.btnSelecionarCondutor.Size = new System.Drawing.Size(75, 28);
            this.btnSelecionarCondutor.TabIndex = 3;
            this.btnSelecionarCondutor.Text = "...";
            this.btnSelecionarCondutor.UseVisualStyleBackColor = true;
            this.btnSelecionarCondutor.Click += new System.EventHandler(this.btnCondutor_Click);
            // 
            // btnSelecionarPessoa
            // 
            this.btnSelecionarPessoa.Location = new System.Drawing.Point(213, 71);
            this.btnSelecionarPessoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarPessoa.Name = "btnSelecionarPessoa";
            this.btnSelecionarPessoa.Size = new System.Drawing.Size(80, 28);
            this.btnSelecionarPessoa.TabIndex = 2;
            this.btnSelecionarPessoa.Text = "...";
            this.btnSelecionarPessoa.UseVisualStyleBackColor = true;
            this.btnSelecionarPessoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelecionarCupom
            // 
            this.btnSelecionarCupom.Location = new System.Drawing.Point(216, 288);
            this.btnSelecionarCupom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarCupom.Name = "btnSelecionarCupom";
            this.btnSelecionarCupom.Size = new System.Drawing.Size(80, 28);
            this.btnSelecionarCupom.TabIndex = 288;
            this.btnSelecionarCupom.Text = "...";
            this.btnSelecionarCupom.UseVisualStyleBackColor = true;
            this.btnSelecionarCupom.Click += new System.EventHandler(this.btnSelecionarCupom_Click);
            // 
            // lblCupom
            // 
            this.lblCupom.AutoSize = true;
            this.lblCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupom.ForeColor = System.Drawing.Color.White;
            this.lblCupom.Location = new System.Drawing.Point(87, 316);
            this.lblCupom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCupom.Name = "lblCupom";
            this.lblCupom.Size = new System.Drawing.Size(0, 29);
            this.lblCupom.TabIndex = 290;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(87, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 29);
            this.label12.TabIndex = 289;
            this.label12.Text = "Cupom :";
            // 
            // TelaAbrirLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(979, 375);
            this.Controls.Add(this.btnSelecionarCupom);
            this.Controls.Add(this.lblCupom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSelecionarPessoa);
            this.Controls.Add(this.btnSelecionarCondutor);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.lblCondutor);
            this.Controls.Add(this.labelVeiculo);
            this.Controls.Add(this.lblTaxas);
            this.Controls.Add(this.btnSelecionarVeiculo);
            this.Controls.Add(this.btnSelecionarTaxas);
            this.Controls.Add(this.dateTimePickerSaida);
            this.Controls.Add(this.cmbPlanos);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerRetorno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtKmInicial);
            this.Controls.Add(this.txtCaucao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAbrirLocacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Locação";
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.TextBox txtCaucao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox cmbPlanos;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.BindingSource locadoraDBDataSetBindingSource;
        private System.Windows.Forms.Button btnSelecionarTaxas;
        private System.Windows.Forms.Button btnSelecionarVeiculo;
        private System.Windows.Forms.Label lblTaxas;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Button btnSelecionarCondutor;
        private System.Windows.Forms.Button btnSelecionarPessoa;
        private System.Windows.Forms.Button btnSelecionarCupom;
        private System.Windows.Forms.Label lblCupom;
        private System.Windows.Forms.Label label12;
    }
}