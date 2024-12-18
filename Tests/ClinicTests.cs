using PartB.Logic.Models;

namespace Tests
{
    public class ClinicTests
    {
        [Fact]
        public void AddDoctor_ShouldAddDoctorToClinic()
        {
            var clinic = new Clinic();
            var doctor = new Doctor { FullName = "Dr. Smith", Specialization = "Cardiology" };

            clinic.AddDoctor(doctor);

            Assert.Single(clinic.Doctors);
            Assert.Contains(doctor, clinic.Doctors);
            Assert.Equal("Dr. Smith", clinic.Doctors[0].FullName);
        }

        [Fact]
        public void RemoveDoctor_ShouldRemoveDoctorFromClinic()
        {
            var clinic = new Clinic();
            var doctor = new Doctor { FullName = "Dr. Smith" };

            clinic.AddDoctor(doctor);
            clinic.RemoveDoctor(doctor);

            Assert.Empty(clinic.Doctors);
        }

        [Fact]
        public void AddPatient_ShouldAddPatientToClinic()
        {
            var clinic = new Clinic();
            var patient = new Patient { FullName = "John Doe", DateOfBirth = new DateTime(1985, 1, 1) };

            clinic.AddPatient(patient);

            Assert.Single(clinic.Patients);
            Assert.Contains(patient, clinic.Patients);
            Assert.Equal("John Doe", clinic.Patients[0].FullName);
        }

        [Fact]
        public void RemovePatient_ShouldRemovePatientFromClinic()
        {
            var clinic = new Clinic();
            var patient = new Patient { FullName = "John Doe" };

            clinic.AddPatient(patient);
            clinic.RemovePatient(patient);

            Assert.Empty(clinic.Patients);
        }
    }
}