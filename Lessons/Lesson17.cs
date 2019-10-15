using System;

/* This class goes over the Lesson 17 content
Delegates, Events & Lambdas */
namespace CSharpClass.Lessons
{
    public class Lesson17
    {
        public string HatType {get; private set;}
        public int HatSize {get; private set;}
        public string MyResult{get; private set;}

        public delegate void TryOnAnotherHat(string type);
        public delegate string TryFavoriteHat(string fav);
        delegate int del(int beta);
        public event TryFavoriteHat MyEventHat;

        private string _prop;
        public string MyProperty
        {
            //(parameters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;
        } // end method my property
         
        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryALargerHat("fadora", 7, otherHat); 
        }

        public Lesson17(string type, int size)
        {
            HatType = type;
            HatSize = size;
        } // end method Lesson 17

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoriteHat(this.MyFavoriteHat);
            MyResult = MyEventHat(type);
        } // end method lesson 17

        public string MyFavoriteHat(string message)
        {
            return "My favorite hat is " + message;
        } // end method my favorite hat

        public void TryALargerHat(string type, int oldSize, TryOnAnotherHat another)
        {
            another("I tried on a " + type + " hat at size "+ (++oldSize));
        } // end method try larger hat
        
        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        } // end method try on hat

        public int MyLambdaExample(int value)
        {
            // (parameters) => expression or statement-block
            del myDelegate= x => x * x;
            return myDelegate(value);
        }

    
    }   // end class
} // end namespace