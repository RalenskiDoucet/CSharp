using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        public List<Race> RaceList = new List<Race>()
        {
            new Human() {CharacterName = "Human" , Level = 0, ExperiencePoints = 0},
            new Robot() {CharacterName = "robot" , Level = 0, ExperiencePoints = 0},
            new Wizard() {CharacterName = "wizard" , Level = 0, ExperiencePoints = 0},
            new ogre() {CharacterName = "ogre" , Level = 0, ExperiencePoints = 0}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RaceSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in RaceList)
            {
                if(item.CharacterName == RaceBox.Text)
                {
                    richTextBox1.Text = item.ToString();
                }
            }
        }
        private void MakeCharacter_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var item in RaceList)
            {
                RaceBox.Items.Add(item.CharacterName);
                item.MakeCharacter();
                label5.Text = textBox1.Text;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
