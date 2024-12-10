using Logic.Models;
using Logic;

namespace Tests
{
    public class ClinicTests
    {
        [Fact]
        public void AddDoctor_ShouldThrowNotImplementedException()
        {
            var clinic = new Clinic();

            Assert.Throws<NotImplementedException>(() => clinic.AddDoctor(new Doctor()));
        }

        [Fact]
        public void RemoveDoctor_ShouldThrowNotImplementedException()
        {
            var clinic = new Clinic();

            Assert.Throws<NotImplementedException>(() => clinic.RemoveDoctor(new Doctor()));
        }

        [Fact]
        public void AddService_ShouldThrowNotImplementedException()
        {
            var clinic = new Clinic();

            Assert.Throws<NotImplementedException>(() => clinic.AddService(new Service()));
        }

        [Fact]
        public void RemoveService_ShouldThrowNotImplementedException()
        {
            var clinic = new Clinic();

            Assert.Throws<NotImplementedException>(() => clinic.RemoveService(new Service()));
        }
    }
}