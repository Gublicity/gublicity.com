using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.Models
{
    public class AdministratorContextSeedData
    {
        private AdministratorContext _context;

        public AdministratorContextSeedData(AdministratorContext context)
        {
            _context = context;
        }
        public void EnsureSeedData()
        {
            if(!_context.Administrators.Any())
            {
                //Create data to add
                var Reynel = new Administrator()
                {
                    Username = "rlopez",
                    Password = "passw0rd"
                };

                var Sergio = new Administrator()
                {
                    Username = "sfernandez",
                    Password = "passw0rd"
                };

                var Gerardo = new Administrator()
                {
                    Username = "giglesias",
                    Password = "passw0rd"
                };

                //Add data created
                _context.Administrators.Add(Gerardo);
                _context.Administrators.Add(Reynel);
                _context.Administrators.Add(Sergio);

                //Push data created
                _context.SaveChanges();
            }
        }
    }
}
