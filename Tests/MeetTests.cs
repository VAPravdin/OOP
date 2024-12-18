using PartB.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class MeetTests
    {
        [Fact]
        public void AttachReport_ShouldLinkReportToMeet()
        {
            var meet = new Meet();
            var report = new Report { Diagnosis = "Flu", Recommendations = "Stay hydrated" };

            meet.AttachReport(report);

            Assert.NotNull(meet.Report);
            Assert.Equal("Flu", meet.Report.Diagnosis);
        }

        [Fact]
        public void Reschedule_ShouldChangeMeetDate()
        {
            var meet = new Meet { Date = DateTime.Now };
            var newDate = meet.Date.AddDays(3);

            meet.Reschedule(newDate);

            Assert.Equal(newDate, meet.Date);
        }
    }
}