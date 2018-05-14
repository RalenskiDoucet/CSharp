using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BackPack
{
    public interface IPackable
    {
        string Name { get; set; }
        void Pack(BackPack item);
    }
    public abstract class Item : IPackable
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public int Value { get;  set; }

        public Item(string name, string attribute, int value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override string ToString()
        {
            string data = Effect + " : " + Value;
            return data;
        }

        public abstract void Pack(BackPack item);
    }
    public class BackPack
    {
        public static List<IPackable> packables = new List<IPackable>()
        {
            new HealingDrink(name: "HealingDrink",attribute:"Heal",value: 20),
            new CombatKnife(name:"Combat_Knife",attribute:"Sharpness", value: 25 ),
            new AntidoteShot(name:"Antidote",attribute: "Cure", value: 20 ),
            new CombatShield(name:"CombatShield",attribute: "Toughness", value: 70 ),
            new BarettaM92(name:"M9", attribute:"Bullet Damage",value: 20 ),
            new KevlarVest(name:"KevlarVest",attribute:"Armor", value: 30 )
        };
    }
    public class HealingDrink : Item, IPackable
    {
        public HealingDrink(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class CombatKnife : Item, IPackable
    {
        public CombatKnife(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class AntidoteShot : Item, IPackable
    {
        public AntidoteShot(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class CombatShield : Item, IPackable
    {
        public CombatShield(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class BarettaM92 : Item, IPackable
    {
        public BarettaM92(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }
        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
    public class KevlarVest : Item, IPackable
    {
        public KevlarVest(string name, string attribute, int value) : base(name, attribute, value)
        {
            Name = name;
            Effect = attribute;
            Value = value;
        }

        public override void Pack(BackPack item)
        {
            BackPack.packables.Add(this);
        }
    }
}
