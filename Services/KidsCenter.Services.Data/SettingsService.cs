namespace KidsCenter.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using KidsCenter.Data.Common.Repositories;
    using KidsCenter.Data.Models;
    using KidsCenter.Services.Mapping;

    public class SettingsService : IEventService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
