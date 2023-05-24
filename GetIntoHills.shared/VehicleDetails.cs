using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetIntoHills.shared
{
    public class VehicleDetails
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string vehicleNumber { get; set; }
        public vehicleType VehicleType { get; set; }
    }

    public enum vehicleType
    {
        Mini,
        Sedan,
        SUV
    }
}
