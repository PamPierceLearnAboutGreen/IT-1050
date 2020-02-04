using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Listing
{
    class Listing
    {
        private string name = "";
        private int age = 0;

        public Listing()
        {
            input();
            printNameAge();
            name = "";
            inputName("Please enter your name: ");
            age = 0;
            inputAge("Please enter your age (a number):");
            printNameAge();
        }
        public Listing(String personName, int personAge)
        {
            setName(personName);
            setAge(personAge);
        }
        public String toString()
        {
            return null;
        }
        public void input()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Please enter your age (a number): ");
                String personAge = Console.ReadLine();
                int.TryParse(personAge, out age);
            } while (age == 0);
        }
        public void inputName(String message)
        {
            Console.Write(message);
            name = Console.ReadLine();
        }
        public void inputAge(String message)
        {
            do
            {
                Console.Write(message);
                String personAge = Console.ReadLine();
                int.TryParse(personAge, out age);
            } while (age == 0);
        }
        public void setName(String personName)
        {
            name = personName;
        }
        public void setAge(string personAge)
        {
            int.TryParse(personAge, out age);
        }
        public void setAge(int personAge)
        {
            age = personAge;
        }
        public String getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public void printNameAge()
        {
            Console.WriteLine($"Thank you, {name}, your age is {age}");
        }
     }
}
