using System;

/* This method is for the Lab assignment 
Problem 1 */
namespace CSharpClass.Labs
{
    public class Pony : Horse
    {
        string _shorthead;
        string _smallbody;

        public string ShortHead
        {
            get {return _shorthead;}
            set {_shorthead = value;}
        }

        public string SmallBody   
        {
            get {return _smallbody;}
            set {_smallbody = value;}
        }


        public void playful()
        {

        }

        public override void Racing()
        {
            Console.WriteLine("Pony Does Not Race");
        }
    } // end class pony horse
}
