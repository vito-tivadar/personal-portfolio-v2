using Microsoft.AspNetCore.Mvc;

namespace personal_portfolio_v2.Views.Shared.Components.ContactForm
{
    public class ContactFormViewComponent : ViewComponent
    {
        public ContactFormViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
