namespace KidsCenter.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using KidsCenter.Data.Common.Repositories;
    using KidsCenter.Data.Models;
    using KidsCenter.Services.Mapping;

    public class EventsService : IEventService
    {
        private readonly IDeletableEntityRepository<Event> eventsRepository;

        public EventsService(IDeletableEntityRepository<Event> eventsRepository)
        {
            this.eventsRepository = eventsRepository;
        }

        public int GetCount()
        {
            return this.eventsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.eventsRepository.All().To<T>().ToList();
        }
    }
}
