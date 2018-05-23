using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Race : IRace
    {
        string _discription;
        string _name;
        List<IStat>_stats;
        public string Discription
        {
            get
            {
                return _discription;
            }

            set
            {
                _discription = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public List<IStat> Stats
        {
            get
            {
                return _stats;

            }

            set
            {
                _stats = value;
            }
        }
        public override string ToString()
        {
            string data = "Name: " + _name + "\n Discription: " + _discription + "\n Stats:";
            foreach(var stat in Stats)
            {
                data += "\n     ";
                data += stat.ToString();
            }
            return data;
        }
    }
}
