using System;

namespace WindmillClass.Core.Geo
{
    public class Location
    {
        #region Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public StreetAddress Address { get; set; }

        public bool IsPublic { get; set; }

        public bool IsPrimary { get; set; }

        public DateTime LastUpdated { get; set; }

        #endregion
    }
}