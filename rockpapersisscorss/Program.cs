using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rockpapersisscorss
{
    [Serializable]
    public class RockPaperScissors
    {
        public string PlayerChoice { get; set; }
        public string ComputerChoice { get; set; }

        public List<string> VictoryConditions = new List<string>()
        {
            ("Rock > Scissors"),
            ("Paper > Rock"),
            ("Scissor > Paper")

        };
        public List<string> TieGameConditions = new List<string>()
        {
            ("Rock == Rock"),
            ("Paper == Paper"),
            ("Scissors == Scissors")
        };
       public void SelectPlayerChoice(string choice)
        {
            PlayerChoice = choice;
        }
        public void SelectComputerChoice()
        {
            Random choice = new Random();//Create a new instance of the class Random and gave this instance of the name of choice
            int value = choice.Next(1,4);//The value of choice is equal to ramdomly choose value in a range of 1-4.
            switch (value)
            {
                case 1: ComputerChoice = "Rock"; break;
                case 2: ComputerChoice = "Paper"; break;
                case 3: ComputerChoice = "Scissors"; break;
            }

        }
        public bool CheckForVictory()
        { string review = PlayerChoice + " > " + ComputerChoice;//Checks to see if the computers choice is greater than the players choice
                                                                 // is the Players choice is greater than the computers choice.
            if (VictoryConditions.Contains(review))
            {
                return true;
            }
            return false;
        }
        public bool CheckForTieGame()
        {
            string review = PlayerChoice + " == " + ComputerChoice;//Checks to see if the computers choice is equal than the players choice
                                                                  // is the Players choice is equal than the computers choice.
            if (TieGameConditions.Contains(review))
            {
                return true;
            }
            return false;
        }
    }
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
