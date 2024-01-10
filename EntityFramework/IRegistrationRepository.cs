using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public interface IRegistrationRepository
    {
        public void Insert(Registration product);
        public Registration GetProductByNumber(long number);
        public IEnumerable<Registration> GetAllRegistration();
    }
}
