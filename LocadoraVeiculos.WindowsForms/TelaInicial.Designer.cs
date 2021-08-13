
namespace LocadoraVeiculos.WindowsForms
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuOpcoes = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutomoveis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrupoVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefas = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOpcao = new System.Windows.Forms.ToolStripLabel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewStatus = new System.Windows.Forms.StatusStrip();
            this.statusAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuOpcoes.SuspendLayout();
            this.barraTarefas.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.viewStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuAutomoveis,
            this.menuLocacoes,
            this.menuFinanceiro,
            this.menuExtras});
            this.menuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuOpcoes.Size = new System.Drawing.Size(800, 24);
            this.menuOpcoes.TabIndex = 0;
            this.menuOpcoes.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPessoaFisica,
            this.menuPessoaJuridica,
            this.menuColaborador});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuPessoaFisica
            // 
            this.menuPessoaFisica.Name = "menuPessoaFisica";
            this.menuPessoaFisica.Size = new System.Drawing.Size(180, 22);
            this.menuPessoaFisica.Text = "Pessoa Fisica";
            this.menuPessoaFisica.Click += new System.EventHandler(this.menuPessoaFisica_Click);
            // 
            // menuPessoaJuridica
            // 
            this.menuPessoaJuridica.Name = "menuPessoaJuridica";
            this.menuPessoaJuridica.Size = new System.Drawing.Size(180, 22);
            this.menuPessoaJuridica.Text = "Pessoa Juridica";
            this.menuPessoaJuridica.Click += new System.EventHandler(this.menuPessoaJuridica_Click);
            // 
            // menuColaborador
            // 
            this.menuColaborador.Name = "menuColaborador";
            this.menuColaborador.Size = new System.Drawing.Size(180, 22);
            this.menuColaborador.Text = "Colaborador";
            // 
            // menuAutomoveis
            // 
            this.menuAutomoveis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGrupoVeiculos,
            this.menuVeiculos});
            this.menuAutomoveis.Name = "menuAutomoveis";
            this.menuAutomoveis.Size = new System.Drawing.Size(83, 20);
            this.menuAutomoveis.Text = "Automoveis";
            // 
            // menuGrupoVeiculos
            // 
            this.menuGrupoVeiculos.Name = "menuGrupoVeiculos";
            this.menuGrupoVeiculos.Size = new System.Drawing.Size(169, 22);
            this.menuGrupoVeiculos.Text = "Grupo de Veículos";
            this.menuGrupoVeiculos.Click += new System.EventHandler(this.menuGrupoVeiculos_Click);
            // 
            // menuVeiculos
            // 
            this.menuVeiculos.Name = "menuVeiculos";
            this.menuVeiculos.Size = new System.Drawing.Size(169, 22);
            this.menuVeiculos.Text = "Veículos";
            this.menuVeiculos.Click += new System.EventHandler(this.menuVeiculos_Click);
            // 
            // menuLocacoes
            // 
            this.menuLocacoes.Name = "menuLocacoes";
            this.menuLocacoes.Size = new System.Drawing.Size(68, 20);
            this.menuLocacoes.Text = "Locações";
            // 
            // menuFinanceiro
            // 
            this.menuFinanceiro.Name = "menuFinanceiro";
            this.menuFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.menuFinanceiro.Text = "Financeiro";
            // 
            // menuExtras
            // 
            this.menuExtras.Name = "menuExtras";
            this.menuExtras.Size = new System.Drawing.Size(50, 20);
            this.menuExtras.Text = "Extras";
            // 
            // barraTarefas
            // 
            this.barraTarefas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnExcluir,
            this.btnFiltrar,
            this.toolStripSeparator1,
            this.menuOpcao});
            this.barraTarefas.Location = new System.Drawing.Point(0, 24);
            this.barraTarefas.Name = "barraTarefas";
            this.barraTarefas.Size = new System.Drawing.Size(800, 31);
            this.barraTarefas.TabIndex = 1;
            this.barraTarefas.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::LocadoraVeiculos.WindowsForms.Properties.Resources.round_add_black_24dp;
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(28, 28);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::LocadoraVeiculos.WindowsForms.Properties.Resources.round_edit_black_24dp;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::LocadoraVeiculos.WindowsForms.Properties.Resources.round_cancel_black_24dp;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::LocadoraVeiculos.WindowsForms.Properties.Resources.round_filter_alt_black_24dp;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(28, 28);
            this.btnFiltrar.Text = "Filtrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // menuOpcao
            // 
            this.menuOpcao.Name = "menuOpcao";
            this.menuOpcao.Size = new System.Drawing.Size(170, 28);
            this.menuOpcao.Text = "Opção Selecionada : Nenhuma";
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.pictureBox1);
            this.panelCentral.Location = new System.Drawing.Point(27, 75);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(748, 343);
            this.panelCentral.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluga Rech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraVeiculos.WindowsForms.Properties.Resources.icons8_car_rental_100;
            this.pictureBox1.Location = new System.Drawing.Point(133, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewStatus
            // 
            this.viewStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAtual});
            this.viewStatus.Location = new System.Drawing.Point(0, 428);
            this.viewStatus.Name = "viewStatus";
            this.viewStatus.Size = new System.Drawing.Size(800, 22);
            this.viewStatus.TabIndex = 3;
            this.viewStatus.Text = "statusStrip1";
            // 
            // statusAtual
            // 
            this.statusAtual.BackColor = System.Drawing.Color.White;
            this.statusAtual.Name = "statusAtual";
            this.statusAtual.Size = new System.Drawing.Size(53, 17);
            this.statusAtual.Text = "Tudo OK";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewStatus);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.barraTarefas);
            this.Controls.Add(this.menuOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpcoes;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.menuOpcoes.ResumeLayout(false);
            this.menuOpcoes.PerformLayout();
            this.barraTarefas.ResumeLayout(false);
            this.barraTarefas.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.viewStatus.ResumeLayout(false);
            this.viewStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuAutomoveis;
        private System.Windows.Forms.ToolStripMenuItem menuLocacoes;
        private System.Windows.Forms.ToolStripMenuItem menuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem menuExtras;
        private System.Windows.Forms.ToolStrip barraTarefas;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaFisica;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaJuridica;
        private System.Windows.Forms.ToolStripMenuItem menuColaborador;
        private System.Windows.Forms.ToolStripMenuItem menuGrupoVeiculos;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.StatusStrip viewStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusAtual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel menuOpcao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuVeiculos;
    }
}