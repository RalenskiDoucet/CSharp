using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Experince { get; set; }

        Dictionary<string, Character> Stats = new Dictionary<string, Character>();

    }
    public class Stat
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int newStat;
        public static explicit operator Stat(int i)
        {
            Stat temp = new Stat();
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)

        {

        }

    }
}
