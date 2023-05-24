using GetIntoHills.Data;
using GetIntoHills.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetIntoHills.Services
{
    public class UserDetailsService : ServiceBase<UserDetails>
    {
        public UserDetailsService(ApplicationDbContext context) : base(context)
        {

        }

    }
}
