using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephonebook.Library;

namespace Telephonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneBook book = new TelephoneBook();

            List<Person> book2 = book.SortByLastName();
            book2.ForEach(b => Console.WriteLine(b.fullname));
            Console.WriteLine();
            List<Person> book3 = book.GetByLetter('d');
            book3.ForEach(b => Console.WriteLine(b.fullname));
            Console.WriteLine();
            List<Person> book4 = book.GetGreaterThenInt(6);
            book4.ForEach(b => Console.WriteLine(b.fullname));
            Console.WriteLine();
            List<Person> book5 = book.SortByLength();
            book5.ForEach(b => Console.WriteLine(b.fullname));
            Console.WriteLine();
            int number = book.GetLength();
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
