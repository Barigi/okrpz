using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace okrpz1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.ShowDialog();
        }

        private void дляВзуттяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.ShowDialog();
        }

        private void дляШтанівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.ShowDialog();
        }

        private void дляФутболокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.ShowDialog();
        }

        private void дляКофтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 s = new Form8();
            s.ShowDialog();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дана програма дозволяє подивитися товар,"+"\nякий є в асортименті у бариги Ромки)");
        }

        private void проРозробниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ліпінін В. - Дизайнер програми."+"\nХолод В. - Керівник та розробник бази даних програми."+"\nКоваль А. - Розробник функціоналу програми (кодер)."+"\nСавкін Р. - Тестер програми (в душі барига).");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            
>>>>>>> 11c3d07a6b3fa26c7cea26945f500e1b7b3d3721
        }
    }
}
