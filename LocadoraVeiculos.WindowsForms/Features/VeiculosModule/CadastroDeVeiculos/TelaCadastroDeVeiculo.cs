using LocadoraVeiculo.Dominio.GrupoDeVeiculosModule;
using LocadoraVeiculo.Dominio.VeiculoModule;
using LocadoraVeiculos.Controlador.GrupoDeVeiculosModule;
using LocadoraVeiculos.Controlador.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsForms.Features.Veiculos
{
    public partial class TelaCadastroDeVeiculo : Form
    {
        private Veiculo veiculo;
        private ControladorVeiculo controlador;
        private ControladorGrupoDeVeiculos controladorGrupoDeVeiculos;
        private byte[] imagemEmByte;
        private int id;

        public Veiculo Veiculo
        {
            get { return veiculo; }
            set
            {
                veiculo = value;

                txtId.Text = veiculo.Id.ToString();
                txtVeiculo.Text = veiculo.NomeVeiculo;
                txtMarca.Text = veiculo.Marca;
                txtCor.Text = veiculo.Cor;
                txtCapacidade.Text = veiculo.QuantidadeLugares.ToString();
                txtChassi.Text = veiculo.Chassi;
                txtKm.Text = veiculo.KmAtual.ToString();
                txtLitros.Text = veiculo.LitrosTanque.ToString();
                txtPlaca.Text = veiculo.Placa;
                txtPortas.Text = veiculo.NumeroPortas.ToString();
                txtAno.Text = veiculo.Ano.ToString();
                cmbPortaMalas.SelectedIndex = (int)veiculo.PortaMala;
                cmbVeiculos.Text = veiculo.GrupoDeVeiculos.Nome.ToString();
                fotoCarro.Image = ByteParaImagem(veiculo.Imagem);
            }
        }

        public TelaCadastroDeVeiculo(ControladorVeiculo ctlrVeiculo)
        {
            controlador = ctlrVeiculo;
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            InitializeComponent();
            CarregarTamanhosPortaMalas();
            CarregarGruposDeVeiculos();
        }

        private void CarregarTamanhosPortaMalas()
        {
            cmbPortaMalas.DataSource = Enum.GetValues(typeof(PortaMalaVeiculoEnum));
        }

        private void CarregarGruposDeVeiculos()
        {
            cmbVeiculos.DataSource = controladorGrupoDeVeiculos.SelecionarTodos();
            cmbVeiculos.DisplayMember = "NOME";
            cmbVeiculos.ValueMember = "NOME";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string resultadoValidacao = "";
            int ano = default;
            int capacidade = default;
            int kmAtual = default;
            int litros = default;
            int portas = default;
            int portaMalas = default;

            if (txtId.Text != "")
            {
                id = Convert.ToInt32(txtId.Text);
                
            }
            if(txtAno.Text != "")
            {
                ano = Convert.ToInt32(txtAno.Text);
            }
            if(txtCapacidade.Text != "")
            {
                capacidade = Convert.ToInt32(txtCapacidade.Text);
            }
            if(txtKm.Text != "")
            {
                kmAtual = Convert.ToInt32(txtKm.Text);
            }
            if(txtLitros.Text != "")
            {
                litros = Convert.ToInt32(txtLitros.Text);
            }
            if(txtPortas.Text != "")
            {
                portas = Convert.ToInt32(txtPortas.Text);
            }
            
            string chassi = txtChassi.Text;
            string cor = txtCor.Text;
            string nomeVeiculo = txtVeiculo.Text;
            string marca = txtMarca.Text;
            string placa = txtPlaca.Text;
             
            byte[] imagem = null;
            if (fotoCarro.Image == null)
            {
                resultadoValidacao = "A imagem é obrigatória";
                FormatarRodape(resultadoValidacao);
            }
            else
            {
                imagemEmByte = ImagemParaByte(fotoCarro.Image);
                imagem = imagemEmByte;
            }
            
            
            GrupoDeVeiculos grupoDeVeiculos = (GrupoDeVeiculos)cmbVeiculos.SelectedItem;

            portaMalas = ObtemTamanhoPortaMalas(portaMalas);

            veiculo = new Veiculo(nomeVeiculo, cor, marca, placa, chassi, kmAtual, portas, litros,
                 capacidade, ano, grupoDeVeiculos, (PortaMalaVeiculoEnum)portaMalas,imagem);

            resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                FormatarRodape(resultadoValidacao);
            }

            if (controlador.VerificaPlaca(placa, id))
            {
                resultadoValidacao = "Placa já cadastrada no sistema";
                FormatarRodape(resultadoValidacao);
            }

            
        }

        private void FormatarRodape(string resultadoValidacao)
        {
            string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

            TelaInicial.Instancia.AtualizarRodape(primeiroErro);

            DialogResult = DialogResult.None;
        }

        private int ObtemTamanhoPortaMalas(int portaMalas)
        {
            switch (cmbPortaMalas.SelectedItem)
            {
                case PortaMalaVeiculoEnum.Pequeno: portaMalas = 0; break;

                case PortaMalaVeiculoEnum.Medio: portaMalas = 1; break;

                case PortaMalaVeiculoEnum.Grande: portaMalas = 2; break;
            }

            return portaMalas;
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            selecionarFoto.Filter = "Tipos (*.jpg;*.png) |*.jpg;*.png";
            try
            {
                if (selecionarFoto.ShowDialog() == DialogResult.OK)
                {
                    fotoCarro.Image = Image.FromFile(selecionarFoto.FileName);
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar arquivo","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private Image ByteParaImagem(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

       
        private byte[] ImagemParaByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void txtCapacidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirStringEmCamposDeNumero(e);
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirStringEmCamposDeNumero(e);
        }

        private void txtPortas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirStringEmCamposDeNumero(e);
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirStringEmCamposDeNumero(e);
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirStringEmCamposDeNumero(e);
        }

        private void ImpedirStringEmCamposDeNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void TelaCadastroDeVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
