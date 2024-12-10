using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ServiceTests
    {
        [Fact]
        public void UpdateService_ShouldThrowNotImplementedException()
        {
            var service = new Service();

            Assert.Throws<NotImplementedException>(() => service.UpdateService("New Service", 100.00m));
        }
    }
}
