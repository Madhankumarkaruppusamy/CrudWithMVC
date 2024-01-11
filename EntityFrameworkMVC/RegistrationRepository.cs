using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMVC
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly DbContxt _contxt;
        public RegistrationRepository(DbContxt contxt)
        {
            _contxt = contxt;
        }
        public void Insert(Registration register)
        {
            try
            {
                _contxt.Database.ExecuteSqlRaw($"exec insertregister'{register.Username}','{register.Password}'");
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                var result = _contxt.Registration.FromSqlRaw<Registration>("").ToList();
                if (result != null || result.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Registration register)
        {
            try
            {
                _contxt.Database.ExecuteSqlRaw("sp");
            }
            catch(Exception ex)
            {
                throw;
            }
        }


        public bool Register(Registration register)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Registration> GetAllRegistration()
        {
            throw new NotImplementedException();
        }

        public Registration GetProductByNumber(long number)
        {
            throw new NotImplementedException();
        }

    }
}
