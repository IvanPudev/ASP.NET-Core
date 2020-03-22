namespace KidsCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KidsCenter.Data.Common.Models;

    public class AddOn : IDeletableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public virtual ICollection<EventAddOn> Events { get; set; } = new HashSet<EventAddOn>();

        public virtual ICollection<PackageAddOn> Packages { get; set; } = new HashSet<PackageAddOn>();
    }
}
