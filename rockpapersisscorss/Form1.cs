using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace rockpapersisscorss
{
    public partial class Form1 : Form
    {
        RockPaperScissors Game1 = new RockPaperScissors();
        public Form1()
        {
            InitializeComponent();
        }
        private void SubmitChoiceButtonclicked(object sender, EventArgs e)
        {
            Game1.SelectComputerChoice();
            Game1.CheckForVictory();
            Game1.CheckForTieGame();
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "RockPaperScissors.json");
            var RockPaperScissors_root = JsonConvert.SerializeObject(Game1);
            System.IO.File.WriteAllText(path, RockPaperScissors_root);
        }
        private void Rock(object sender, EventArgs e)
        {
            var cpuChoice = Game1.ComputerChoice();
            Game1.PlayerChoice = "Rock";
        }

        private void Paper(object sender, EventArgs e)
        {
            Game1.SelectComputerChoice();
            Game1.PlayerChoice = "Paper";
        }

        private void Scissors(object sender, EventArgs e)
        {
            Game1.SelectComputerChoice();
            Game1.PlayerChoice = "Scissors";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text =Game1.PlayerChoice + "\0";
            textBox1.Text = Game1.ToString();
            var result = Game1.CheckForVictory();
            textBox1.AppendText("result");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Game1.ComputerChoice + "\0";
            textBox2.Text = Game1.ToString();
            var result = Game1.CheckForVictory();
            textBox2.AppendText("result");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

