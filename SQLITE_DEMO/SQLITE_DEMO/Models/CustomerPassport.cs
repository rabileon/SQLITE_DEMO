using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITE_DEMO.Models
{
    public class CustomerPassport
    {
        [ForeignKey(typeof(Customer))]
        public int CustomerId { get; set; }
        [ForeignKey(typeof(Passport)]
        public int MyProperty { get; set; }
    }
}
