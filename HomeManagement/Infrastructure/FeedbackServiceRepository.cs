using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using HomeManagement.Application.Models;

namespace HomeManagement.Infrastructure
{
    public class FeedbackServiceRepository //implement coorectly
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HomeManagementDb"].ConnectionString;

        public void Insert(DateTime issueDate, DateTime dueDate, int userId, string counterName, bool status)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "INSERT UserComments ",
                    new { });
            }
        }
        public void Delete(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "DELETE UserComments (Id) ",);
            }
        }

        public IEnumerable<Bill> Get(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    "GET UserComments (Id) ",);
            }
        }
    }
}