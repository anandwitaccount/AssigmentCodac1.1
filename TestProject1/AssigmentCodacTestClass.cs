using AssigmentCodac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using static AssigmentCodac.IserviceClass;

namespace AssigmentCodacTestProject
{

    [TestClass]
    public class AssigmentCodacTestClass
    {
        ServiceProvider serviceProvider = Config.configmethod();
       
        [TestMethod]
        public void Test_FFRFLFLF()
        {
            var service = serviceProvider.GetService<IRepoPosition>();

            var maximumPoints = new List<int>() { 5, 5 };
            var newMoves = "FFRFLFLF";

            service.MovingStart(maximumPoints, newMoves);
            string direction = service.GetNameOfDirection((Directions)Enum.Parse(typeof(Directions), 
                service.Direction.ToString()));

            var actualOutput = $"{service.X},{service.Y},{direction}";
            var expectedOutput = "1,4,West";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void Test_RRLFR()
        {


            var service = serviceProvider.GetService<IRepoPosition>();

            var maximumPoints = new List<int>() { 2, 2 };
            var newMoves = "RRLFR";

            service.MovingStart(maximumPoints, newMoves);
            string direction = service.GetNameOfDirection((Directions)Enum.Parse(typeof(Directions),
                service.Direction.ToString()));

            var actualOutput = $"{service.X},{service.Y},{direction}";
            var expectedOutput = "2,1,South";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test_GetNameOfDirection()
        {

            var service = serviceProvider.GetService<IRepoPosition>();

            Directions directions = Directions.N;
            string direction = service.GetNameOfDirection(directions);
            var actualOutput = direction;
            var expectedOutput = "North";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

       
        [TestMethod]
        public void Test_00()
        {
            var service = serviceProvider.GetService<IRepoPosition>();
            var maximumPoints = new List<int>() { 0, 0 };
            var newMoves = "RRLFR";
            string message = "Position can not be beyond bounderies (0,0) and (0,0)";

            var ex = Assert.ThrowsException<Exception>(() => service.MovingStart(maximumPoints, newMoves));
            Assert.AreEqual(ex.Message, message);
        
        }
    }
}