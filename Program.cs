using System;
using CSharpClass.Lessons;

namespace CSharpClass
{
    /*This class is the start of my application 
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("Hello World!");
           //MyLesson5Examples();
           //MyLesson6Examples();
           //MyLessonSevenExamples();
           //MyExample1();
           //MyLesson8Examples();
           MyOtherLesson8Examples();
        } // End Method Main

        static void MyOtherLesson8Examples()
        {
            Lesson8 myLesson8 = new Lesson8();
            myLesson8.BasicWhileLoop();
            myLesson8.BasicDoWhileLoopExample();
            myLesson8.BasicForLoopExample(9);
            myLesson8.BasicForEachLoopExample();
            Console.WriteLine(myLesson8.BasicJumpStatementExample("Sunday"));
            myLesson8.BasicOtherJumpStatements();

        } // end method my other lesson 8 examples

        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseChainExample();
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrConditionExample(24));
            myEight.BasicTernaryExample(42);
            myEight.BasicSwitchExample(7);

        } // end method my lesson 8 examples

        static void MyLessonSevenExamples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXORAssignmentOperator();
            mySeven.MyIncrementDecrementExample();
        } // end my lesson 7 examples

        static void MyLesson6Examples()
        {
             Lesson6 mySix = new Lesson6();
             mySix.MyTrimExample();
             mySix.MyEqualsExample();
             mySix.MyLowerUpperExample();
             mySix.MyStringLength();
             string myJoined = mySix.MyJoinedStrings("Happy", " Coding");
             Console.WriteLine(myJoined);
             string myFav = mySix.MyStringBuilder("tacos", 3);
             Console.WriteLine(myFav);
             mySix.MyExampleChar();
             mySix.MyEscapeExample();
             mySix.MyPlaceHolderExample("Injustice", "fight to the death game");
                
        } // end my lesson 6 examples

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();

        } // end method my lesson 5 examples

        static void MyExample1()
        {
            Example1 exam1 = new Example1();
            exam1.MyByteExample();
            exam1.MyByteExample2();
            exam1.MyByteExample3();
            exam1.MyByteExample4();
            exam1.MyByteExample5();
            exam1.MyByteExample6();
            exam1.MyByteExample7();
            exam1.MyByteExample8();
            exam1.MyByteExample9();
        }   

    } // End class
} // end namespace
