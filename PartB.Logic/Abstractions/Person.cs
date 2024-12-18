using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Abstractions
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public abstract string Role { get; }
        public abstract void DisplayInfo();
    }
}
