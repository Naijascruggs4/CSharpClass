using System;

namespace CSharpClass
{
    /*This class demonstrates the basic object of House
     Lesson 4 - My Application Overview */
    public class House
    {
       int _windowSize;
       string _foundation;
       string _roofType;
       string _doorColor;


       public virtual void DoorOpenClose() 
       {
           Console.WriteLine("The door opens");
       } // end method door open close

        public void DoorOpenClose(string doorcolor)
        {
            
        }

    } // end class
} // end namespace