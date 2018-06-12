using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeManagement.Application.Models
{
    public class Bill
    {
        int Id { get; set; }
        DateTime IssueDate { get; set; }
        DateTime DueDate { get; set; }
        int UserId { get; set; }
        string CounterName { get; set; }
        bool Status { get; set; }

    }
}