﻿namespace KidsCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KidsCenter.Data.Common.Models;

    public class Event : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public short ChildrenCount { get; set; }

        public short? AdultsCount { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<EventCategory> Categories { get; set; } = new HashSet<EventCategory>();

        public virtual ICollection<EventAddOn> AddOns { get; set; } = new HashSet<EventAddOn>();
    }
}
