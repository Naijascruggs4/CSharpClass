using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* This class goes over lesson 16 content 
Collections & LINQ */
namespace CSharpClass.Lessons
{
    public class Lesson16
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add(42);
            myList.Add(true);
            myList.Add('T');
            PrintValues(myList);

        } // end method my array list examples 

        private void PrintValues(IEnumerable myListing)
        {
            foreach (object item in myListing)
            {
                Console.WriteLine("values: {0}", item);
            } // end method for each
        } // end method print values

        public void MyHashTableExamples()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add(10, "CSharp");
            myHash.Add(20, 24);
            myHash.Add(30, "Rocks");
            myHash.Add(40, 'J');

            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                item.Key, item.Value);
            } // end method for each
        } // end method my hash table examples

        public void MyListExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Alpha");
            myList.Add("Bravo");
            myList.Add("Charlie");
            myList.Add("Delta");
            myList.Add("Echo");
            myList.Add("Foxtrot");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            } // end method for each

        } // end  method my list example

        public void MyOtherList()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(24, "Concrete"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(36, "Brick", "Shingle", "red"));

            foreach (House item in myHouseList)
            {
                Console.WriteLine(item.DoorColor + " , " + item.RoofType);
            } // end method for each
        } // end method my other list

        public void MyDictionaryExample()
        {
            Dictionary<int, string> myList = new Dictionary<int, string>();
            myList.Add(10, "CSharp");
            myList.Add(20, "Rocks");
            myList.Add(30, "Happy");
            myList.Add(40, "Friday");

            // to get a single value we use the TryGetValue method
            string temp = " ";
            if(myList.TryGetValue(20, out temp)) 
            {
                Console.WriteLine("Key 20 is {0}", temp);
            } // end method try get value
            foreach (KeyValuePair<int, string> item in myList)
            {
                Console.WriteLine("key: {0}, Value: {1}",
                item.Key, item.Value);
            }

        } // end method my dictionary example

        public void MyLinqExample()
        {
            int[] scores = new int[] {97,92,88,60,55,40,20};

            IEnumerable<int> query = from score in scores
            where score < 85
            select score;

            foreach (int item in query)
            {
                Console.WriteLine(item);
            } // end method for each
        } // end method my linq examples 

        public void MyOtherLinq()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(23, "Concrete"));
            myHouseList.Add(new House(24,"steel","plastic", "red"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(32, "wood", "wood", "blue"));

            var subset = from theHouse in myHouseList
            where theHouse.RoofType == "shingle"
            orderby theHouse.DoorColor
            select theHouse;

            foreach (House item in subset)
            {
                Console.WriteLine("My house has a {0} roof", item.RoofType);
            } // end method for each
        } // end method my other linq
    } // end class
} // end namespace