using Logic.Models;
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
        public void Reschedule_ShouldThrowNotImplementedException()
        {
            var meet = new Meet();

            Assert.Throws<NotImplementedException>(() => meet.Reschedule(DateTime.Now));
        }

        [Fact]
        public void AttachReport_ShouldThrowNotImplementedException()
        {
            var meet = new Meet();

            Assert.Throws<NotImplementedException>(() => meet.AttachReport(new Report()));
        }
    }
}
