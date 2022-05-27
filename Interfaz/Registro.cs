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
    public partial class formServicio : Form
    {
        public formServicio()
        {
            InitializeComponent();
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



            // this.Hide();
            //var form1 = new form1();
            // form1.Closed += (s, args) => this.Close();
            // form1.Show();

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //De aqui toma los valores de los textbox
            String nombreCliente = txtNombreCliente.Text;
            String tipo = txtTipo.Text;
            String marca = txtMarca.Text;
            String modelo = txtModelo.Text;
            String detalles = txtDetalles.Text;
            String motivo = txtMotivo.Text;
            String numero = txtNumero.Text;
            String articulos = txtArticulos.Text;
            String estado = "1";
            String diagnostico = "NULL";
            // aqui hace l;a consulta en la base de datos, se une en un string pa mandarselo despues
            // Nota, el default es porque el idcliente es autoincrementable y asi me ahorro programar un monton xd
            String querySQL1 = "USE larousee; INSERT INTO cliente VALUES (default,'" + nombreCliente + "', '" + numero + "') ";
            String querySQL2 = "USE larousee; INSERT INTO equipo VALUES(default, '" + tipo+"','"+marca+"', '"+modelo+"','"+detalles+"', '"+motivo+"', '"+estado+"', '"+diagnostico+"', '"+articulos+"', (SELECT  idCliente FROM cliente ORDER BY idCliente DESC LIMIT 1), (SELECT  idCliente FROM cliente ORDER BY idCliente DESC LIMIT 1))";
            // aqui toma de la clase de la conexion a la base de datos un objeto y su metodo
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();


            // aqui es donde hace la consulta, esta en un try catch por si hay un error en la consulta
            //  ＼(ᵔ •ω• ᵔ)/
            try
            {
                MySqlCommand comando = new MySqlCommand(querySQL1, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Registrado");

                try
                {
                    MySqlCommand comando1 = new MySqlCommand(querySQL2, conexionbd);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("Equipo Registrado");
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: "+ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
