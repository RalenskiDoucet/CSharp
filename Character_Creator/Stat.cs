using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
   public class Stat : IStat
    {
        string _name;
        string _description;
        int _value;
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

        public string Discription
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public override string ToString()
        {
            string data = "Name: " + _name +
                "\nValue: " + _value;
            return data;
        }
    }

}
