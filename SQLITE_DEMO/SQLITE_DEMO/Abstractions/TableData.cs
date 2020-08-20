using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITE_DEMO.Abstractions
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
