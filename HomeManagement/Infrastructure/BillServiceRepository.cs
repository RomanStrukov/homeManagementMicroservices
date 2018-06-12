using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using HomeManagement.Application.Models;

namespace HomeManagement.Infrastructure
{
    public class BillServiceRepository //implement coorectly
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HomeManagementDb"].ConnectionString;

        public void Insert(DateTime issueDate, DateTime dueDate, int userId, string counterName, bool status)
        {            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "INSERT Bills (issueData, dueDate, userId, counterName, status) VALUES (@issueData, @dueDate, @userId, @counterName, @status)",
                    new { issueDate, dueDate, userId, counterName, status });
            }
        }
        public void Delete(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "DELETE Bills (Id) ",);
            }
        }

        public IEnumerable<Bill> Get(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "GET Bills (Id) ",);
            }
        }
    }
}