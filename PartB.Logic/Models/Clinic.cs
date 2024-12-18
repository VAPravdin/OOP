using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Models
{
    public class Clinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void AddDoctor(Doctor doctor) => Doctors.Add(doctor);
        public void RemoveDoctor(Doctor doctor) => Doctors.Remove(doctor);

        public void AddPatient(Patient patient) => Patients.Add(patient);
        public void RemovePatient(Patient patient) => Patients.Remove(patient);

        public void ListDoctors()
        {
            Console.WriteLine("Doctors in Clinic:");
            foreach (var doctor in Doctors)
                doctor.DisplayInfo();
        }

        public void ListPatients()
        {
            Console.WriteLine("Patients in Clinic:");
            foreach (var patient in Patients)
                patient.DisplayInfo();
        }
    }
}
