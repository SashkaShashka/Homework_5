using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompareTo(object obj)
        {
            Person person = obj as Person;
            if (person == null)
                throw new ArgumentException("Элемент нельзя сравнить с объектом Person, потому что он не является объектом типа Person");
            int compare = Surname.CompareTo(person.Surname);
            if (compare != 0)
                return compare;
            compare = Name.CompareTo(person.Name);
            if (compare != 0)
                return compare;
            return BirthDate.CompareTo(person.BirthDate);
        }
        public Person(string name, string surname,DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Фамилия: " + Surname + "\t");
            stringBuilder.Append("Имя: " + Name + "\t");
            stringBuilder.Append(string.Format("{0:d}",BirthDate));
            return stringBuilder.ToString();
        }
    }
}
