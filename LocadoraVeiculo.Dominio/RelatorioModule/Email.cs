using LocadoraVeiculo.Dominio.LocacaoModule;
using System.Net;
using System.Net.Mail;

namespace LocadoraVeiculo.Dominio.RelatorioModule
{
    public class Email
    {
        SmtpClient smtp = new SmtpClient();

        public string EnviaEmail(Locacao locacao)
        {
            string resultadoValidacao = "";

            if (VerificaConexao())
            {
                using (MailMessage mail = new MailMessage())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("discipulosdooraculo@gmail.com", "Rech@123");

                    mail.From = new MailAddress("discipulosdooraculo@gmail.com");

                    VerificaTipoCliente(locacao, mail);

                    mail.Subject = "Aluga Rech";
                    mail.Body = "Você realizou uma locação no Aluga Rech";

                    mail.Attachments.Add(new Attachment(@"..\..\..\Relatorios\ResumoLocacao.Pdf"));

                    smtp.Send(mail);

                    resultadoValidacao = "ESTA_VALIDO";
                }

            }
            else
                resultadoValidacao += "Sem conexão com a internet";

            return resultadoValidacao;
        }

        private static void VerificaTipoCliente(Locacao locacao, MailMessage mail)
        {
            if (locacao.PessoaPF != null)
            {
                mail.To.Add(new MailAddress(locacao.PessoaPF.Email));
                mail.CC.Add(new MailAddress(locacao.PessoaPF.Email));
                mail.Bcc.Add(new MailAddress(locacao.PessoaPF.Email));
            }
            else
            {
                mail.To.Add(new MailAddress(locacao.Empresa.Email));
                mail.CC.Add(new MailAddress(locacao.Empresa.Email));
                mail.Bcc.Add(new MailAddress(locacao.Empresa.Email));
            }
        }

        public bool VerificaConexao()
        {
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}