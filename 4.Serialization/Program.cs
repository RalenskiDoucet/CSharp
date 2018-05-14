using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _0._4Serialization;

namespace _0._4Serialization
{
    [Serializable]
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

    public class Stats
    {
        public List<Stat> stats;
        public Stats()
        {
            stats = new List<Stat>()
            {
            new Stat() {Name = "Health" },
            new Stat() {Name = "Dexterity" }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stats obj1 = new Stats();
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "stats.json");
            //var data = JsonConvert.SerializeObject(obj1);
            var textData = System.IO.File.ReadAllText(path);
            var newData = JsonConvert.DeserializeObject(textData);
            //System.IO.File.WriteAllText(path, data);
            Console.WriteLine(newData);
        }
    }
}

