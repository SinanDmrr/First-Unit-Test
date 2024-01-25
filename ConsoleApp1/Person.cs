using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private int age;
        private List<Person> personList = new List<Person>();
        public List<Person> PersonList
        {
            get { return personList; }
        }

        public void CreateNewPerson()
        {
            Console.WriteLine("Please give me the following information to the Person");
            Console.Write("NAME: ");
            name = Console.ReadLine();
            Console.Write("AGE: ");
            age = Convert.ToInt32(Console.ReadLine());
            AddPersonToList(name, age);
            Console.WriteLine("Person added successfully!");
        }

        public void CreateNewPerson(string name, int age)
        {
            AddPersonToList(name, age);
            Console.WriteLine("Person added successfully!");
        }

        private void AddPersonToList(string name, int age)
        {
            Person newPerson = new Person { Name = name, Age = age };
            personList.Add(newPerson);
        }

        public bool IsListEmpty()
        {            
            return personList.Count == 0;
        } 

        public void Greetings()
        {
            if (IsListEmpty())
            {
                Console.WriteLine("Please Add first a Person into the List");
            }
            else
            {
                Console.WriteLine("Which Person do you want to greet?");
                int i = 0;
                foreach (Person person in personList)
                {
                    Console.WriteLine($"{i} {person.Name}");
                    i++;
                }
                Console.Write("Person Index: ");
                int indexOfPerson = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Hello {personList[indexOfPerson].Name}, nice to meet you!");
            }            
        }

        //Getter Setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
