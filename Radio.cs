using System;

/* This is another lab for Lesson 12 Example  
of Inheritance */
namespace CSharpClass
{
    public class Radio
    {
        int _speakers;
        string _dials;
        string _antenna; 

        public virtual void RadioPlaysMusic()
        {
            Console.WriteLine("Radio Plays Music");
        } // end radio plays music

        public void PlaysMusic(string RadioPlaysMusic)
        {

        }

    } //end class
} // end namespace