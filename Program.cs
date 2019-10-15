using System;
using CSharpClass.Lessons;
using CSharpClass.Labs;
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
           //MyOtherLesson8Examples();
           //MyLesson9Examples();
           //MyLesson10Examples();
           //MyLesson11Examples();
           //MyBeerSong();
           //MyLesson12Examples();
           //MyOtherlesson12Examples();
           //MyOtherlesson12Examples2(); 
           //MyLabExample();
           //MyLabsExample(); 
           //MyLesson13House();
           //MyLesson14Examples();
           //MyLesson15Examples();
           //MyLesson16Examples();
            //MyHDTelevision();
            //MyFourKTelevision();
            //MyLesson17Examples();
            MyDogLab();
        } // End Method Main

        static void MyDogLab()
        {
            DogLab myDogLab = new DogLab();
            myDogLab.SmallDogToHumanYears();
            
        }// end method my dog lab

        public delegate void TryOn(string val);

        static void MyLesson17Examples()
        {
            Lesson17 my17 = new Lesson17("Cowboy", 7);
            TryOn theHat = my17.TryOnHat;
            theHat("I tried on a " + my17.HatType + " hat that was size " +
            my17.HatSize);

            Lesson17 myLesson17 = new Lesson17();

            Lesson17 myFav17 = new Lesson17("Trucker");
            Console.WriteLine(myFav17.MyResult);
            Console.WriteLine(myFav17.MyLambdaExample(6));
        } // end method my lesson 17 examples

        static void MyHDTelevision()
        { 
            HDTelevision myTv = new HDTelevision(4, 525m);
            myTv.TurnOn(); 
        }// end method my hd television

        static void MyFourKTelevision()
        {
            FourKTelevision myTv = new FourKTelevision(2, 175m);
            myTv.TurnOn();
        } // end method my four k television

        static void MyLesson16Examples()
        {
            Lesson16 my16 = new Lesson16();
            my16.MyArrayListExample();
            my16.MyHashTableExamples();
            my16.MyListExample();
            my16.MyOtherList();
            my16.MyDictionaryExample();
            my16.MyLinqExample();
            my16.MyOtherLinq();
        } // end method my lesson 16 examples

        static void MyLesson15Examples()
        {
            Lesson15 my15 = new Lesson15();
            my15.CheckExternalEnum();
            my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.Chocolate);

            my15[2] = 17;
            for (int i = 0; i < my15.ConeArrayLength; i++)
            {
                Console.WriteLine("Value of {0} = {1}", i, my15[i]);
            }
            
        } // end my lesson 15 examples

        static void MyLesson14Examples()
        {
            Lesson14Static.CelsiustoFahrenheit("34.5");
            Lesson14Static.FahrenheittoCelsius("34.5");

            Lesson14Derived myLesson14 = new Lesson14Derived(9);
            myLesson14.ShowResultsFeet();
            myLesson14.ShowResultMiles();

        } // end my method my lesson 14 examples

        static void MyLesson13House()
        {
            House myHouse = new House(36, "granite");
            Console.WriteLine(myHouse.DoorColor);
            myHouse.RoofType = "Steel";
            myHouse.DoorOpenClose();

        } // end my lesson 13 house

        static void MyLabsExample()
        {
            Horse myHorse = new Horse();
            myHorse.Racing();

            Pony myPony = new Pony();
            myPony.Racing();

            Numbers mySubtraction = new Numbers();
            mySubtraction.CountingThrees();



        } // end my ledsson 13 house

        static void MyLabExample()
        {
            Lab2 myLabs = new Lab2();
            myLabs.GradeCheck('e');
        }

        static void MyOtherlesson12Examples2()
        {
            Radio myRadio = new Radio();
            myRadio.RadioPlaysMusic();

            CarStereo myCarstereo = new CarStereo();
            myCarstereo.RadioPlaysMusic();
        } // end my other lesson 12 examples 2

        static void MyOtherlesson12Examples()
        {
            Shoes myShoes = new Shoes();
            myShoes.ShoesWorn();

            Sandal mySandal = new Sandal();
            mySandal.ShoesWorn();

        } // end my other lesson 12 examples

        static void MyLesson12Examples()
        {
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();


            House myHouse = new Condo();
            myHouse.DoorOpenClose();

        } // end my lesson 12 examples

        static void MyBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        } // end my beer song

        static void MyLesson11Examples()
        {
            Lesson11 myEleven =  new Lesson11("Happy", 24);
            Lesson11 myOtherEleven = new Lesson11(23);
            Lesson11 myLesson11 = new Lesson11();

            Lesson11Struct myStruct = new Lesson11Struct(9.99m, "king", "The Stand");
            int myValue = 14;
            myEleven.MyBasicRefExample(ref myValue);
            Console.WriteLine(myValue +" from program");

            string first, last;
            myLesson11.MyBasicOutExample("Prosperity Raimey", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);

        } // end method my lesson 11 examples

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; // can see because its internal
        } // end method my lesson 10 examples

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArraySample();
            myNine.My3DArrayExample();
            myNine.MyJaggedArrayExample();
        } // end method my lesson 9 examples

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
