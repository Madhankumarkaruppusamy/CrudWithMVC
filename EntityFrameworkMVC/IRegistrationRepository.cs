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
        public void Update(long id,Registration value);
        public Registration GetByid(long id);
        public void Delete(long id);
        public bool Register(Registration register);
    }
}
