using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitDemonstration2;

namespace TestClass

{
    [TestFixture]
    public class TriangleTest1
    {
        // Mohan Test
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";

            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}