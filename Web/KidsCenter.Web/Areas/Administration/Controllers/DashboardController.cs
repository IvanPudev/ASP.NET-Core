namespace KidsCenter.Web.Areas.Administration.Controllers
{
    using KidsCenter.Services.Data;
    using KidsCenter.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly IEventService settingsService;

        public DashboardController(IEventService settingsService)
        {
            this.settingsService = settingsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel { SettingsCount = this.settingsService.GetCount(), };
            return this.View(viewModel);
        }
    }
}
