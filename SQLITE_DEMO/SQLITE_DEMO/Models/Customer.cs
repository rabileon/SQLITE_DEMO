using SQLite;
using SQLITE_DEMO.Abstractions;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLITE_DEMO.Models
{
    [Table("Customers")]
    public class Customer : TableData
    {
       
        [Column("name"),Indexed, NotNull]
        public string Name { get; set; }
        
        public string Phone { get; set; }

        public int Age { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [Ignore]
        public bool IsYoung { 
            get
            {
                return Age < 30 ? true : false;
            }
        }
        //[ForeignKey(typeof(Passport))]
        //public int PassportId { get; set; }
        //[OneToOne(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]

        //public Passport Passport { get; set; }
        //[OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        //public List<Passport> Passports { get; set; }

        [ManyToMany(typeof(Passport),CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Passport> Passports { get; set; }

    }
}
