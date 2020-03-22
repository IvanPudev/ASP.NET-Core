namespace KidsCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KidsCenter.Data.Common.Models;

    public class Package : IDeletableEntity, IAuditInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        DateTime IAuditInfo.CreatedOn { get; set; }

        DateTime? IAuditInfo.ModifiedOn { get; set; }

        public int CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public virtual ICollection<PackageAddOn> AddOns { get; set; } = new HashSet<PackageAddOn>();
    }
}
