//This class is responsible for 

using System;
using System.Collections.Generic;
using System.Text;

namespace GetIntoHills.shared
{
    public class RideOn
    {
        public int id { set; get; }
        public int UserId { get; set; }
        public int DriverId { get; set; }
        public RideStatus status { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string DriverLocation { get; set; }
        public DateTime dateOfRequest { get; set; }
        public int RidePrice { get; set; }
        public DateTime CompleteRide { get; set; }

    }

    public enum RideStatus
    {
        Waiting,
        Started,
        Completed
    }
}
