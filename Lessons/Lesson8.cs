using System;

namespace CSharpClass.Lessons
{
    /*This class goes over content for Lesson 8
    Control Flow Statements */
    public class Lesson8
    {
        // Basic If Statement
        public void BasicIfStatement()
        {
            int value = 17;
            Console.WriteLine("Before if Statement");
            if (value > 15)
            {
                Console.WriteLine("Statement was valid");
            } // end if
            Console.WriteLine("After if Statement");
        } // end method basic statement   

        // Basic if/else Statement
        public void BasicIfElseExample()
        {
            int value = 12;
            Console.WriteLine("Before if statement");
            if (value >= 15)
            {
                Console.WriteLine("Statement was valid");
            }  // end if
            else
            {
                Console.WriteLine("Statement was not valid");
            } //end else
            Console.WriteLine("After if else statement");
        } // end method basic if else example

        // Basic if else chain
        public void BasicIfElseChainExample()
        {
            int value = 18;
            Console.WriteLine("Before if");
            if (value == 15)
            {

            } // end if
            else if (value == 18)
            {
                Console.WriteLine("Statement was valid 18");
            } // end else if
            else
            {
                Console.WriteLine("Statement was valid");
            }
            Console.WriteLine("After if else chain");
        } // end method basic if else chain example

        // this method uses the && operator
        public string BasicAndConditionExample()
        {
            int value = 18;
            Console.WriteLine("Before if statement");
            if (value > 15 && value < 30)
            {
                return "Statement was valid";
            } // end if
            else
            {
                return "Statement was not valid";
            }
        } // end basic and conditon example 

        // This method uses ||(OR) operator'
        public int BasicOrConditionExample(int able)
        {
            Console.Write("Before If statement");
            if (able == 12 || able > 13)
            {
                return able;
            } // end if
            else
            {
                return 0;
            } // end else 
        } // end method basic or condition example

        // this method shows a shortcut if statement called the tenary operator
        public void BasicTernaryExample(int beta)
        {
            string valid = beta > 30 ? "valid" : "not valid";
            Console.WriteLine(valid);
        } // end method basic tenary operator example 

        // This method shows basic switch statement
        public void BasicSwitchExample(int charlie)
        {
            switch (charlie)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 or 2 was chosen");
                    break;
                case 3:
                    Console.WriteLine("3 was chosen");
                    break;
                case 4:
                    Console.WriteLine("4 was chosen");
                    break;
                case 5:
                    Console.WriteLine("5 was chosen");
                    break;
                default:
                    Console.WriteLine("The number greater than 5");
                    break;

            } // end switch

        } // end method basic switch example

        // This method shows a basic while loop
        public void BasicWhileLoop()
        {
            int value = 0;
            while (value < 15)
            {
                Console.WriteLine("number = {0}", value);
                value++;
            } // end while
        } // end method basic while loop

        // Basic do while loop
        public void BasicDoWhileLoopExample()
        {
            int value = 0;
            do
            {
                Console.WriteLine("Do While Number = {0}", value);
                value++;
            } while (value < 12);

        } // end method basic do while loop example

        // This method shows a basic loop
        public void BasicForLoopExample(int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("For Number = {0}", i);

            } // end for
        } // end basic for loop example

        // This method shows a foreach loop
        public void BasicForEachLoopExample()
        {
            foreach (char ch in "something")
            {
                Console.WriteLine(ch);

            } // end foreach
        } // end method basic foreach loop example

        // This method shows different jump statements
        public string BasicJumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tuesday":
                    return "Test something monday or tuesday";
                default:
                    return "Test Nothing";
            }
        } // end method basic jump example

        // This method shows other jump statements
        public void BasicOtherJumpStatements()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 2)
                {
                    continue;
                } // end if 
                if (i == 4)
                {
                    Console.WriteLine("loop breaks");
                    break;
                } // end if
                Console.WriteLine(i);
            } // end for
            Console.WriteLine("End of Loop");
        } // end method basic jump statements
        
    } // end class
} // end namespace