using _1.Containers;
using System;
using System.Windows.Forms;

namespace CombatForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Character Player1 = new Character()
            {
                Name = "Ralenski",
                Level = 5,
                Experince = "1",
            };
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Stat Strength = new Stat()
            {
                Name = "Strength",
                Value = "8",
                Description = "Detemines what weapon a person will use",
            };
            Stat Dexterity = new Stat()
            {
                Name = "Dexterity",
                Value = "6",
                Description = "Detemines player's attack speed",
            };
            Stat Wisdom = new Stat()
            {
                Name = "Wisdom",
                Value = "7",
                Description = "The smartness of a player",
            };
            Stat Intelligence = new Stat()
            {
                Name = "Intelligence",
                Value = "9",
                Description = "The rate of experience gain",
            };
            Stat Constitution = new Stat()
            {
                Name = "Constitution",
                Value = "8",
                Description = "The total amount of health",
            };
            Stat Chraisma = new Stat()
            {
                Name = "Chraisma",
                Value = "7",
                Description = "The ablitiy to avoid being attacked",
            };
        }
    }
}

