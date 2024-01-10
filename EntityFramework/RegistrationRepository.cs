using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class RegistrationRepository : IRegistrationRepository
    {
        public IEnumerable<Registration> GetAllRegistration()
        {
            throw new NotImplementedException();
        }

        public Registration GetProductByNumber(long number)
        {
            throw new NotImplementedException();
        }

        public void Insert(Registration product)
        {
            throw new NotImplementedException();
        }
    }
}
