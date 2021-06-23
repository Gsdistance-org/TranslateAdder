using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateAdder
{
    public partial class Adder : Form
    {
        public Adder()
        {
            InitializeComponent();
        }

        private void Adder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.richTextBox1.Text;
            string filein = this.richTextBox2.Text;
            string inputlang = this.comboBox1.Text;
            string outputlang = this.comboBox2.Text;
            if (File.Exists(@".\" + @"TranslaterLangs" + @"\" + inputlang + "-" + outputlang + @"\" + name + @".translate"))
            {
                MessageBox.Show("The file alredy exists");
            }
            else
            {
                File.WriteAllText(@".\" + @"TranslaterLangs" + @"\" + inputlang + "-" + outputlang + @"\" + name + @".translate", filein);
                this.richTextBox1.Clear();
                this.richTextBox2.Clear();
                MessageBox.Show("Added file!");
            }
        }

        private void clearBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
        }

        private void clearEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
        }
    }
}
