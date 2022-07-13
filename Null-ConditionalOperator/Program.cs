using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=eOpmjGF4qxo
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
            {
                Name = "Abe",
                Partner = new Person
                {
                    Name = "Abe2"
                },
                Hobbies = new[] {"Cooking", "Flying", "Doing stuff"}
            };

            if (string.IsNullOrWhiteSpace(person?.Partner?.Name))
            {
                Console.WriteLine(person?.Partner?.Name == null); // result is bool
                Console.WriteLine("A person has no name.");
            }

            Console.WriteLine(person?.Name); // if person is null then it will be
                                             // skipped
            Console.WriteLine(person?.Partner.Name);
            Console.WriteLine(string.Join(", ", person?.Hobbies));
            Console.WriteLine();
            Console.WriteLine("Best hobby: " + person?.Hobbies?[0]);
        }
    }
}