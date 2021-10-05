using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notebook.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
