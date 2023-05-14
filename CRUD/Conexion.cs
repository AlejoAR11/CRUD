using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CRUD
{
  
    public class Conexion
    {
        string masterDB;

        public Conexion(string _masterDB)
        {
            masterDB = _masterDB;
        }

        public SQLiteConnection ConectarDB() 
        {
            SQLiteConnection conexion_sqlite = null;

            try
            {
                if (!File.Exists(masterDB + ".db"))
                {
                    // Si la base de datos no existe, crearla
                    SQLiteConnection.CreateFile(masterDB + ".db");
                }

                conexion_sqlite = new SQLiteConnection(string.Format("Data Source={0}.db;Version=3;Compress=True;", masterDB));
                MessageBox.Show("Conexión completada");

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error conectando a la base de datos " + masterDB + "\nError: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return conexion_sqlite;
        }


    }

}
