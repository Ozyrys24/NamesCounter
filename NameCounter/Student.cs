using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameCounter
{
    class Student
    {
        string name;
        public int count { get; set; }
        public static int CountAll { get; set; }

        public Student(string name, string file)
        {
            this.name = name;
            count = counter(name, file);
            CountAll = CountAll + count;
        }

        private int counter(string name, string file)
        {
            string pattern = "<div class=\"_3-96 _2pio _2lek _2lel\">" + name + "</div>";
            int count = Regex.Matches(file, pattern).Count;
            return count;
        }

        public void show()
        {
            Console.WriteLine("{0,-40} {1,1}", name + ": " + count + " wiadomości", ((float)count / CountAll) * 100 + "%");
        }
    }
}
