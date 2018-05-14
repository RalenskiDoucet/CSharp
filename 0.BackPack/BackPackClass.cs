using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.BackPack
{
        public interface IPackable
    {
        string Name { get; set; }


    }
    public interface IPacker
    {
        string Name { get; set; }
        void Pack(IPackable mPackable);

    }


    public class Item : IPackable
    {
        public string Description;

        public bool ItemPickedUp
        {
            get; set;
        }
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = "PickedUpItem";
            }
        }
    }

    public class BackPack : IPacker
    {
        List<IPackable> mBackpack;

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = "BackPack";
            }
        }

        public void Pack(IPackable Packable)
        {
            mBackpack.Add(Packable);
        }
    }
    public class Weapon : Item
    {
        int damage;
    }
    public class RangedWeapon : Weapon, IPackable
    {
        int AttackDistance;



        public string Name
        {
            get
            {
                return Name = "Weapon";
            }

            set
            {
                Name = "Weapon";
            }
        }
    }
    public class Bretta : RangedWeapon
    {

    }
    public class MeleeWeapon : Weapon, IPackable
    {
        int OneHanded;
        int TwoHanded;



        public string Name
        {
            get
            {
                return Name = "Melee Weapon"; ;
            }

            set
            {
                Name = "Melee Weapon";
            }
        }
    }
    public class CombatKnife : MeleeWeapon, IPackable
    {

    }
    public class HealthDrink : MeleeWeapon, IPackable
    {

    }
    public class AntidoteShot : MeleeWeapon, IPackable
    {

    }
    public class Armor : Item, IPackable
    {
        public int ArmorRating;
    }
    public class KevlarVest : Armor, IPackable
    {

    }
    public class CombatShield : Armor, IPackable
    {
    }
}



