using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface ILoggable
    {
       void Log();//Output debug information
       string Name
        {
            get;
            set;
        }
    }
    public class Animal : ILoggable{
        string name;

        public string Name
        {
            //var a = new Animal();


            get//string nameexample = a.Name;
            {
               return (name);
            }

            set//a.Name = "ralenski"
            {
                name = value;
            }
        }

        public void Log()
        {
            Console.WriteLine("Animal name is");
        }
        void test()
        {
            Animal Dog = new Animal()
            {name = "Lucky",};
            Animal Cat = new Animal()
            { name = "Unlucky",};
            Animal Cow = new Animal()
            { name = "Heffer",};
            Animal Horse = new Animal()
            {name = "LongNeck",};
            Animal Fish = new Animal()
            { name = "Nemo", };
        }
    }
    public class Vehicle : ILoggable
    {
        string name;

        public string Name
        {
            get
            {
                return (name);
            }

            set
            {
                name = value;
            }
        }
        Vehicle Charger = new Vehicle()
        {name = "Charger",};
        Vehicle Mustang = new Vehicle()
        { name = "Mustang", };
        Vehicle Camaro = new Vehicle()
        { name = "Camaro", };

        public void Log()
        {
            Console.WriteLine("Vehicle name is");
        }
    }

}
