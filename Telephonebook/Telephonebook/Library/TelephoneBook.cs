using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephonebook.Library
{
    class TelephoneBook
    {
        List<Person> entries;

        public TelephoneBook()
        {
            entries = new List<Person>();
            Person person1 = new Person("Sjaak", "de Bomb", 0644877422);            entries.Add(person1);
            Person person2 = new Person("Henk", "de Verweggistaanse", 0694847492);  entries.Add(person2);
            Person person3 = new Person("Zorashad", "the Core", 0616161616);        entries.Add(person3);
            Person person4 = new Person("Geert", "Wilders", 068376928);             entries.Add(person4);
            Person person5 = new Person("Bart", "Bus", 06997439);                   entries.Add(person5);
            Person person6 = new Person("Klaas", "Vaak", 06165374);                 entries.Add(person6);
            Person person7 = new Person("Steff", "de Goey", 08348796);              entries.Add(person7);
            Person person8 = new Person("Yannick", "van den Iets", 08845772);       entries.Add(person8);
            Person person9 = new Person("Maurits", "van Leeuwen", 0204950);        entries.Add(person9);
            Person person10 = new Person("Kasper", "van Leijenhorst", 050347530);  entries.Add(person10);
        }

        public List<Person> SortByLastName()
        {
            return entries.OrderBy(e => e.lastName).ToList();
        }

        public List<Person> GetByLetter(char c)
        {
            return entries.Where(e => e.lastName.StartsWith(c.ToString())).ToList();
        }

        public List<Person> GetGreaterThenInt(int i)
        {
            return entries.Where(e => i < e.lastName.Length).ToList();
        }

        public List<Person> SortByLength()
        {
            return entries.OrderBy(e => e.lastName.Length).ToList();
        }

        public int GetLength()
        {
            return entries.Count(e => true);
        }

    }
}
