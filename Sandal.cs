using System;

/* This is lab for Lesson 12 
giving an example of inheratence */
namespace CSharpClass
{
    public class Sandal : Shoes
    {
       string _straps; 

       public string Straps
       {
           get {return _straps;}
           set {_straps = value;}
       }

        public void protects()
        {
        
        } // end sandal protects

        public override void ShoesWorn()
        {
            Console.WriteLine("The Sandal is Worn");
        }


    } // end class
} // end namespace