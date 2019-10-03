using System; 

/* This is lab for Lesson 12 
giving an example of inheratence */
namespace CSharpClass
{
    public class Shoes
    {
        int _plasticEyelets;
        string _laces;
        string _eyelets;
        string _soles;


        public virtual void ShoesWorn()
        {
            Console.WriteLine("Shoes are worn");
        } // end shoes worn

        public void ShoesWorn(string Shoesworn)
        {
                
        }


    } // end class
} // end namespace