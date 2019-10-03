using System;

/* This class id a child class of house
Lesson 12 Inheritance */
namespace CSharpClass
{
    public class Condo : House
    {
        string _balcony;

        public void maintenance()
        {
            
        }

        public override void DoorOpenClose()
        {
            Console.WriteLine("This condo door is closed");

        }

    } // end class
} // end namespace