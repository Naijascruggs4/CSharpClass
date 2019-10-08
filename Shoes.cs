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

        public int PlasticEyelets
        {
            get {return _plasticEyelets;}
            set {_plasticEyelets = value;}
        }

        public string Laces
        {
            get {return _laces;}
            set {_laces = value;}
        }

        public string Eyelets
        {
            get {return _eyelets;}
            set {_eyelets = value;}
        }
        public string Soles
        {
            get {return _soles;}
            set {_soles = value;}
        }

        public virtual void ShoesWorn()
        {
            Console.WriteLine("Shoes are worn");
        } // end shoes worn

        public void ShoesWorn(string Shoesworn)
        {
                
        }


        } // end class
    } // end namespace