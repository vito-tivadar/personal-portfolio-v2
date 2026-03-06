using Microsoft.AspNetCore.Mvc;

namespace personal_portfolio_v2.Views.Shared.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        public NavbarViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
