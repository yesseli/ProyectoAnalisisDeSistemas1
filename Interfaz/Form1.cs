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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombreCliente = txtNombreCliente.Text;
            String tipo = txtTipo.Text;
            String marca = txtMarca.Text;
            String modelo = txtModelo.Text;
            String detalles = txtDetalles.Text;
            String motivo = txtMotivo.Text;
            String numero = txtNumero.Text;
            String articulos = txtArticulos.Text;
            String estado = "Almacenado";
            String diagnostico = "NULL";
            String nEquipo = textBox1.Text;
            String querySQL1 = "USE larousee; UPDATE equipo SET tipoEquipo= '" + tipo + "', Marca ='" + marca + "', modelo =  '" + modelo + "', detalles = '" + detalles + "', descripcionProblema ='" + motivo + "', estado = '" + estado + "', diagnostico = '" + diagnostico + "', accesorios = '" + articulos + "' WHERE idEquipo = "+nEquipo+" ";
            String querySQL2 = "USE larousee; UPDATE cliente JOIN equipo ON cliente_idCliente = idCliente SET nombreCliente= '" + nombreCliente + "', telefono ='" + numero + "' WHERE idEquipo = " + nEquipo + ";";

            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();
            MySqlConnection conexionbd1 = BD.Conexion();
            conexionbd1.Open();


            try
            {
                MySqlCommand comando = new MySqlCommand(querySQL1, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Equipo Editado");

                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al editar equipo " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }

            try
            {
                MySqlCommand comando1 = new MySqlCommand(querySQL2, conexionbd1);
                comando1.ExecuteNonQuery();
                MessageBox.Show("Cliente Editado");



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al editar cliente " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();
            // form1 form = new form1();
            //  form.Size = new Size(712, 468);
            // form.Show();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.Size = new Size(712, 468);
        }
    }
}
