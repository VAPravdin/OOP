using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class DoctorTests
    {
        [Fact]
        public void ScheduleMeet_ShouldThrowNotImplementedException()
        {
            var doctor = new Doctor();

            Assert.Throws<NotImplementedException>(() => doctor.ScheduleMeet(new Meet()));
        }

        [Fact]
        public void CancelMeet_ShouldThrowNotImplementedException()
        {
            var doctor = new Doctor();

            Assert.Throws<NotImplementedException>(() => doctor.CancelMeet(new Meet()));
        }

        [Fact]
        public void GetMeets_ShouldThrowNotImplementedException()
        {
            var doctor = new Doctor();

            Assert.Throws<NotImplementedException>(() => doctor.GetMeets());
        }
    }
}
