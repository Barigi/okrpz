using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using   System.Data;

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
            conn = new MySqlConnection("server=localhost;user id=root;database=barigi;persistsecurityinfo=True; password=Krager123; SslMode=none");
        }

        public void VZ(string zap)
        {
            mencom = new MySqlCommand(zap, conn);
            conn.Open();            
            mencom.Prepare();
            int x = mencom.ExecuteNonQuery();
            conn.Close();
        }

        public MySqlDataReader VZR(string zap)
        {
            mencom = new MySqlCommand(zap, conn);
            conn.Open();
            MySqlDataReader reader;
            reader = mencom.ExecuteReader();
            conn.Close();
            return reader;
        }
        public ArrayList AVZR(string zap)
        {
           // ArrayList arr = new ArrayList();                
            mencom = new MySqlCommand(zap, conn);
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(mencom);
            da.Fill(dt);
            conn.Close();
            return null; 
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