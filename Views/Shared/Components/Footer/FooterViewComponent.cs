using Microsoft.AspNetCore.Mvc;

namespace personal_portfolio_v2.Views.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public FooterViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
