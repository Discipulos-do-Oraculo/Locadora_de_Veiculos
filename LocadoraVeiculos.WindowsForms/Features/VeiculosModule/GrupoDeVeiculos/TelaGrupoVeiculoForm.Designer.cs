
namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    partial class TelaGrupoVeiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGrupoVeiculoForm));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePlanoDiario = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxValorKmDiario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValorDiaria = new System.Windows.Forms.TextBox();
            this.tabPageKmControlado = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxValorKmControlado = new System.Windows.Forms.TextBox();
            this.textBoxValorDiariaKmControlado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLimiteKmControlado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageKmLivre = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValorKmLivre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxValorDiariaLivre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePlanoDiario.SuspendLayout();
            this.tabPageKmControlado.SuspendLayout();
            this.tabPageKmLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(394, 271);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(289, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(272, 98);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(217, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(272, 42);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(41, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePlanoDiario);
            this.tabControl1.Controls.Add(this.tabPageKmControlado);
            this.tabControl1.Controls.Add(this.tabPageKmLivre);
            this.tabControl1.Location = new System.Drawing.Point(272, 147);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(217, 105);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPagePlanoDiario
            // 
            this.tabPagePlanoDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tabPagePlanoDiario.Controls.Add(this.textBox1);
            this.tabPagePlanoDiario.Controls.Add(this.label9);
            this.tabPagePlanoDiario.Controls.Add(this.textBoxValorKmDiario);
            this.tabPagePlanoDiario.Controls.Add(this.label4);
            this.tabPagePlanoDiario.Controls.Add(this.label3);
            this.tabPagePlanoDiario.Controls.Add(this.textBoxValorDiaria);
            this.tabPagePlanoDiario.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanoDiario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePlanoDiario.Name = "tabPagePlanoDiario";
            this.tabPagePlanoDiario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePlanoDiario.Size = new System.Drawing.Size(209, 79);
            this.tabPagePlanoDiario.TabIndex = 0;
            this.tabPagePlanoDiario.Text = "Plano Diário";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(78, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Limite Km";
            // 
            // textBoxValorKmDiario
            // 
            this.textBoxValorKmDiario.Location = new System.Drawing.Point(78, 58);
            this.textBoxValorKmDiario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorKmDiario.Name = "textBoxValorKmDiario";
            this.textBoxValorKmDiario.Size = new System.Drawing.Size(117, 20);
            this.textBoxValorKmDiario.TabIndex = 6;
            this.textBoxValorKmDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorKmDiario_KeyPress);
            this.textBoxValorKmDiario.Leave += new System.EventHandler(this.textBoxValorKmDiario_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor Diária";
            // 
            // textBoxValorDiaria
            // 
            this.textBoxValorDiaria.Location = new System.Drawing.Point(78, 5);
            this.textBoxValorDiaria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorDiaria.Name = "textBoxValorDiaria";
            this.textBoxValorDiaria.Size = new System.Drawing.Size(117, 20);
            this.textBoxValorDiaria.TabIndex = 4;
            this.textBoxValorDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorDiaria_KeyPress);
            this.textBoxValorDiaria.Leave += new System.EventHandler(this.textBoxValorDiaria_Leave);
            // 
            // tabPageKmControlado
            // 
            this.tabPageKmControlado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tabPageKmControlado.Controls.Add(this.label8);
            this.tabPageKmControlado.Controls.Add(this.textBoxValorKmControlado);
            this.tabPageKmControlado.Controls.Add(this.textBoxValorDiariaKmControlado);
            this.tabPageKmControlado.Controls.Add(this.label7);
            this.tabPageKmControlado.Controls.Add(this.textBoxLimiteKmControlado);
            this.tabPageKmControlado.Controls.Add(this.label5);
            this.tabPageKmControlado.Location = new System.Drawing.Point(4, 22);
            this.tabPageKmControlado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKmControlado.Name = "tabPageKmControlado";
            this.tabPageKmControlado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKmControlado.Size = new System.Drawing.Size(209, 79);
            this.tabPageKmControlado.TabIndex = 1;
            this.tabPageKmControlado.Text = "Km Controlado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Valor Km";
            // 
            // textBoxValorKmControlado
            // 
            this.textBoxValorKmControlado.Location = new System.Drawing.Point(76, 58);
            this.textBoxValorKmControlado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorKmControlado.Name = "textBoxValorKmControlado";
            this.textBoxValorKmControlado.Size = new System.Drawing.Size(119, 20);
            this.textBoxValorKmControlado.TabIndex = 10;
            this.textBoxValorKmControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorKmControlado_KeyPress);
            this.textBoxValorKmControlado.Leave += new System.EventHandler(this.textBoxValorKmControlado_Leave);
            // 
            // textBoxValorDiariaKmControlado
            // 
            this.textBoxValorDiariaKmControlado.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxValorDiariaKmControlado.Location = new System.Drawing.Point(76, 6);
            this.textBoxValorDiariaKmControlado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorDiariaKmControlado.Name = "textBoxValorDiariaKmControlado";
            this.textBoxValorDiariaKmControlado.Size = new System.Drawing.Size(119, 20);
            this.textBoxValorDiariaKmControlado.TabIndex = 8;
            this.textBoxValorDiariaKmControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorDiariaKmControlado_KeyPress);
            this.textBoxValorDiariaKmControlado.Leave += new System.EventHandler(this.textBoxValorDiariaKmControlado_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor Diária";
            // 
            // textBoxLimiteKmControlado
            // 
            this.textBoxLimiteKmControlado.Location = new System.Drawing.Point(76, 32);
            this.textBoxLimiteKmControlado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLimiteKmControlado.Name = "textBoxLimiteKmControlado";
            this.textBoxLimiteKmControlado.Size = new System.Drawing.Size(119, 20);
            this.textBoxLimiteKmControlado.TabIndex = 9;
            this.textBoxLimiteKmControlado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLimiteKmControlado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Limite Km";
            // 
            // tabPageKmLivre
            // 
            this.tabPageKmLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tabPageKmLivre.Controls.Add(this.textBox2);
            this.tabPageKmLivre.Controls.Add(this.label6);
            this.tabPageKmLivre.Controls.Add(this.textBoxValorKmLivre);
            this.tabPageKmLivre.Controls.Add(this.label10);
            this.tabPageKmLivre.Controls.Add(this.label11);
            this.tabPageKmLivre.Controls.Add(this.textBoxValorDiariaLivre);
            this.tabPageKmLivre.Location = new System.Drawing.Point(4, 22);
            this.tabPageKmLivre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKmLivre.Name = "tabPageKmLivre";
            this.tabPageKmLivre.Size = new System.Drawing.Size(209, 79);
            this.tabPageKmLivre.TabIndex = 2;
            this.tabPageKmLivre.Text = "Km Livre";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(78, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Limite Km";
            // 
            // textBoxValorKmLivre
            // 
            this.textBoxValorKmLivre.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxValorKmLivre.Enabled = false;
            this.textBoxValorKmLivre.Location = new System.Drawing.Point(78, 58);
            this.textBoxValorKmLivre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorKmLivre.Name = "textBoxValorKmLivre";
            this.textBoxValorKmLivre.Size = new System.Drawing.Size(117, 20);
            this.textBoxValorKmLivre.TabIndex = 14;
            this.textBoxValorKmLivre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorKmLivre_KeyPress);
            this.textBoxValorKmLivre.Leave += new System.EventHandler(this.textBoxValorKmLivre_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor Km";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Valor Diária";
            // 
            // textBoxValorDiariaLivre
            // 
            this.textBoxValorDiariaLivre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxValorDiariaLivre.Location = new System.Drawing.Point(78, 6);
            this.textBoxValorDiariaLivre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValorDiariaLivre.Name = "textBoxValorDiariaLivre";
            this.textBoxValorDiariaLivre.Size = new System.Drawing.Size(117, 20);
            this.textBoxValorDiariaLivre.TabIndex = 12;
            this.textBoxValorDiariaLivre.Leave += new System.EventHandler(this.textBoxValorDiariaLivre_Leave);
            // 
            // TelaGrupoVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(734, 305);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGrupoVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Grupo de Veículos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaGrupoVeiculoForm_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePlanoDiario.ResumeLayout(false);
            this.tabPagePlanoDiario.PerformLayout();
            this.tabPageKmControlado.ResumeLayout(false);
            this.tabPageKmControlado.PerformLayout();
            this.tabPageKmLivre.ResumeLayout(false);
            this.tabPageKmLivre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePlanoDiario;
        private System.Windows.Forms.TextBox textBoxValorKmDiario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValorDiaria;
        private System.Windows.Forms.TabPage tabPageKmControlado;
        private System.Windows.Forms.TabPage tabPageKmLivre;
        private System.Windows.Forms.TextBox textBoxLimiteKmControlado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxValorKmControlado;
        private System.Windows.Forms.TextBox textBoxValorDiariaKmControlado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxValorKmLivre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxValorDiariaLivre;
    }
}