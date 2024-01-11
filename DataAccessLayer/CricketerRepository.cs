using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace DapperDataAccessLayer
{
    public class CricketerRepository : ICricketerRepository
    {

        public string connectionString;
        public CricketerRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DbConnection");
        }
        public void InsertSP(Cricketer details)
        {
            try
            {
                var con = new SqlConnection(connectionString);
                con.Open();
                var insertQuery = $"exec InsertSP @CricketerName='{details.CricketerName}', @TotalODI={details.TotalODI}, @TotalScore={details.TotalScore}, @Fifties={details.Fifties},@Hundreds={details.Hundreds},@LocationId={details.LocationId} ";
                con.Execute(insertQuery);
                con.Close();


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


        public List<Cricketer> ReadSP()
        {
            
            try
            {
                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec ReadSP";
                var stats = con.Query<Cricketer>(selectQuery);

                con.Close();
                return stats.ToList();


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
        public Cricketer ReadSPById(long CricketerId)
        {
            try
            {
                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec ReadSPById {CricketerId}";
                var stats = con.QueryFirstOrDefault<Cricketer>(selectQuery);

                con.Close();
                return stats;


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


        public void DeleteSP(long CricketerId)
        {
            try
            {

                var con = new SqlConnection(connectionString);
                con.Open();
                var deleteQuery = $"exec DeleteSP {CricketerId}";
                con.Execute(deleteQuery);
                con.Close();

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
        public void UpdateSP(long cricketerId, Cricketer prd)
        {
            try
            {
                var con = new SqlConnection(connectionString);
                con.Open();
                var updateQuery = $"exec UpdateSP  {cricketerId},'{prd.CricketerName}',{prd.TotalODI},{prd.TotalScore},{prd.Fifties},{prd.Hundreds},{prd.LocationId} ";
                con.Execute(updateQuery);
                con.Close();


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


