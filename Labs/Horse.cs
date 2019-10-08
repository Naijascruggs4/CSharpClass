using System;

/* This method is for the Lab assignment 
Problem 1 */
namespace CSharpClass.Labs
{
    public class Horse
    {
        int _legs;
        //string _tail;
        //string _shortneck;
        string _largebody;

        public int Legs
        {
            get
            {
                return _legs;
            }
            set
            {
                _legs = value;
            }

        }

        public string LargeBody
        {
            get
            {
                return _largebody;
            }
            set
            {
                _largebody = value;
            }
        }

        public string ShortNeck { get; set; }

        public string Tail { get; set; }

        public virtual void Racing()
        {
            Console.WriteLine("Horse Goes Racing");
        } // end method racing

        public void Racing(string HorseGoesRacing)
        {

        }

    }
} // end class horse