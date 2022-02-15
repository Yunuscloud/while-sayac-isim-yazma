using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int say;
            say = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();

            while (sayac < say) 
            {
                listBox1.Items.Add("Yunus");
                sayac++;
            }
        }
    }
}
