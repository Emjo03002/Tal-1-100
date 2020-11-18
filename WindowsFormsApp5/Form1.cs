using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int gissning = 0;
        int antalgissningar = 0;
        int slump1 = 0;
        public Form1()
        {
            InitializeComponent();
            Random slump = new Random();
            slump1 = slump.Next(0, 101);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            gissning = int.Parse(TextBox1.Text);
            antalgissningar++;
            label3.Text = "Du har gissat " + antalgissningar + " gånger!";

            if (gissning < slump1)
                label2.Text = "Ditt tal är för lågt";
            else if (gissning > slump1)
                label2.Text = "Ditt tal var för högt";
            else
            {
                label2.Text = "Du hade rätt!";
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
