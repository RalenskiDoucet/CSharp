using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface IDamagable
    {
        bool TakeDamage(int amount);
        int ArmorClass { get; set; }
    }
    public interface IDamager
    {
        int HitModifier { get; set; }
        void DoDamage(IDamagable done);
    }


    public abstract class Entity : IDamagable
    {
        private int health;
        private string name;
        public abstract int ArmorClass { get; set; }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract bool TakeDamage(int amount);
    }
    public class Assassin : Entity
    {
        public override int ArmorClass
        {
            get { return ArmorClass; }
            set { ArmorClass = value; }
        }
        public int HitModifier
        {
            get{return HitModifier;}
            set{ HitModifier=value;}
        }
        public void DoDamage(IDamagable done)
        {
            {
                object Combat = null;
                Random d = new Random();
                var roll = d.Next(1, 10);
                var percent = 10 - (ArmorClass - HitModifier) / 10;
                Console.WriteLine(Name + "Damage is being dealt!");
                var status = Combat.GetStatus(percent * 100);
                switch (status)
                {
                    case Combat.HitStatus.CRITICAL_HIT: break;
                    case Combat.HitStatus.CRITICAL_MISS: break;
                    case Combat.HitStatus.HIT: break;
                    case Combat.HitStatus.MISS: break;
                    default: break;
                }
            }
        }
        public override bool TakeDamage(int amount)
        {
            Random a = new Random(); var roll = a.Next(1, 10);
            if (Health <= 0)
            return false;
            else if (roll > (ArmorClass - HitModifier))

        {
            var hitChance = 10 - (ArmorClass - HitModifier) / 10;
                GetStatus(hitChance * 100);
                Health -= amount;

            }
            return true;
        }

        private void GetStatus(int status)
        {
            status =
        }
    }
    public class Ninja : Entity
    {
        public override int ArmorClass
        {
            get { return ArmorClass; }
            set { ArmorClass = value; }
        }
        public int HitModifier
        {
            get { return HitModifier; }
            set { HitModifier = value; }
        }
        public void DoDamage(IDamagable done)
        {
            {
                object Combat = null;
                Random b = new Random();
                var roll = b.Next(1, 21);
                var percent = 10 - (ArmorClass - HitModifier) / 10;
                Console.WriteLine(Name + "Damage is being dealt!");
                var status = Combat.GetStatus(percent * 100);

                switch (status)
                {
                    case Combat.HitStatus.CRITICAL_HIT: break;
                    case Combat.HitStatus.CRITICAL_MISS: break;
                    case Combat.HitStatus.HIT: break;
                    case Combat.HitStatus.MISS: break;
                    default: break;
                }
            }
        }
        public override bool TakeDamage(int amount)
        {
            Random b = new Random(); var roll = b.Next(1, 10);
            if (Health <= 0)
                return false;
            else if (roll > (ArmorClass - HitModifier))

            {
                var hitChance = 10 - (ArmorClass - HitModifier) / 10;
                GetStatus(hitChance * 100);
                Health -= amount;

            }
            return true;
        }

        private void GetStatus(int v)
        {
            throw new NotImplementedException();
        }

        public class Nord : Entity
        {
            public override int ArmorClass
            {
                get { return ArmorClass; }
                set { ArmorClass = value; }
            }

            public object Combat { get; private set; }

            public int HitModifier
            {
                get { return HitModifier; }
                set { HitModifier = value; }
            }
            public void DoDamage(IDamagable done)
            {
                {
                    object Combat = null;
                    Random c = new Random();
                    var roll = c.Next(1, 21);
                    var percent = 10 - (ArmorClass - HitModifier) / 10;
                    Console.WriteLine(Name + "Damage is being dealt!");
                    var status = Combat.GetStatus(percent * 100);
                    switch (status)
                    {
                        case Combat.HitStatus.CRITICAL_HIT: break;
                        case Combat.HitStatus.CRITICAL_MISS: break;
                        case Combat.HitStatus.HIT: break;
                        case Combat.HitStatus.MISS: break;
                        default: break;
                    }
                }
            }
            public override bool TakeDamage(int amount)
            {
                Random c = new Random(); var roll = c.Next(1, 10);
                if (Health <= 0)
                    return false;
                else if (roll > (ArmorClass - HitModifier))

                {
                    var hitChance = 10 - (ArmorClass - HitModifier) / 10;
                    GetStatus(hitChance * 100);
                    Health -= amount;

                }
                return true;
            }

            private void GetStatus(int v)
            {
                throw new NotImplementedException();
            }
        }

        public class Soldier : Entity
        {
            public override int ArmorClass
            {
                get { return ArmorClass; }
                set { ArmorClass = value; }
            }

            public object Combat { get; private set; }

            public int HitModifier
            {
                get { return HitModifier; }
                set { HitModifier = value; }
            }
            public void DoDamage(IDamagable done)
            {
                {
                    object Combat = null;
                    Random d = new Random();
                    var roll = d.Next(1, 21);
                    var percent = 10 - (ArmorClass - HitModifier) / 10;
                    Console.WriteLine(Name + " Damage is being dealt!");
                    var status = Combat.GetStatus(percent * 100);
                    switch (status)
                    {
                        case Combat.HitStatus.CRITICAL_HIT: break;
                        case Combat.HitStatus.CRITICAL_MISS: break;
                        case Combat.HitStatus.HIT: break;
                        case Combat.HitStatus.MISS: break;
                        default: break;
                    }
                }
            }
            public override bool TakeDamage(int amount)
            {
                Random d = new Random(); var roll = d.Next(1, 10);
                if (Health <= 0)
                    return false;
                else if (roll > (ArmorClass - HitModifier))

                {
                    var hitChance = 10 - (ArmorClass - HitModifier) / 10;
                    GetStatus(hitChance * 100);
                    Health -= amount;

                }
                return true;
            }

            private void GetStatus(int v)
            {
                throw new NotImplementedException();
            }
        }

        public class Robot : Entity, IDamager
        {

            public override int ArmorClass
            {
                get { return ArmorClass; }
                set { ArmorClass = value; }
            }

            public int HitModifier
            {
                get { return HitModifier; }
                set { HitModifier = value; }
            }

            public void DoDamage(IDamagable done)
            {
                {
                    object Combat = null;
                    Random d = new Random();
                    var roll = d.Next(1, 21);
                    var percent = 10 - (ArmorClass - HitModifier) / 10;
                    Console.WriteLine(Name + " Damage is being dealt!");
                    var status = Combat.GetStatus(percent * 100);
                    switch (status)
                    {
                        case Combat.HitStatus.CRITICAL_HIT: break;
                        case Combat.HitStatus.CRITICAL_MISS: break;
                        case Combat.HitStatus.HIT: break;
                        case Combat.HitStatus.MISS: break;
                        default: break;
                    }
                }
            }

            public override bool TakeDamage(int amount)
            {
                Random e = new Random(); var roll = e.Next(1, 10);
                if (Health <= 0)
                    return false;
                else if (roll > (ArmorClass - HitModifier))

                {
                    var hitChance = 10 - (ArmorClass - HitModifier) / 10;
                    GetStatus(hitChance * 100);
                    Health -= amount;

                }
                return true;
            }

            private void GetStatus(int v)
            {
                throw new NotImplementedException();
            }
        }

        public class CombatClass
        {
        }
    }
}
