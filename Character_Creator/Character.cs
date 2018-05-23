using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Character
    {
        public string Name { get; set; }
        public List<IStat> Stats { get; set; }
        public IRace Race { get; set; }
        public override string ToString()
        {
            string data = "Name: " + Name +
                "\nRace: " + Race + "\nStats: ";
            foreach (var stat in Stats)
            {
                data += stat.ToString();
            }
            return data;
        }
    }
}
