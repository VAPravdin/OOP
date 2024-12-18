using PartB.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Models
{
    public class Meet
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public Report Report { get; set; }

        public void Reschedule(DateTime newDate) => Date = newDate;

        public void AttachReport(Report report) => Report = report;
    }
}
