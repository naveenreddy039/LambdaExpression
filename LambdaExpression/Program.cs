using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);

            Retriving_topTwoRecord_ForAgeIs_LessThanThirty(listPersonsInCity);
            CheckingForTeenAgePerson(listPersonsInCity);
            AllPersonsAverageAge(listPersonsInCity);

        }
        //#UC1
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("235648956","naveen", "banglore",24));
            listPersonsInCity.Add(new Person("253698470","narasimha", "hyderabad",32));
            listPersonsInCity.Add(new Person("023156897","ravi", "pune",39 ));
            listPersonsInCity.Add(new Person("123569874","radha", "mumbai", 28));
            
         
         }
            //#UC2
        private static void Retriving_topTwoRecord_ForAgeIs_LessThanThirty(List<Person> listPersonsInCity)
        {
            foreach(Person person in listPersonsInCity.FindAll(e=>(e.Age<30)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
        }
            //#UC3
        private static void CheckingForTeenAgePerson(List<Person> listPersonsInCity)
        {
            if(listPersonsInCity.Any(e=>(e.Age>=18 && e.Age<=25)))
            {
                Console.WriteLine("yes wehave some teen age person in list");
            }
        }
            //#UC4
        private static void AllPersonsAverageAge(List<Person> listPersonsInCity)
        {
            double avgAge = listPersonsInCity.Average(e => e.Age);
            Console.WriteLine("the average of all the persons age is:" + avgAge);
        }
            //#UC5
        private static void CheckNameExistOrNot(List<Person> listPersonsInCity)
        {
            if(listPersonsInCity.Exists(e=>e.Name=="naveen"))
            {
                Console.WriteLine("Yes naveen name exists");
            }
        }

    }
}
