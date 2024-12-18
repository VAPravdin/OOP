using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartA.Logic.Abstractions;

namespace PartA.Logic.Models
{
    public class Doctor : Identity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public List<Meet> Meets { get; set; }
        public void ScheduleMeet(Meet meet)
        {
            throw new NotImplementedException();
        }
        public void CancelMeet(Meet meet)
        {
            throw new NotImplementedException();
        }
        public List<Meet> GetMeets()
        {
            throw new NotImplementedException();
        }
    }
}
