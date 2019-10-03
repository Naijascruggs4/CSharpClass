using System;

/* This is another lab for Lesson 12 Example  
of Inheritance */
namespace CSharpClass
{
    public class CarStereo : Radio  
    {
        string _bluetooth;
        string _satellite;

        public void MP3Capability()
        {

        }

        public override void RadioPlaysMusic()
        {
            Console.WriteLine("Car Stereo plays music");

        }

    } // end class
} // end namespace