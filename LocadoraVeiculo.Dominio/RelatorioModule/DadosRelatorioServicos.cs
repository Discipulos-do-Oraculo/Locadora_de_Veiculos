using iTextSharp.text;
using iTextSharp.text.pdf;
using LocadoraVeiculo.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo.Dominio.RelatorioModule
{
    public class DadosRelatorioServicos
    {
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

        public void EnviaEmail(Locacao locacao)
        {
            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("discipulosdooraculo@gmail.com", "Rech@123");

                mail.From = new System.Net.Mail.MailAddress("discipulosdooraculo@gmail.com");
                if(locacao.PessoaPF != null)
                {
                    mail.To.Add(new System.Net.Mail.MailAddress(locacao.PessoaPF.Email));
                    mail.CC.Add(new System.Net.Mail.MailAddress(locacao.PessoaPF.Email));
                    mail.Bcc.Add(new System.Net.Mail.MailAddress(locacao.PessoaPF.Email));
                }
                else
                {
                    mail.To.Add(new System.Net.Mail.MailAddress(locacao.Empresa.Email));
                    mail.CC.Add(new System.Net.Mail.MailAddress(locacao.Empresa.Email));
                    mail.Bcc.Add(new System.Net.Mail.MailAddress(locacao.Empresa.Email));
                }
                
                mail.Subject = "Aluga Rech";
                mail.Body = "Você realizou uma locação no Aluga Rech";

                mail.Attachments.Add(new Attachment($@"..\..\..\Relatorios\{locacao.Id}.Pdf"));

                smtp.Send(mail);
            }
        }

        public void FormatandoPagina(Locacao locacao)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);

            doc.AddCreationDate();

            string caminho = $@"..\..\..\Relatorios\{locacao.Id}.Pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados,
            new Font(Font.NORMAL, 14));

            paragrafo.Alignment = Element.ALIGN_CENTER;

            Phrase titulo = new Phrase("ALUGA RECH\n", FontFactory.GetFont("verdana", 18, Font.BOLD));
            paragrafo.Add(titulo);
            paragrafo.Add("\n");
            paragrafo.Add("\n");

            //paragrafo.Alignment = Element.ALIGN_JUSTIFIED;

            if (locacao.Empresa != null)
            {
                paragrafo.Add("Nome da Empresa: " + locacao.Empresa.Nome + "\n");
                paragrafo.Add("Nome do Condutor: " + locacao.Empresa.Condutor.Nome + "\n");
            }
            else
            {
                paragrafo.Add("Nome do Cliente: " + locacao.PessoaPF.Nome + "\n");
            }

            paragrafo.Add("Nome do Veículo: " + locacao.Veiculo.NomeVeiculo + "\n");
            paragrafo.Add("Data de Sáida: " + locacao.DataSaida.ToString() + "\n");
            paragrafo.Add("Data de Retorno: " + locacao.DataRetorno.ToString() + "\n");

            if (locacao.Plano == "Diário")
                paragrafo.Add("Valor do plano Diário: " + locacao.Veiculo.GrupoDeVeiculos.ValorDiaria.ToString() + "\n");

            if (locacao.Plano == "Km Livre")
                paragrafo.Add("Valor do plano Km Livre: " + locacao.Veiculo.GrupoDeVeiculos.ValorKmLivre.ToString() + "\n");

            if (locacao.Plano == "Km Controlado")
            {
                paragrafo.Add("Valor do plano Km Controlado: " + locacao.Veiculo.GrupoDeVeiculos.ValorKmControlado.ToString() + "\n");
                paragrafo.Add("Valor da diária do plano Km Controlado: " + locacao.Veiculo.GrupoDeVeiculos.ValorDiariaKmControlado.ToString() + "\n");
            }

            if (locacao.Cupom != null)
            {
                paragrafo.Add("Nome do Cupom: " + locacao.Cupom.Nome + "\n");
                paragrafo.Add("Valor do Cupom: " + locacao.Cupom.Valor.ToString() + "\n");
            }

            paragrafo.Add("Valor da Garantia: " + locacao.Caucao.ToString() + "\n");
            paragrafo.Add("Valor total previsto: " + locacao.ValorTotal.ToString() + "\n");

            doc.Add(paragrafo);

            doc.Close();
        }

    }
}
