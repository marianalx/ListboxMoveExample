using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxMoveExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=20; i++)
            {
                listBox1.Items.Add(String.Format("Opcja {0}", i));
                listBox2.Items.Add(String.Format("Opcja {0}", (char)(i + (int)'A')) );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedIndices
        }
    }
}
