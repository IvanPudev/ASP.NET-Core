namespace KidsCenter.Data.Models
{
    public class EventAddOn
    {
        public int EventId { get; set; }

        public Event Event { get; set; }

        public int AddOnId { get; set; }

        public AddOn AddOn { get; set; }
    }
}
