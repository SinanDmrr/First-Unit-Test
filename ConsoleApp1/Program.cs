using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            bool isListEmptyBefore = person1.IsListEmpty();
            Console.WriteLine($"List is empty : {isListEmptyBefore}");
            Console.WriteLine();

            person1.Greetings();
            Console.WriteLine();

            bool addNewPerson = true;

            while(addNewPerson)
            {
                person1.CreateNewPerson();
                Console.WriteLine("Do you want to Create another Person?");
                Console.Write("NO = 0 || YES = 1 ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == 0 )
                {
                    addNewPerson = false;
                }
                else
                {
                    addNewPerson = true;
                }
                Console.WriteLine();
            }
            

            bool isListEmptyAfter = person1.IsListEmpty();            
            Console.WriteLine($"List is empty after: {isListEmptyAfter}");

            person1.Greetings();
        }
    }
}
