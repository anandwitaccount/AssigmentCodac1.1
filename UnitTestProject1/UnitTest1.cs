using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AssigmentCodacTestProject
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FFRFLFLF()
        {
            RepoPositionClass position = new RepoPositionClass()
            {
                X = 1,
                Y = 1,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "FFRFLFLF";

            position.StartMoving(maxPoints, moves);
            string direction = position.GetNameOfDirection((Directions)Enum.Parse(typeof(Directions), position.Direction.ToString()));

            var actualOutput = $"{position.X},{position.Y},{direction}";
            var expectedOutput = "1,4,West";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
