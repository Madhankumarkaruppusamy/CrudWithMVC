using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMVC
{
    public interface IRegistrationRepository
    {
        public bool Login(string username, string password);
        public void Insert(Registration product);
        public void Update(Registration register);
        public Registration GetProductByNumber(long number);
        public IEnumerable<Registration> GetAllRegistration();
        public bool Register(Registration register);
    }
}
