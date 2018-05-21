using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 3.Containers;
using Newtonsoft.Json;

namespace CharacterCreator
{
    class Character
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
}
