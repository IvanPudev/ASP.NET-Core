namespace KidsCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KidsCenter.Data.Common.Models;

    public class Price : IAuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public int CurrencyId { get; set; }

        public Currency Currency { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

        public virtual ICollection<AddOn> AddOns { get; set; } = new HashSet<AddOn>();
    }
}
