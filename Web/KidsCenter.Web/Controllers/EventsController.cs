namespace KidsCenter.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using KidsCenter.Data.Common.Repositories;
    using KidsCenter.Data.Models;
    using KidsCenter.Services.Data;
    using KidsCenter.Web.ViewModels.Events;

    using Microsoft.AspNetCore.Mvc;

    public class EventsController : BaseController
    {
        private readonly IEventService settingsService;

        private readonly IDeletableEntityRepository<Event> repository;

        public EventsController(IEventService settingsService, IDeletableEntityRepository<Event> repository)
        {
            this.settingsService = settingsService;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var events = this.settingsService.GetAll<EventViewModel>();
            var model = new EventsListViewModel { Events = events };
            return this.View(model);
        }

        public async Task<IActionResult> CreateEvent()
        {
            var random = new Random();
            var item = new Event { Title = $"Name_{random.Next()}", Description = $"Value_{random.Next()}" };

            await this.repository.AddAsync(item);
            await this.repository.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
