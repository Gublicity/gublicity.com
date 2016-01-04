using Microsoft.Data.Entity;
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

        public void AddAdministrator(Administrator newAdmin)
        {
            _context.Add(newAdmin);
        }

        public IEnumerable<Administrator> getAllAdministrators()
        {
            return _context.Administrators.OrderBy(a => a.Username).ToList();
        }

        public Administrator getAdministratorByName(string userName)
        {
            return _context.Administrators.Where(t => t.Username.Equals(userName)).FirstOrDefault();
        }

        public bool SaveAll()
        {
          return _context.SaveChanges() > 0;
        }
    }
}
