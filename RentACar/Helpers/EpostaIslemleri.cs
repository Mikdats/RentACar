using System.Text;

namespace RentACar.Helpers
{
    public class EpostaIslemleri
    {
        public static void AktivasyonMailiGonder(string alici)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(alici);
            mail.From = new System.Net.Mail.MailAddress("303carrental@gmail.com");
            mail.Subject = "303-Car Rental Üyelik Aktivasyon";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            string linkk = "https://localhost:7293/Hesap/Aktivasyon?kkk=" + Sifreleme.Sifrele(alici);


            var HtmlBody = new StringBuilder();
            HtmlBody.AppendFormat("Hoşgeldiniz , {0}\n", "Sevgili Kullanıcımız");
            HtmlBody.AppendLine(@"Hesabınızı aktive etmek için aşağıdaki bağlantıya tıklayın.");
            HtmlBody.AppendLine("<a href=\"" + linkk + "\">AKTİVASYON</a>");
            mail.Body = HtmlBody.ToString();
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();


            client.Credentials = new System.Net.NetworkCredential("303carrental@gmail.com", "Test123!");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);

            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }

            }
        }

    }
}