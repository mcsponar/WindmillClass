using System;

namespace WindmillClass.Core.Roster
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public DateTime LastUpdated { get; set; }

        public CountryCode CountryCode { get; set; }

        public string AreaCode { get; set; }

        public string PhonePrefix { get; set; }

        public string LineNumber { get; set; }

        public bool IsPublic { get; set; }

        public bool IsPrimary { get; set; }

        public PhoneType PhoneType { get; set; }
    }
}