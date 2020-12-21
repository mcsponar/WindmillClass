using System;

namespace WindmillClass.Core.Geo
{
    public class StreetAddress
    {
        #region Properties

        public int Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public AddressType AddressType { get; set; }

        public City City { get; set; }

        public State State { get; set; }

        public ZipCode ZipCode { get; set; }

        public Country Country { get; set; }

        public bool IsPublic { get; set; }

        public DateTime LastUpdated { get; set; }

        #endregion
    }
}