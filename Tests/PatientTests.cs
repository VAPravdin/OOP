using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class PatientTests
    {
        [Fact]
        public void ScheduleMeet_ShouldThrowNotImplementedException()
        {
            var patient = new Patient();

            Assert.Throws<NotImplementedException>(() => patient.ScheduleMeet(new Meet()));
        }

        [Fact]
        public void CancelMeet_ShouldThrowNotImplementedException()
        {
            var patient = new Patient();

            Assert.Throws<NotImplementedException>(() => patient.CancelMeet(new Meet()));
        }

        [Fact]
        public void GetMeets_ShouldThrowNotImplementedException()
        {
            var patient = new Patient();

            Assert.Throws<NotImplementedException>(() => patient.GetMeets());
        }
    }
}
