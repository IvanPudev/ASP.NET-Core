namespace KidsCenter.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KidsCenter.Data;
    using KidsCenter.Data.Common.Repositories;
    using KidsCenter.Data.Models;
    using KidsCenter.Data.Repositories;

    using Microsoft.EntityFrameworkCore;

    using Moq;

    using Xunit;

    public class EventsServiceTests
    {
        [Fact]
        public void GetCountShouldReturnCorrectNumber()
        {
            var repository = new Mock<IDeletableEntityRepository<Event>>();
            repository.Setup(r => r.All()).Returns(new List<Event>
                                                        {
                                                            new Event(),
                                                            new Event(),
                                                            new Event(),
                                                        }.AsQueryable());
            var service = new EventsService(repository.Object);
            Assert.Equal(3, service.GetCount());
            repository.Verify(x => x.All(), Times.Once);
        }

        [Fact]
        public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "EventsTestDb").Options;
            var dbContext = new ApplicationDbContext(options);
            dbContext.Events.Add(new Event());
            dbContext.Events.Add(new Event());
            dbContext.Events.Add(new Event());
            await dbContext.SaveChangesAsync();

            var repository = new EfDeletableEntityRepository<Event>(dbContext);
            var service = new EventsService(repository);
            Assert.Equal(3, service.GetCount());
        }
    }
}
