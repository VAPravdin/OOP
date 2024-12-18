using PartB.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Models
{
    public class Patient : Person, ICloneable
    {
        public List<Meet> Meets { get; set; } = new List<Meet>();

        public override string Role => "Patient";

        public override void DisplayInfo()
        {
            Console.WriteLine($"Patient: {FullName}, DOB: {DateOfBirth.ToShortDateString()}");
        }

        public object Clone() => MemberwiseClone();

        public void ScheduleMeet(Meet meet) => Meets.Add(meet);
        public void CancelMeet(Meet meet) => Meets.Remove(meet);
    }
}
