using PartB.Logic.Models;

namespace PartB.Logic
{
    class Program
    {
        static void Main()
        {
            Clinic clinic = new Clinic { Name = "HealthCare", Address = "123 Main St" };

            while (true)
            {
                Console.WriteLine("\n--- Clinic Management Menu ---");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Schedule Meet");
                Console.WriteLine("4. List Doctors");
                Console.WriteLine("5. List Patients");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Doctor's Full Name: ");
                        string docName = Console.ReadLine();
                        Console.Write("Enter Specialization: ");
                        string specialization = Console.ReadLine();
                        clinic.AddDoctor(new Doctor { FullName = docName, Specialization = specialization });
                        break;

                    case "2":
                        Console.Write("Enter Patient's Full Name: ");
                        string patName = Console.ReadLine();
                        Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
                        DateTime dob = DateTime.Parse(Console.ReadLine());
                        clinic.AddPatient(new Patient { FullName = patName, DateOfBirth = dob });
                        break;

                    case "3":
                        if (clinic.Doctors.Count == 0 || clinic.Patients.Count == 0)
                        {
                            Console.WriteLine("Add at least one doctor and one patient first.");
                            break;
                        }
                        Console.Write("Select Doctor (by index): ");
                        int docIndex = int.Parse(Console.ReadLine());
                        Console.Write("Select Patient (by index): ");
                        int patIndex = int.Parse(Console.ReadLine());
                        var meet = new Meet
                        {
                            Doctor = clinic.Doctors[docIndex],
                            Patient = clinic.Patients[patIndex],
                            Date = DateTime.Now
                        };
                        clinic.Doctors[docIndex].ScheduleMeet(meet);
                        clinic.Patients[patIndex].ScheduleMeet(meet);
                        Console.WriteLine("Meet scheduled.");
                        break;

                    case "4":
                        clinic.ListDoctors();
                        break;

                    case "5":
                        clinic.ListPatients();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}