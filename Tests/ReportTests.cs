using PartB.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ReportTests
    {
        [Fact]
        public void Clone_ShouldReturnExactCopyOfReport()
        {
            var report = new Report { Diagnosis = "Flu", Recommendations = "Rest for 3 days" };

            var clone = (Report)report.Clone();

            Assert.NotSame(report, clone);
            Assert.Equal(report.Diagnosis, clone.Diagnosis);
            Assert.Equal(report.Recommendations, clone.Recommendations);
        }
    }
}
