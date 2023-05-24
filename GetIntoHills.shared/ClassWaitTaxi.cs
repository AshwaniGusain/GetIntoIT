using System;
using System.Collections.Generic;
using System.Text;

namespace GetIntoHills.shared
{
    public class ClassWaitTaxi
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public RideStatus status { get; set; }
        public string geoLocation { get; set; }
        public DateTime dateOfRequest { get; set; }
    }
}
