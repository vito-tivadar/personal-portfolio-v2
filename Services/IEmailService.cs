using personal_portfolio_v2.Models;

namespace personal_portfolio_v2.Services
{
    public interface IEmailService
    {
        Task SendContactNotificationAsync(ContactFormDto form);
        Task SendAutoReplyAsync(ContactFormDto form);
    }
}
