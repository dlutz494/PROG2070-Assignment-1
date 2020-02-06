// Created By: David Lutz
// Date Created: February 5, 2020
// Revision History
//  -

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void GetRadius_RadiusIs5_ResultIs5() 
        {
            // Arrange
            Circle circle = new Circle(5);
            int result;

            // Act
            result = circle.GetRadius();

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void SetRadius_1ChangedTo5_ResultIs5()
        {
            // Arrange
            int radius = 5;
            Circle circle = new Circle(1);

            // Act
            circle.SetRadius(radius);

            // Assert
            Assert.AreEqual(5, circle.GetRadius());
        }

        [Test]
        public void GetCircumference_RadiusIs2_ResultIs12Double()
        {
            // Arrange
            int radius = 2;
            Circle circle = new Circle(radius);
            double result;

            // Act
            result = circle.GetCircumference();

            // Assert
            Assert.AreEqual(12.5664, result);
        }

        [Test]
        public void GetArea_RadiusIs2_ResultIs12Double()
        {
            // Arrange
            int radius = 2;
            Circle circle = new Circle(radius);
            double result;

            // Act
            result = circle.GetArea();

            // Assert
            Assert.AreEqual(12.5664, result);
        }
    }
}
