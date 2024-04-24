using System.Threading.Tasks;

public interface IEmailService
{
    Task SendEmailAsync(EmailRequestDTO request);
}
