using System;
using System.Collections.Generic;
using System.Text;
using WindmillClass.Core.Geo;

namespace WindmillClass.Core.Roster
{
    public class Actor
    {
        #region Properties

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

        public List<Location> Locations { get; set; }

        public List<EmailAddress> EmailAddresses { get; set; }



        #endregion 
    }
}
