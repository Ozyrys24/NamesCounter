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
            string[] names = { "So Agni", "Jan Gajewski", "Martyna Tybur", "Radek Wąsowski", "Michał Mróz", "Marlena Homel", "Jeremiasz Dolny", "Jakub Firlej", "Leszek Bugaj", "Szymon Urbanik", "Adrian Kurek", "Maksymilian Różański", "Rafał Mazur", "Maciek Bafia", "Damian Pedrycz", "Bartłomiej Kuć", "Mateusz Kosowski", "Anna Mika", "Marcin Polak", "Mary Majewska", "Grzesiek Grabowski", "Gosia Stepaniak", "Wojtek Piętoń", "Bartek Kuźma", "Łukasz Łopata", "Kamil Brodziak", "Adam Kulasiak", "Konrad Słonczyński", "Mateusz Rychlicki", "Serdeczny Marcin", "Damian Świerczek", "Arek Bystrowicz", "Kamila Gruhlke", "Konrad Baran", "Grzegorz Kułaga", "Krzysztof Szczudło", "Monika Raab", "Kamil Pajor", "Grzesiek Chlipała", "Kuba Sosnowski", "Łukasz Palczewski", "Tomek Orpik", "Michał Sołtysik", "Krystian Warchoł", "Kamil Krupa", "Piotrek Majkrzak", "Konrad Sęk", "Dominik Kuc", "Bartek Kusek", "Bartosz Bartosz", "Wojciech Kolarski", "Dawid Popiołek", "Patryk Świdziński", "Lubor Bodzioch", "Michał Pastuła", "Kamil Chrzanowski", "Mariusz Kalarus", "Dawid Mikoś", "Tomasz Gaj", "Przemek Bartosz", "Filip Kosmala", "Arek Bujak", "Rafał Piechowicz", "Jarek Żak", "Arleta Bugajska", "Antoni Uranowski", "Kamil Hartabus", "Damian Lasoń", "Kacper Gadula", "Bartek Ptak", "Krzysiek Tobiasz", "Kuba Chaberka", "Szymon Ryczek", "Mikołaj Janiczek", "Bartek Sikora", "Grzegorz Sobociński", "Michał Jaracz", "Maciej Oleksy", "Wojtek Grdeń", "Waldemar Woźniak", "Jarek Wandas", "Piotr Szczypka", "Karol Niemiec", "Michał Inglot", "Piotr Balon", "Miłosz Tyralik", "Piotr Wikej", "Kania Bartłomiej", "Marcin Rozum", "Gabriel Jabłoński", "Jakub Święch", "Agnieszka Krupińska", "Kamil Rudek", "Jola Recka", "Krzysiek Pytel", "Radek Mysza", "Kamil Węgrzyn", "Łukasz Migas", "Jakub Morawczyński", "Maciej Bandyk", "Kamil Miłoś", "Maks Stępak", "Marcin Kęska", "Kamil Pióro", "Dominik Rak", "Grzesiek Sychta", "Bartek Ziembiński", "Błażej Szosta", "Natalia Kr", "Krzysztof Mrówczyński", "Miko Musialik", "Szkodny Jakub", "Jan Mistarz", "Adrian Zaczek", "Dominik Markiel", "Stanislaw Stacy Walkosz", "Maciek Lizak", "Adrian Skwarczyński", "Grzesiek Ociepka", "Wojciech Maślany", "Jacek Woźniak", "Bartosz Kwaczyński", "Arek Nowak", "Oskar Podgórski", "Patrycja Słabosz", "Krzysztof Ryś", "Alan Chrzanowski", "Andrzej Malinowski", "Patryk Pasek", "Karol Chlewiński", "Artur Teodorowicz", "Michał Droński", "Sebastian Imiołek", "Mateusz Hanzel", "Michał Manowita", "Michał Jędrzejek", "Adrian Wiorek", "Marcin Migdał", "Dominik Pyciak", "Maciej Furdyna", "Norbert Orczyk", "Sebastian Gądek", "Karol Pędracki", "Paweł Wójsik", "Sebastian Tyralski", "Jakub Ładyga", "Damian Brdej", "Mateusz Prokop", "Michał Kuczaj", "Dominik Zdziarski", "Sylwester Sztajner", "Mateusz Zdziarski", "Marcin Chołda", "Sebastian Machczyński", "Mateusz Strojek", "Artur Gorzelany", "Przemysław Sakowski", "Wiktor Adamczyk", "Kamil Kabat", "Konrad Ziębiński", "Katarzyna Łaciak", "Marcin Putniorz", "Igor Bereżan", "Aureliusz Wala", "Tomek Proszek", "Piotr Świniarski", "Paweł Majcherczyk", "Robert Karpierz", "Filip Kotelon", "Rafał Boruszewski", "Kuba Antosz", "Yaroslav Kuzmenko", "Piotr Pitułaj", "Piotrek Sułkowski", "Patryk Szlachta", "Mateusz Marzec", "Mateusz Tarnówka", "Patrycja Wiater", "Piotr Sumera", "Konrad Pilarski", "Arek Żołnierczyk", "Kubuś Dedio", "Radosław Adamowicz", "Grzegorz Brzeszcz", "Dawid Pocztowski", "Damian Pękala", "Adam Łochowski", "Olek Czubat", "Łukasz Kuciel", "Bartek Dzaba Woszczek", "Justyna Wieczorek", "Kacper Dudziak", "Natalia Machowska", "Kuba Sewilo", "Agnieszka Przybylowicz", "Kolorowy Romek", "Piotrek Nawrocki", "Olaf Wójcik", "Mariusz Szubryt", "Kamil Filipczyk", "Dawid Nosek", "Ania Szubert", "Dariusz Mrok", "Antoni Bruliński", "Grzegorz Kroteski", "Marcin Pokora", "Matti Matti", "Kajetan Wiśniewski", "Dawid Kolcz", "Kamil Chachurski", "Paweł Kukizowski", "Maciej Furman", "Michal Studiuje", "Paweł Niesułowski" };
            List<Student> students = new List<Student>();
            
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
