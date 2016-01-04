using System.Collections.Generic;

namespace Gublicity.Models
{
    public interface IGublicityRepository
    {
        IEnumerable<Administrator> getAllAdministrators();
        Administrator getAdministratorByName(string userName);
        void AddAdministrator(Administrator newAdmin);
        bool SaveAll();
    }
}