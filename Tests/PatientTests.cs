using PartB.Logic.Models;
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
        public void ScheduleMeet_ShouldAddMeetToPatient()
        {
            var doctor = new Doctor { FullName = "Dr. Smith" };
            var patient = new Patient { FullName = "John Doe" };
            var meet = new Meet { Doctor = doctor, Patient = patient, Date = DateTime.Now };

            patient.ScheduleMeet(meet);

            Assert.Single(patient.Meets);
            Assert.Contains(meet, patient.Meets);
        }

        [Fact]
        public void Clone_ShouldReturnExactCopyOfPatient()
        {
            var patient = new Patient { FullName = "John Doe", DateOfBirth = new DateTime(1990, 1, 1) };

            var clone = (Patient)patient.Clone();

            Assert.NotSame(patient, clone);
            Assert.Equal(patient.FullName, clone.FullName);
            Assert.Equal(patient.DateOfBirth, clone.DateOfBirth);
        }
    }
}
