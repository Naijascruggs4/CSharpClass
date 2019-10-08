using System;

/* This method is for the Lab assignment 
Problem 1 */
namespace CSharpClass.Labs
{
    public class Lab2
    {
        public void GradeCheck(char grade)
        {
            switch (grade)
            {
                case 'e':
                    Console.WriteLine("e is Excellent");
                    break;
                case 'v':
                    Console.WriteLine("v is Very good ");
                    break;
                case 'g':
                    Console.WriteLine("g is Good");
                    break;
                case 'a':
                    Console.WriteLine("a is Average");
                    break;
                case 'f':
                    Console.WriteLine("f is Fail");
                    break;
                default:
                    Console.WriteLine("Not a valid grade");
                    break;
            } // end switch grade
        } // end grade check char grade

    } // end class
} // end namespace