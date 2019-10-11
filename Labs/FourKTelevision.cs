using System;

namespace CSharpClass.Labs
{
    public class FourKTelevision : Television
    {
         public override void TurnOn()
        {
            Console.WriteLine("turn on with smart app");
        }

        public FourKTelevision(int size, decimal price, int ports, 
        bool isMountable)
            :base (size, price, ports, isMountable)
           {  }

        public FourKTelevision (int size, decimal price)
            : this(size, price, 4, false)
           {  } 
    }
}