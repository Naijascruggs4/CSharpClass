using System;

namespace CSharpClass.Labs
{
    public class Numbers
    {
       public void CountingThrees()
       {
           for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine("For Number = {0}", i);
                if(i % 3 == 0)

                {
                    Console.WriteLine("For Number = {0}", i);
                }
            } // end for

    


       }
    }
}