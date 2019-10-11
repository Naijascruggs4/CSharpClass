using System;

/* This method is for the Lab assignment 
Problem 1 */
namespace CSharpClass.Labs
{
    public abstract class Television
    {
        public int Size { get; private set; }
        public decimal Price { get; private set; }
        public int Ports { get; private set; }
        public bool IsMountable { get; private set; }

        public Television(int size, decimal price, int ports,
        bool isMountable)
        {
            Size = size;
            Price = price;
            Ports = ports;
            IsMountable = isMountable;
        }

        public abstract void TurnOn();

    }




} // end namespace