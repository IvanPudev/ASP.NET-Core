namespace KidsCenter.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KidsCenter.Data.Common.Models;

    public class PackageAddOn
    {
        public int PackageId { get; set; }

        public Package Package { get; set; }

        public int AddOnId { get; set; }

        public AddOn AddOn { get; set; }
    }
}
