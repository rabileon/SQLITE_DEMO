using SQLITE_DEMO.Abstractions;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITE_DEMO.Models
{
    public class Passport : TableData
    {
        public DateTime ExpirationDate { get; set; }
        [ForeignKey(typeof(Customer))]
        public int CustomerId { get; set; }
        [ManyToMany(typeof(Customer)]
        public List<Customer> Type { get; set; }
    }
}
