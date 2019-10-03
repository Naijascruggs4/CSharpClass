using System;

/* This struct is part of lesson 11 */
namespace CSharpClass.Lessons
{
    public class Lesson11Struct
    {
        private decimal _price;
        private string _author;
        private string _title;
        public Lesson11Struct(decimal price, string author, string title)
        {
            _price = price;
            _author = author;
            _title = title;

            Console.WriteLine("This title {0} from {1} costs ${2}",
            title, author, price);

        } // end lesson 11 struct
        
    } // end struct
} // end namespace