using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace NameCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of names students on the chat
            string[] names = { /* Nicks list*/};
            List<Student> students = new List<Student>()
            
            //HTML file with all chat messages
            string wseiHTML = new File().FileReader();

            foreach (string name in names)
            {
                students.Add(new Student(name, wseiHTML));
            }

            students = students.OrderBy(x => x.count).Reverse().ToList();

            //Show section

            Console.WriteLine("Statystyki aktywności na czacie WSEI Kraków 2018-2019 Informatyka-Ekonometria 1 Rok");

            foreach (Student student in students)
            {
                student.show();
            }

            Console.WriteLine("Łącznie zostało wysłanych " + Student.CountAll + " wiadomości");

            //string[] namesL = { "Maciej Bandyk", "Aureliusz Wala", "Kajetan Wiśniewski", "Karol Makowski", "Piotrek Nawrocki", "Kolorowy Romek", "Justyna Wieczorek", "Arek Żołnierczyk", "Przemysław Sakowski", "Artur Teodorowicz", "Bartosz Kwaczyński", "Grzesiek Ociepka", "Maciek Lizak", "Szkodny Jakub", "Natalia Kr", "Błażej Szosta", "Jarek Wandas", "Bartek Ptak", "Kacper Gadula", "Damian Lasoń", "Kamil Chrzanowski", "Damian Świerczek", "Mateusz Kosowski" };

            //foreach (Student student in students)
            //{
            //    foreach (string name in namesL)
            //    {
            //        if (student.name.Equals(name))
            //        {
            //            student.show();
            //        }
            //    }
            //}

         Console.ReadKey();


        }
    }





}
