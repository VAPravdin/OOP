using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendations { get; set; }
        public Meet Meet { get; set; }
        public void UpdateReport(string diagnosis, string recommendations)
        {
            throw new NotImplementedException();
        }
    }
}
