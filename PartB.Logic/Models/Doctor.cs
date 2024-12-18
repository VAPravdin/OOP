using PartB.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Models
{
    public class Doctor : Person, ICloneable, IComparable<Doctor>
    {
        public string Specialization { get; set; }
        public List<Meet> Meets { get; set; } = new List<Meet>();

        public override string Role => "Doctor";

        public override void DisplayInfo()
        {
            Console.WriteLine($"Doctor: {FullName}, Specialization: {Specialization}");
        }

        public object Clone() => MemberwiseClone();

        public int CompareTo(Doctor other) => FullName.CompareTo(other.FullName);

        public void ScheduleMeet(Meet meet) => Meets.Add(meet);
        public void CancelMeet(Meet meet) => Meets.Remove(meet);
    }
}
