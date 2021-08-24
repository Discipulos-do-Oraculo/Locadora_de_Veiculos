
namespace LocadoraVeiculos.WindowsForms.Features.DevolucaoModule
{
    partial class TelaDevolucaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDevolucaoForm));
            this.btnBuscarLocacao = new System.Windows.Forms.Button();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblTaxas = new System.Windows.Forms.Label();
            this.btnSelecionarTaxas = new System.Windows.Forms.Button();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerRetorno = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.txtLitrosGastos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarLocacao
            // 
            this.btnBuscarLocacao.Location = new System.Drawing.Point(164, 58);
            this.btnBuscarLocacao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLocacao.Name = "btnBuscarLocacao";
            this.btnBuscarLocacao.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarLocacao.TabIndex = 1;
            this.btnBuscarLocacao.Text = "...";
            this.btnBuscarLocacao.UseVisualStyleBackColor = true;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.ForeColor = System.Drawing.Color.White;
            this.lblPessoa.Location = new System.Drawing.Point(351, 91);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(0, 24);
            this.lblPessoa.TabIndex = 316;
            // 
            // lblTaxas
            // 
            this.lblTaxas.AutoSize = true;
            this.lblTaxas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxas.ForeColor = System.Drawing.Color.White;
            this.lblTaxas.Location = new System.Drawing.Point(112, 96);
            this.lblTaxas.Name = "lblTaxas";
            this.lblTaxas.Size = new System.Drawing.Size(0, 24);
            this.lblTaxas.TabIndex = 313;
            // 
            // btnSelecionarTaxas
            // 
            this.btnSelecionarTaxas.Location = new System.Drawing.Point(300, 147);
            this.btnSelecionarTaxas.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarTaxas.Name = "btnSelecionarTaxas";
            this.btnSelecionarTaxas.Size = new System.Drawing.Size(152, 23);
            this.btnSelecionarTaxas.TabIndex = 4;
            this.btnSelecionarTaxas.Text = "Clique para Selecionar";
            this.btnSelecionarTaxas.UseVisualStyleBackColor = true;
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cmbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.ItemHeight = 13;
            this.cmbCombustivel.Items.AddRange(new object[] {
            "Diário",
            "Km Controlado",
            "Km Livre"});
            this.cmbCombustivel.Location = new System.Drawing.Point(300, 83);
            this.cmbCombustivel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(152, 21);
            this.cmbCombustivel.TabIndex = 2;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(300, 218);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(152, 20);
            this.txtValorTotal.TabIndex = 298;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 311;
            this.label3.Text = "Valor Total  R$:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(67, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 24);
            this.label13.TabIndex = 310;
            this.label13.Text = "Data Retorno:";
            // 
            // dateTimePickerRetorno
            // 
            this.dateTimePickerRetorno.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerRetorno.Enabled = false;
            this.dateTimePickerRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRetorno.Location = new System.Drawing.Point(71, 146);
            this.dateTimePickerRetorno.Name = "dateTimePickerRetorno";
            this.dateTimePickerRetorno.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerRetorno.TabIndex = 296;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.LightGray;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(393, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(287, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtKmFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmFinal.Location = new System.Drawing.Point(526, 83);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(141, 20);
            this.txtKmFinal.TabIndex = 3;
            this.txtKmFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmFinal_KeyPress);
            // 
            // txtLitrosGastos
            // 
            this.txtLitrosGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtLitrosGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLitrosGastos.Location = new System.Drawing.Point(526, 150);
            this.txtLitrosGastos.Name = "txtLitrosGastos";
            this.txtLitrosGastos.Size = new System.Drawing.Size(141, 20);
            this.txtLitrosGastos.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(522, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 308;
            this.label9.Text = "Litros Gastos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 306;
            this.label5.Text = "Combustível :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(522, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 305;
            this.label6.Text = "Km Final :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 304;
            this.label7.Text = "Taxas e Serviços :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 302;
            this.label2.Text = "Locação :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 301;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(71, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(41, 20);
            this.textBoxId.TabIndex = 288;
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocacao.ForeColor = System.Drawing.Color.White;
            this.lblLocacao.Location = new System.Drawing.Point(67, 83);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(30, 24);
            this.lblLocacao.TabIndex = 317;
            this.lblLocacao.Text = "ok";
            // 
            // TelaDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(734, 305);
            this.Controls.Add(this.lblLocacao);
            this.Controls.Add(this.btnBuscarLocacao);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.lblTaxas);
            this.Controls.Add(this.btnSelecionarTaxas);
            this.Controls.Add(this.cmbCombustivel);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerRetorno);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtKmFinal);
            this.Controls.Add(this.txtLitrosGastos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDevolucaoForm";
            this.Text = "Fechar Locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarLocacao;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblTaxas;
        private System.Windows.Forms.Button btnSelecionarTaxas;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetorno;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.TextBox txtLitrosGastos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblLocacao;
    }
}