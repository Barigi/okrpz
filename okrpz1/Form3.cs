﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;

namespace okrpz1
{
    public partial class Form3 : Form
    {
        Db baza = new Db();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.barigiConnectionString);
            MySqlCommand mencom;
            mencom = new MySqlCommand("SELECT * FROM shorts", conn);
            conn.Open();
            DataTable dt = new DataTable("ghjghj");
            MySqlDataAdapter da = new MySqlDataAdapter(mencom);
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
            return;
            string query = "SELECT * FROM barigi.shorts;";

            MySqlDataReader reader = baza.VZR(query);
            dataGridView1.Rows.Clear();

            using (reader)
            {
                if (reader.HasRows)
                {
                    int add = 0;
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1[0, add].Value = reader.GetString("id");
                        dataGridView1[1, add].Value = reader.GetString("Назва");
                        dataGridView1[2, add].Value = reader.GetString("Тип");
                        dataGridView1[3, add].Value = reader.GetString("Колір");
                        dataGridView1[4, add].Value = reader.GetString("Тип тканини");
                        dataGridView1[5, add].Value = reader.GetString("Фірма");
                        dataGridView1[6, add].Value = reader.GetString("Розмір");
                        dataGridView1[7, add].Value = reader.GetString("Ціна");
                        add++;
                    }
                }
            }
            reader.Close();
            baza.Close();
    }
    }
}