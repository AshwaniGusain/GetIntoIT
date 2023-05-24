using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetIntoHills.shared
{
    public class DriverDetails
    {
        public DriverDetails() { }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string licenseNumber { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }

    }


}
