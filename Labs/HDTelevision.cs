using System;

namespace CSharpClass.Labs
{
    public class HDTelevision : Television
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with remote");
        }

        public HDTelevision(int size, decimal price, int ports, 
        bool isMountable)
            :base (size, price, ports, isMountable)
           {  }

        public HDTelevision (int size, decimal price)
            : this(size, price, 4, false)
           {  } 
    }

}