using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace okrpz1
{
    class Db
    {
        private MySqlConnection conn;
        private MySqlCommand mencom;


        private MySqlDataReader reader;

        public MySqlCommand Mencom { get => mencom; set => mencom = value; }
        public MySqlConnection Conn { get => conn; set => conn = value; }
        public MySqlDataReader Reader { get => reader; set => reader = value; }

        public Db() {
            conn = new MySqlConnection(Properties.Settings.Default.barigiConnectionString);//"server=localhost;user=root;database=barigi;password=Krager123;");
        }

        public void VZ(string zap)
        {
            mencom.CommandText = zap;
            mencom.Prepare();
            mencom.ExecuteNonQuery();

        }
        public MySqlDataReader VZR(string zap)
        {
            mencom = new MySqlCommand(zap, conn);
            conn.Open();
            //mencom.CommandText = zap;
            reader = mencom.ExecuteReader();
            conn.Close();
            return reader;
        }
        public object RZ()
        {
            return mencom.ExecuteScalar();
        }
        public void Open()
        {
            mencom.Connection = conn;
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }

    }

}