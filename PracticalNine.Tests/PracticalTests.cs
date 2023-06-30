using Microsoft.AspNetCore.Mvc;
using PracticalNine.Controllers;

namespace PracticalNine.Tests
{
    public class PracticalTests
    {
        /// <summary>
        /// Match ViewResult displayed correctly in the web browser
        /// </summary>
        [Fact]
        public void PracticalNine_Test3_IsEqual()
        {
            //Assign
            PracticalController controller = new PracticalController();

            //Act
            ViewResult res = (ViewResult) controller.Test3();

            //Assert
            Assert.Equal("Hello World", res.ViewData["Message"]);
        }
    }
}