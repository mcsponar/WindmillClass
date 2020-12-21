using System;
using System.Collections.Generic;
using System.Text;

namespace WindmillClass.Core.Asset
{
    class Hull
    {
        public int Id { get; set; }

        public int HullNumber{ get; set; }

        public string Name { get; set; }

        public DateTime LastUpdated { get; set; }

        public List<Measurement> Weights { get; set; }


    }
}
