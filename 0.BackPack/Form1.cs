using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace _0.BackPack
{

    public partial class Form1 : Form
    {
        BackPack Bag1 = new BackPack();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pack_button_Click(object sender, EventArgs e)
        {
            foreach (IPackable item)

        }

        private void UnPack_button2_Click(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "BackPack.json");
            var backpack_root = JsonConvert.SerializeObject(BackPack);
            System.IO.File.WriteAllText(path, backpack_root);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
