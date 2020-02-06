// Created By: David Lutz
// Date Created: February 5, 2020
// Revision History
//  -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign1
{
    public class Circle
    {
        // Variables
        private int radius;

        #region Constructors
        // Default
        public Circle()
        {
            this.radius = 1;
        }

        // Radius
        public Circle(int radius)
        {
            this.radius = radius;
        }
        #endregion

        #region Methods
        // Get the radius of the circle
        public int GetRadius()
        {
            return radius;
        }

        // Change the radius of the circle
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        // Return the circumference of the circle
        public double GetCircumference()
        {
            return Math.Round(2 * Math.PI * radius, 4);
        }

        // Return the area of the circle
        public double GetArea()
        {
            return Math.Round(Math.PI * (radius * radius), 4);
        }
        #endregion
    }
}
