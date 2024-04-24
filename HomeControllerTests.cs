using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using aspnet_core_unit_1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace aspnet_core_unit_1_test
{
    public class HomeControllerTests
    {
        [Theory]
        [InlineData(500)]
        [InlineData(2)]
        


        public void CheckCountValueTest(int i)
        {
           
            var controller = new HomeController(null);

            var result=controller.CheckCountValue(i);  

            Assert.NotNull(result); 


        }

    }
}
