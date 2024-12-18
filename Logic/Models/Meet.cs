using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartA.Logic.Abstractions;

namespace PartA.Logic.Models
{
    public class Meet : Identity
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public Report Report { get; set; }
        public void Reschedule(DateTime newDate)
        {
            throw new NotImplementedException();
        }
        public void AttachReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
