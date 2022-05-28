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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Size = new Size(200, 200);
            this.Close();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nEquipo = txtNEquipo.Text;
            String nombreInsumo = txtNombreInsumo.Text;
            String precioInsumo = txtPrecioInsumo.Text;

            String querySQL3 = "USE larousee; INSERT INTO Insumo VALUES (default,'" + nombreInsumo + "', '" + precioInsumo + "' , '"+nEquipo+"') ";
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();

            try
            {
                MySqlCommand comando1 = new MySqlCommand(querySQL3, conexionbd);
                comando1.ExecuteNonQuery();
                MessageBox.Show("Insumo Registrado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nEquipo = txtNEquipo.Text;
            String nInsumo = txtNumeroInsumo.Text;
            String querySQL3 = "USE larousee; DELETE FROM Insumo WHERE equipo_idEquipo = '" + nEquipo + "' AND idInsumo = '"+nInsumo+"'";
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();

            try
            {
                MySqlCommand comando1 = new MySqlCommand(querySQL3, conexionbd);
                comando1.ExecuteNonQuery();
                MessageBox.Show("Insumo Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }
        }
    }
    }

