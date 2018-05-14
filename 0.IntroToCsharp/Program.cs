using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCsharp
{
    class Program
    {public abstract class Item
        {
            public string name;
            public int Id;
        }
    public abstract class Weapon
        {
            public int power;
            public virtual void dodamage() { };
        }
    public abstract class Potion
        {
           public int power;
           public virtual void consume();
        }

        static void Main(string[] args)
        {
        }
    }
}
