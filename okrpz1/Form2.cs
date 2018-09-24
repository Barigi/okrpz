using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okrpz1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void дляКофтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.ShowDialog();
        }

        private void дляФутболокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.ShowDialog();
        }

        private void дляШтанівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.ShowDialog();
        }

        private void дляВзуттяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.ShowDialog();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дана програма дозволяє подивитися товар," + "\nякий є в асортименті у бариги Ромки)");
        }

        private void проРозробниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ліпінін В. - Дизайнер програми." + "\nХолод В. - Керівник та розробник бази даних програми." + "\nКоваль А. - Розробник функціоналу програми (кодер)." + "\nСавкін Р. - Тестер програми (в душі барига).");
        }
    }
}
