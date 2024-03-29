﻿using Microsoft.EntityFrameworkCore;
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
                _contxt.Database.ExecuteSqlRaw($"exec InsertRegister'{register.Username}','{register.Password}'");
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool Login(string Username, string Password)
        {
            try
            {
                var result = _contxt.Registration.FromSqlRaw<Registration>($"select * from Registration where Username='{Username}' and Password='{Password}'").ToList();
                if (result == null || result.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<Registration> GetAllRegistration()
        {
              try
              {
                  var result = _contxt.Registration.FromSqlRaw<Registration>($"select * from Registration");
                return result.ToList(); 

              }
              catch (Exception )
              {
                  throw;
              }
        }


        public void Update(long id, Registration value)
        {
            try
            {
                var result =_contxt.Database.ExecuteSqlRaw($" update Registration set Username='{value.Username}',Password='{value.Password}' where RegistrationId={id}");
                
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public Registration GetByid(long id)
        {
            try
            {
                var result = _contxt.Registration.FromSqlRaw<Registration>($"select * from Registration where RegistrationId= {id}");
                return result.ToList().FirstOrDefault(); 

            }
            catch (Exception)
            {
                throw;
            }

        }
        public void Delete(long id)
        {
            try
            {
                var result = _contxt.Database.ExecuteSqlRaw($" delete Registration where RegistrationId={id}");
                

            }
            catch (Exception)
            {
                throw;
            }

        }


        public bool Register(Registration register)
        {
            try
            {
                var result = _contxt.Registration.FromSqlRaw<Registration>($"select * from Registration where Username='{register.Username}' And Password='{register.Password}'").ToList();
                if(result.Count == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
       

       

    }
}
