namespace KidsCenter.Data.Models
{
    using System.Collections.Generic;

    public class Currency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string IsoCode { get; set; }

        public virtual ICollection<Price> Prices { get; set; } = new HashSet<Price>();
    }
}
