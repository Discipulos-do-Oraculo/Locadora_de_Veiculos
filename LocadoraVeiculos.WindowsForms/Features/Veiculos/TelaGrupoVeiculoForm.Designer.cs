
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(378, 266);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(237, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValor.Location = new System.Drawing.Point(237, 187);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(216, 20);
            this.textBoxValor.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome :";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(237, 107);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(216, 20);
            this.textBoxNome.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(237, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(41, 20);
            this.textBoxId.TabIndex = 17;
            // 
            // TelaGrupoVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(734, 305);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGrupoVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupo de Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
    }
}