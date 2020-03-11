namespace KidsCenter.Data.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<EventCategory> Events { get; set; } = new HashSet<EventCategory>();
    }
}
