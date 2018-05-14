using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPack
{
    namespace ConsoleApplication1
    {
        public interface IPackable
        {
            string Name { get; set; }
        }
        public interface IPacker
        {
            string Name { get; set; }
            void Pack(IPackable);

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

            public void Pack(IPackable packable)
            {
                mBackpack.Add(packable);
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
        class Program
        {

        }


        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void BackPackContents(object sender, EventArgs e)
            {            }

            private void AddtoBackpack(object sender, EventArgs e)
            {

            }

            private void RemoveFromBackPack(object sender, EventArgs e)
            {

            }

            private void Save(object sender, EventArgs e)
            {

            }
            static void Main(string[] args)
            {
            }
        }
    }
}
