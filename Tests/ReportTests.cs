using Logic.Models;
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
        public void UpdateReport_ShouldThrowNotImplementedException()
        {
            var report = new Report();

            Assert.Throws<NotImplementedException>(() => report.UpdateReport("Diagnosis", "Recommendations"));
        }
    }
}
