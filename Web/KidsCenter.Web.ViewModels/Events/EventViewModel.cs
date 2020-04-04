namespace KidsCenter.Web.ViewModels.Events
{
    using AutoMapper;
    using KidsCenter.Data.Models;
    using KidsCenter.Services.Mapping;

    public class EventViewModel : IMapFrom<Event>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string StartAndEnd { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Event, EventViewModel>().ForMember(
                m => m.StartAndEnd,
                opt => opt.MapFrom(x => $"{x.StartTime} - {x.EndTime}"));
        }
    }
}
