using System.Threading.RateLimiting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using personal_portfolio_v2.Models;
using personal_portfolio_v2.Services;

namespace personal_portfolio_v2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly ILogger<ContactController> _logger;

        public ContactController(IEmailService emailService, ILogger<ContactController> logger)
        {
            _emailService = emailService;
            _logger = logger;
        }

        [HttpPost]
        [EnableRateLimiting("contact")]
        public async Task<IActionResult> Submit([FromBody] ContactFormDto form)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(new { success = false, errors });
            }

            try
            {
                await _emailService.SendContactNotificationAsync(form);
                await _emailService.SendAutoReplyAsync(form);

                _logger.LogInformation("Contact form submitted by {Name} ({Email})", form.Name, form.Email);

                return Ok(new { success = true, message = "Message sent successfully!" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to process contact form from {Email}", form.Email);
                return StatusCode(500, new { success = false, errors = new[] { "Something went wrong. Please try again later." } });
            }
        }
    }
}
