using System;

namespace OOPUppgift_1
{
    class Person{
        public string Firstname;
        public string Lastname;
        public int Age;
        public string Summary(){
            return Firstname + " " + Lastname + " är " + Age + " år gammal.";
        }
    }
    class Uppgift1{
        static void Main(string[] args){
            Console.Write("Firstname:");
            string Firstname = Console.ReadLine();
            Console.Write("Lastname:");
            string Lastname = Console.ReadLine();
            Console.Write("Age:");
            int Age = Convert.ToInt32(Console.ReadLine());

            Person p = new Person{
                Firstname = Firstname,
                Lastname = Lastname,
                Age = Age
            };
            Console.WriteLine(p.Summary());
        }

    }
}
