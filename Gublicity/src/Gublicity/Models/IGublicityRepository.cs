using System.Collections.Generic;

namespace Gublicity.Models
{
    public interface IGublicityRepository
    {
        IEnumerable<Administrator> getAllAdministrators();
    }
}