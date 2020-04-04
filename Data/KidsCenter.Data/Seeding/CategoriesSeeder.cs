namespace KidsCenter.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KidsCenter.Data.Models;

    internal class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Settings.AddRangeAsync(new List<Setting>
            {
                new Setting { Name = "Рожден ден" },
                new Setting { Name = "Кръщене" },
                new Setting { Name = "Имен ден" },
                new Setting { Name = "Уъркшоп" },
                new Setting { Name = "Семинар" },
                new Setting { Name = "Друго" },
            });
        }
    }
}
