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
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int radius = 1;
            bool valid;
            int input;

            // Startup request radius from user
            do
            {
                try
                {
                    // Get the radius of the circle from the user
                    Console.WriteLine("Please enter the radius of the circle (Integer > 0): ");
                    radius = Convert.ToInt32(Console.ReadLine());

                    if (radius < 1)
                    {
                        // Set valid to false, clear the screen, display an error
                        valid = false;
                        Console.Clear();
                        Console.WriteLine("Error! Radius must be an integer greater than 0");
                    }
                    else
                    {
                        // Set valid to true and clear the screen
                        valid = true;
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    // Set valid to false, clear the screen, display the error
                    valid = false;
                    Console.Clear();
                    Console.WriteLine($"Error! Radius must be an integer");
                }
                catch (Exception ex)
                {
                    // Set valid to false, clear the screen, display the error
                    valid = false;
                    Console.Clear();
                    Console.WriteLine($"Error! Exception handled in input: {ex}");
                }
            } while (valid == false);

            // Create a circle object with the given input
            Circle circle = new Circle(radius);

            // Display menu
            while (true)
            {
                try
                {
                    // Display options and request input
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < 1 || input > 5)
                    {
                        // Set valid to false, clear the screen, and display the error
                        valid = false;
                        Console.Clear();
                        Console.WriteLine("Error! Input must be 1, 2, 3, 4, or 5, please try again");
                    }
                    else
                    {
                        // Clear the screen
                        Console.Clear();

                        // Get the radius of the circle
                        if (input == 1)
                        {
                            Console.WriteLine($"Radius: {circle.GetRadius()}");
                        }

                        // Change the radius of the circle
                        if (input == 2)
                        {
                            do
                            {
                                try
                                {
                                    // Get the radius of the circle from the user
                                    Console.WriteLine("Please enter the radius of the circle (Integer > 0): ");
                                    radius = Convert.ToInt32(Console.ReadLine());

                                    if (radius < 1)
                                    {
                                        // Set valid to false, clear the screen, display an error
                                        valid = false;
                                        Console.Clear();
                                        Console.WriteLine("Error! Radius must be an integer greater than 0");
                                    }
                                    else
                                    {
                                        // Set valid to true and set the radius
                                        valid = true;
                                        circle.SetRadius(radius);
                                        Console.WriteLine($"Radius changed to {radius}");
                                    }
                                }
                                catch (FormatException)
                                {
                                    // Set valid to false, clear the screen, display the error
                                    valid = false;
                                    Console.Clear();
                                    Console.WriteLine($"Error! Radius must be an integer");
                                }
                                catch (Exception ex)
                                {
                                    // Set valid to false, clear the screen, display the error
                                    valid = false;
                                    Console.Clear();
                                    Console.WriteLine($"Error! Exception handled in input: {ex}");
                                }
                            } while (valid == false);
                        }

                        // Get the circumference of the circle
                        if (input == 3)
                        {
                            Console.WriteLine($"Circumference of circle with radius {radius}: {circle.GetCircumference()}");
                        }

                        // Get the area of the circle
                        if (input == 4)
                        {
                            Console.WriteLine($"Area of circle with radius {radius}: {circle.GetArea()}");
                        }

                        // Exit the application
                        if (input == 5)
                        {
                            Environment.Exit(0);
                        }

                        // Wait for the user to continue, clear the screen
                        Console.WriteLine("Press enter to return to the menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    // Set valid to false, clear the screen, and display the error
                    valid = false;
                    Console.Clear();
                    Console.WriteLine($"Error! Input must be an integer");
                }
                catch (Exception ex)
                {
                    // Set valid to false, clear the screen, and display the error
                    valid = false;
                    Console.Clear();
                    Console.WriteLine($"Error! Exception handled in input: {ex}");
                }
            }
        }
    }
}
