using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartB.Logic.Abstractions;

namespace PartB.Logic.Models
{
    public class Report : ICloneable
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendations { get; set; }

        public object Clone() => MemberwiseClone();
    }
}
