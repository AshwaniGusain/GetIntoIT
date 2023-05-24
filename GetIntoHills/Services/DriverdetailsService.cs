using GetIntoHills.Data;
using GetIntoHills.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetIntoHills.Services
{
    public class DriverdetailsService : ServiceBase<DriverDetails>
    {
        public DriverdetailsService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
