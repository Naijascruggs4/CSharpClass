using System;

/* This class id a child class of house
Lesson 12 Inheritance */
namespace CSharpClass
{
    public class Condo : House
    {
        string _balcony;

        public string Balcony {get; set;}

        public Condo()
            :this("second floor")
        {
            
        }

        public Condo(string balcony)
            :base(32, "concrete")
        {
            Balcony = balcony;
        }

        public void maintenance() { base.DoorOpenClose(); }
        
        public override void DoorOpenClose()
        {
            base.DoorOpenClose();
            Console.WriteLine("This condo door is closed");

        }

    } // end class
} // end namespace