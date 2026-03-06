using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using personal_portfolio_v2.Models;

namespace personal_portfolio_v2.Services;

public class EmailService : IEmailService
{
    private readonly SmtpSettings _smtp;
    private readonly ILogger<EmailService> _logger;

    public EmailService(IOptions<SmtpSettings> smtpOptions, ILogger<EmailService> logger)
    {
        _smtp = smtpOptions.Value;
        _logger = logger;
    }

    public async Task SendContactNotificationAsync(ContactFormDto form)
    {
        var subject = $"Portfolio Contact: {form.Name}";
        var body = $"""
            <html>
            <body style="margin:0;padding:0;font-family:'Inter',Arial,sans-serif;background:#f0f0f0;color:#111111;">
              <div style="max-width:600px;margin:40px auto;background:#ffffff;border:1px solid rgba(0,0,0,0.08);padding:40px;">
                <h2 style="font-family:'Rajdhani',Arial,sans-serif;color:#ff5a1f;margin:0 0 24px 0;font-size:28px;">
                  New Contact Message
                </h2>
                <table style="width:100%;border-collapse:collapse;">
                  <tr>
                    <td style="padding:12px 0;border-bottom:1px solid rgba(0,0,0,0.08);color:#666666;font-size:14px;width:80px;">Name</td>
                    <td style="padding:12px 0;border-bottom:1px solid rgba(0,0,0,0.08);color:#111111;font-size:14px;">{WebUtility.HtmlEncode(form.Name)}</td>
                  </tr>
                  <tr>
                    <td style="padding:12px 0;border-bottom:1px solid rgba(0,0,0,0.08);color:#666666;font-size:14px;">Email</td>
                    <td style="padding:12px 0;border-bottom:1px solid rgba(0,0,0,0.08);color:#111111;font-size:14px;">
                      <a href="mailto:{WebUtility.HtmlEncode(form.Email)}" style="color:#ff5a1f;text-decoration:none;">{WebUtility.HtmlEncode(form.Email)}</a>
                    </td>
                  </tr>
                </table>
                <div style="margin-top:24px;padding:20px;background:#f9f9f9;border:1px solid rgba(0,0,0,0.08);">
                  <p style="margin:0;color:#333333;font-size:14px;line-height:1.75;white-space:pre-wrap;">{WebUtility.HtmlEncode(form.Message)}</p>
                </div>
              </div>
            </body>
            </html>
            """;

        await SendEmailAsync(_smtp.ToEmail, subject, body);
    }

    public async Task SendAutoReplyAsync(ContactFormDto form)
    {
        var subject = "Thanks for reaching out!";
        var body = $"""
            <html>
            <body style="margin:0;padding:0;font-family:'Inter',Arial,sans-serif;background:#f0f0f0;color:#111111;">
              <div style="max-width:600px;margin:40px auto;background:#ffffff;border:1px solid rgba(0,0,0,0.08);padding:40px;">
                <div style="text-align:center;margin-bottom:32px;">
                  <a href="https://vitotivadar.com" style="text-decoration:none;display:inline-block;">
                    <img src="https://vitotivadar.com/assets/vt_primary.png"
                         alt="VT"
                         width="48"
                         height="48"
                         style="display:block;border:0;height:48px;width:auto;" />
                  </a>
                  <p style="color:#888888;font-size:12px;letter-spacing:0.12em;text-transform:uppercase;margin:4px 0 0 0;">
                    Frontend · Backend · Embedded
                  </p>
                </div>

                <h2 style="font-family:'Rajdhani',Arial,sans-serif;color:#111111;margin:0 0 16px 0;font-size:24px;font-weight:600;">
                  Hey {WebUtility.HtmlEncode(form.Name)},
                </h2>

                <p style="color:#555555;font-size:14px;line-height:1.75;margin:0 0 16px 0;">
                  Thank you for reaching out! I've received your message and will get back to you as soon as possible.
                </p>

                <p style="color:#555555;font-size:14px;line-height:1.75;margin:0 0 24px 0;">
                  In the meantime, feel free to check out my latest projects or connect with me on social media.
                </p>

                <div style="padding:20px;background:#f9f9f9;border:1px solid rgba(0,0,0,0.08);margin-bottom:24px;">
                  <p style="color:#888888;font-size:12px;text-transform:uppercase;letter-spacing:0.1em;margin:0 0 8px 0;">Your message:</p>
                  <p style="margin:0;color:#555555;font-size:14px;line-height:1.75;white-space:pre-wrap;">{WebUtility.HtmlEncode(form.Message)}</p>
                </div>

                <div style="border-top:1px solid rgba(0,0,0,0.08);padding-top:24px;text-align:center;">
                  <p style="color:#888888;font-size:12px;letter-spacing:0.1em;margin:0;">
                    Best regards,<br/>
                    <span style="color:#ff5a1f;font-weight:600;">Vito Tivadar</span>
                  </p>
                </div>
              </div>
            </body>
            </html>
            """;

        await SendEmailAsync(form.Email, subject, body);
    }

    private async Task SendEmailAsync(string toEmail, string subject, string htmlBody)
    {
        using var client = new SmtpClient(_smtp.Host, _smtp.Port)
        {
            Credentials = new NetworkCredential(_smtp.Username, _smtp.Password),
            EnableSsl = true
        };

        var message = new MailMessage
        {
            From = new MailAddress(_smtp.FromEmail, _smtp.FromName),
            Subject = subject,
            Body = htmlBody,
            IsBodyHtml = true
        };
        message.To.Add(toEmail);

        try
        {
            await client.SendMailAsync(message);
            _logger.LogInformation("Email sent to {To} with subject '{Subject}'", toEmail, subject);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send email to {To}", toEmail);
            throw;
        }
    }
}
