using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUD
{
    public partial class frmCRUD : MaterialForm
    {

        private static string DataBaseName = "Usuarios";
        private static string TableName = "tblPersonas";

        private readonly MaterialSkinManager materialSkinManager;
        public frmCRUD()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, 
                Primary.BlueGrey900, 
                Primary.BlueGrey500, 
                Accent.LightBlue200, 
                TextShade.WHITE);
            btnConnect.BackColor = Color.Green;

        }



      

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public static SQLiteCommand loadData()
        {
            SQLiteConnection conexionDB = new Conexion(DataBaseName).ConectarDB();
            conexionDB.Open();

            try
            {

                // Verificar si la tabla "persona" existe
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT count(*) FROM sqlite_master WHERE type='table' AND name='persona'", conexionDB))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        // La tabla no existe, por lo que debemos crearla
                        using (SQLiteCommand createCmd = new SQLiteCommand("CREATE TABLE tblPersona (ID INTEGER PRIMARY KEY, Nombre TEXT, Clave TEXT)", conexionDB))
                        {
                            createCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error conectando a la base de datos " + DataBaseName + "\nError: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try {

                string usuarios = string.Format("SELECT * from {0}", TableName);
                SQLiteCommand cmd_getUsers = new SQLiteCommand(usuarios, conexionDB);


                return cmd_getUsers;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error obteniendo los datos desde la base de datos\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

            conexionDB.Close();
            return null;
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
           
           
            SQLiteCommand cmd_loadUsers = loadData();
            SQLiteDataReader dataReader_sqlite = cmd_loadUsers.ExecuteReader();

            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            dgvDatos.Columns.Add("idPersona", "ID");
            dgvDatos.Columns.Add("nombrePersona", "Nombre");
            dgvDatos.Columns.Add("clavePersona", "Clave");

            while (dataReader_sqlite.Read())
            {

                int idPersona = dataReader_sqlite.GetInt32(0);
                string nombrePersona = dataReader_sqlite.GetString(1);
                string calvePersona = dataReader_sqlite.GetString(2);

                dgvDatos.Rows.Add(idPersona,nombrePersona,calvePersona);
            }
            dataReader_sqlite.Close();

        }

        private void SetDarkTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey700,
                Primary.Grey800,
                Primary.Grey500,
                Accent.Red200,
                TextShade.WHITE);
        }

        private void SetLightTheme()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);

        }

        private void swTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (swTheme.Checked)
            {

                SetDarkTheme();
                swTheme.Text = "Claro";
            }
            else
            {
                SetLightTheme();
                swTheme.Text = "Oscuro";
            }


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }



    }

}
