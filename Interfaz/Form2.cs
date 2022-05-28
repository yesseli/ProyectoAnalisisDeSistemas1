using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazServicios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable equipos = new DataTable();
            String querySQL7 = "USE larousee; SELECT idEquipo, tipoEquipo, Marca, modelo, detalles, accesorios, estado, diagnostico FROM equipo  ;";

            MySqlConnection conexionbd10 = BD.Conexion();
            conexionbd10.Open();


            try
            {
                MySqlDataReader reader11 = null;
                MySqlCommand comando11 = new MySqlCommand(querySQL7, conexionbd10);
                reader11 = comando11.ExecuteReader();
                equipos.Load(reader11);
                dataGridView1.DataSource = equipos;
                dataGridView1.Columns[0].HeaderText = "NUMERO";
                dataGridView1.Columns[1].HeaderText = "Tipo";
                dataGridView1.Columns[2].HeaderText = "Marca";
                dataGridView1.Columns[3].HeaderText = "Modelo";
                dataGridView1.Columns[4].HeaderText = "Detalles";
                dataGridView1.Columns[5].HeaderText = "Accesorios";
                dataGridView1.Columns[6].HeaderText = "Estado";
                dataGridView1.Columns[7].HeaderText = "Diagnostico";
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message); }
            finally
            { conexionbd10.Close(); }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            Size = new Size(200, 200);
            this.Close();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
