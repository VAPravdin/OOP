using PartB.Logic.Models;
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
        public void ScheduleMeet_ShouldAddMeetToDoctor()
        {
            var doctor = new Doctor { FullName = "Dr. Smith" };
            var patient = new Patient { FullName = "John Doe" };
            var meet = new Meet { Doctor = doctor, Patient = patient, Date = DateTime.Now };

            doctor.ScheduleMeet(meet);

            Assert.Single(doctor.Meets);
            Assert.Contains(meet, doctor.Meets);
        }

        [Fact]
        public void Clone_ShouldReturnExactCopyOfDoctor()
        {
            var doctor = new Doctor { FullName = "Dr. Smith", Specialization = "Surgery" };

            var clone = (Doctor)doctor.Clone();

            Assert.NotSame(doctor, clone);
            Assert.Equal(doctor.FullName, clone.FullName);
            Assert.Equal(doctor.Specialization, clone.Specialization);
        }

        [Fact]
        public void CompareTo_ShouldReturnZeroForEqualDoctors()
        {
            var doctor1 = new Doctor { FullName = "Dr. Smith" };
            var doctor2 = new Doctor { FullName = "Dr. Smith" };

            var result = doctor1.CompareTo(doctor2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CompareTo_ShouldReturnPositiveForAlphabeticallyLaterDoctor()
        {
            var doctor1 = new Doctor { FullName = "Dr. Smith" };
            var doctor2 = new Doctor { FullName = "Dr. Adams" };

            var result = doctor1.CompareTo(doctor2);

            Assert.True(result > 0);
        }
    }
}
