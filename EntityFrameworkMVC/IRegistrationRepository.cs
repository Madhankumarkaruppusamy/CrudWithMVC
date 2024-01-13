using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMVC
{
    public interface IRegistrationRepository
    {
        public bool Login(Registration check);
        public IEnumerable<Registration> GetAllRegistration();
        public void Insert(Registration product);
        public void Update(Registration register);
        public List<Registration> GetByNumber(long id);
        public List<Registration> Delete(long id);
        public bool Register(Registration register);
    }
}
