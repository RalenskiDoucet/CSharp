using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Character_Creator
{
    public partial class Form1 : Form
    {
        public List<IStat> stats = new List<IStat>()
        {
            new Stat() {Name = "Health", Discription = "", Value = 15 },
            new Stat() {Name = "Speed",Discription="",Value=15 }
        };
        Race Elf;
        Race Human;
        public List<IStat> humanstats = new List<IStat>()
        {
            new Stat() {Name="Health" ,Discription = "",Value = 20},
            new Stat() {Name="Speed" ,Discription = "",Value = 20},
        };
        Race Ogre;
        public List<IStat> ogrestats = new List<IStat>()
        {
            new Stat() {Name="Health" ,Discription = "",Value = 30},
            new Stat() {Name="Speed" ,Discription = "",Value = 30},
        };
        IRace race;
        public Form1()
        {
            InitializeComponent();
            Elf = new Race() { Name = "Elf", Discription = "This is an Elf.", Stats = stats };
            Human = new Race() { Name = "Human", Discription = "This is a human.", Stats = humanstats };
            Ogre = new Race() { Name = "Ogre", Discription = "This is an Ogre.", Stats = ogrestats };
            RaceBox.Items.Add(Elf.Name);
            RaceBox.Items.Add(Ogre.Name);
            RaceBox.Items.Add(Human.Name);
            race = Human;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RaceSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RaceBox.Text == Elf.Name)
            {
                race = Elf;
            }
            if (RaceBox.Text == Ogre.Name)
            {
                race = Ogre;
            }
            if (RaceBox.Text == Human.Name)
            {
                race = Human;
            }
        }

        private void MakeCharacter_Click(object sender, EventArgs e)
        {
            if (race == null)
                return;
            Character newChar = new Character() { Name = textBox1.Text, Race = race, Stats = race.Stats };
            richTextBox1.Text = newChar.ToString();
        }
    }
}
