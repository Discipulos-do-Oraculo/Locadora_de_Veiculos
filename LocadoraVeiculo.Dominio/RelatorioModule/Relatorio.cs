using ImageProcessor.Processors;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LocadoraVeiculo.Dominio.LocacaoModule;
using LocadoraVeiculo.Dominio.TaxasEServicosModule;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.RelatorioModule
{
    public class Relatorio 
    {
        public void FormatandoPagina(Locacao locacao, List<TaxasEServicos> taxas)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);

            doc.AddCreationDate();

            string caminho = @"..\..\..\Relatorios\ResumoLocacao.Pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, FontFactory.GetFont("ROBOTO", 18, Font.NORMAL));

            paragrafo.Alignment = Element.ALIGN_CENTER;

            Phrase titulo = new Phrase("ALUGA RECH\n", FontFactory.GetFont("verdana", 18, Font.BOLD));
            paragrafo.Add(titulo);

            PularLinha(paragrafo);

            AdicionarParagrafos(locacao, paragrafo, taxas);

            Image watermark = Image.GetInstance(@"..\..\..\LocadoraVeiculos.WindowsForms\Resources\icons8-car-100.png");

            watermark.SetAbsolutePosition(240, 200);

            doc.Add(watermark);

            doc.Add(paragrafo);

            doc.Close();
        }

        private static void AdicionarParagrafos(Locacao locacao, Paragraph paragrafo, List<TaxasEServicos> taxas)
        {
            VerificaTipoCliente(locacao, paragrafo);

            paragrafo.Add("Nome do Veículo: " + locacao.Veiculo.NomeVeiculo + "\n");
            paragrafo.Add("Data de Sáida: " + locacao.DataSaida.ToString() + "\n");
            paragrafo.Add("Data de Retorno: " + locacao.DataRetorno.ToString() + "\n");

            if (locacao.Plano == "Diário")
                paragrafo.Add("Valor do plano Diário: " + locacao.Veiculo.GrupoDeVeiculos.ValorDiaria.ToString() +" reais" + "\n");

            if (locacao.Plano == "Km Livre")
                paragrafo.Add("Valor do plano Km Livre: " + locacao.Veiculo.GrupoDeVeiculos.ValorKmLivre.ToString() + " reais" + "\n");

            if (locacao.Plano == "Km Controlado")
            {
                paragrafo.Add("Valor do plano Km Controlado: " + locacao.Veiculo.GrupoDeVeiculos.ValorKmControlado.ToString() + " reais" + "\n");
                paragrafo.Add("Valor da diária do plano Km Controlado: " + locacao.Veiculo.GrupoDeVeiculos.ValorDiariaKmControlado.ToString() + " reais" + "\n");
            }

            if (locacao.Cupom != null)
            {
                paragrafo.Add("Nome do Cupom: " + locacao.Cupom.Nome + "\n");
                paragrafo.Add("Valor do Cupom: " + locacao.Cupom.Valor.ToString() + " reais" + "\n");
            }

            if(taxas != null)
            {
                foreach (var item in taxas)
                    paragrafo.Add("Taxa e Serviço utilizado: " + item.Nome +", valor de " + item.Valor.ToString() + " reais" + "\n");                
            }
            
            paragrafo.Add("Valor da Garantia: " + locacao.Caucao.ToString() + " reais" + "\n");
            paragrafo.Add("Valor total previsto: " + locacao.ValorTotal.ToString() + " reais" + "\n");
        }

        private static void VerificaTipoCliente(Locacao locacao, Paragraph paragrafo)
        {
            if (locacao.Empresa != null)
            {
                paragrafo.Add("Nome da Empresa: " + locacao.Empresa.Nome + "\n");
                paragrafo.Add("Nome do Condutor: " + locacao.Empresa.Condutor.Nome + "\n");
            }
            else
                paragrafo.Add("Nome do Cliente: " + locacao.PessoaPF.Nome + "\n");
        }

        private static void PularLinha(Paragraph paragrafo)
        {
            paragrafo.Add("\n");
            paragrafo.Add("\n");
            paragrafo.Add("\n");
            paragrafo.Add("\n");
        }
    }
}
