using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    class Conexion
    {
        public MySqlCommand cmd;
        private MySqlConnection con;

        public Conexion()
        {
            string server = Convert.ToString(ConfigurationManager.AppSettings["server"]);
            string database = Convert.ToString(ConfigurationManager.AppSettings["database"]);
            string pass = Convert.ToString(ConfigurationManager.AppSettings["password"]);
            string usuario = Convert.ToString(ConfigurationManager.AppSettings["user"]);

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = server;
            builder.UserID = usuario;
            builder.Password = pass;
            builder.Database = database;

            con = new MySqlConnection(builder.ToString());
            cmd = con.CreateCommand();

        }


        public void setSQL(string text)
        {
            cmd.CommandText = text;
        }

        public MySqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }


        //public MySqlCommand Cmd { get; set; }

        public void abrir()
        {
            con.Open();
        }

        public void cerrar()
        {
            con.Close();
        }

        public void tipoTexto()
        {
            cmd.CommandType = CommandType.Text;
        }
    }
}
