using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    class Program
    {
        public class Person // class Person inside class Program????
        {
            public string Name { get; set; }
            public Person Partner { get; set; }
            public string[] Hobbies { get; set; }
        }
        static void Main(string[] args)
        {
            Person person = new Person
            { // object initialization syntax?
                Name = "Gerald" 
            };
            Console.WriteLine(person?.Name); // added null conditional operator
        }
    }
}