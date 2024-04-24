using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(EmailRequestDTO request)
    {
        request= new EmailRequestDTO();

        // Implement email sending logic using System.Net.Mail or another library
        // For simplicity, let's assume System.Net.Mail is used
        using (var client = new SmtpClient())
        {
            // Configure SMTP settings (e.g., host, port, credentials)
            // For demonstration purposes, these settings can be hardcoded or retrieved from configuration

            // Example settings:
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            var username = "gen.vinnikov@gmail.com";
            var password = "ronmoison2005"; // Use             
            client.Credentials = new NetworkCredential(username, password);
            var to_="gen.vinnikov@gmail.com";

            // Create and send the email message
            using (var message = new MailMessage("gen.vinnikov@gmail.com", to_, request.Subject, request.Body))
            {
                await client.SendMailAsync(message);
            }
        }
    }
}
