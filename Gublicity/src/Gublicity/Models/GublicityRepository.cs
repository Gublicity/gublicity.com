using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.Models
{
    public class GublicityRepository : IGublicityRepository
    {
        private AdministratorContext _context;

        public GublicityRepository(AdministratorContext context)
        {
            _context = context;
        }
        public IEnumerable<Administrator> getAllAdministrators()
        {
            return _context.Administrators.OrderBy(a => a.Username).ToList();
        }
    }
}
