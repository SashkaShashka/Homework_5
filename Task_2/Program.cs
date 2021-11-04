using System;

namespace Task_2
{
    class Program
    {
        
        static Person[] Inizialization()
        {
            Person[] people = new Person[]
            {
                new Person("Юрий","Андреев",new DateTime(1970,10,13)),
                new Person("Антон","Какакойтов",new DateTime(1998,08,12)),
                new Person("Артем","Андреевич",new DateTime(2002,01,13)),
                new Person("Юлия","Богатова",new DateTime(1996,10,02)),
                new Person("Акакий","Курочкин",new DateTime(1975,05,31)),
                new Person("Наталья","Андреева",new DateTime(1970,11,01)),
                new Person("Анна","Богатова",new DateTime(2010,10,21)),
                new Person("Ярослав","Головин",new DateTime(2000,12,10)),
                new Person("Александр","Андреев",new DateTime(1999,12,15)),
                new Person("Анна","Богатова",new DateTime(2000,10,11)),
            };
            return people;
        }
        static Person[] Sort(Person[] people)
        {
            Array.Sort(people);
            return people;
        }
        static Person[] ReverseSort(Person[] people)
        {
            Sort(people);
            Array.Reverse(people);
            return people;
        }
        static void PrintArray(Person[] people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            Person[] people1 = Inizialization();
            Person[] people2 = Inizialization();
            Console.WriteLine("Исходные данные: ");
            PrintArray(people1);
            Console.WriteLine("Результат прямой сортировки: ");
            PrintArray(Sort(people1));
            Console.WriteLine("Результат обратной сортировки: ");
            PrintArray(ReverseSort(people2));


        }
    }
}
