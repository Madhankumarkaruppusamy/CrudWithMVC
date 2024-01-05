using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public class LocationRepository : ILocationRepository
    {
        public string connectionString;
        public LocationRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DbConnection");
        }

        public IEnumerable<Location> GetAllLocations()
        {
      
            try
            {
                
                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"select * from location";
                var product = con.Query<Location>(selectQuery);

                con.Close();
                return product.ToList();


            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
