using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CharacterCreator
{
    public class Character
    {
        public int ExperiencePoints = 0;
        public int Level = 0;
        public string CharacterName = ("");
    }
    public class Race : Character
    {
        public string Name { get; set; }

        internal void MakeCharacter()
        {
            Character temp = new Character();
        }
    }
    public class Human : Race
    {
    }
    public class Robot : Race
    {

    }
    public class Wizard : Race
    {

    }
    public class ogre : Race
    {

    }

    public class CharacterData
    {
        public static Dictionary<string, Race> Races = new Dictionary<string, Race>();
        public static void AddRace(Race race)
        {
            Races.Add(race.Name, race);
        }

    }
    class Stat
    {
        public string Name
        { get; set; }
        public string Description
        { get; set; }
        public static Stat Health
        { get; private set; }
        public static Stat Stamina
        { get; private set; }
        public static Stat Strenght
        { get; private set; }
        public static Stat Gold
        { get; private set; }
        public static Stat Silver
        { get; private set; }
        public static Stat Copper
        { get; private set; }

        public static List<Stat> Stats = new List<Stat>()
        {
            Health, Stamina, Strenght,Gold,Silver,Copper,
        };

    }
}
