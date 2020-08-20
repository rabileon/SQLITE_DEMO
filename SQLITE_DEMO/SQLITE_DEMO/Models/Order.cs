using SQLITE_DEMO.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITE_DEMO.Models
{
    public class Order : TableData
    {
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
