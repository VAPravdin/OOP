using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Clinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Service> Services { get; set; }
        public void AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
        public void RemoveDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
        public void AddService(Service service)
        {
            throw new NotImplementedException();
        }
        public void RemoveService(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
