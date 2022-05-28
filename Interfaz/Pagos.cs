using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazServicios
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Size = new Size(712, 32);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Size = new Size(712, 468);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                               (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nEquipo = txtNumeroEquipo.Text;
            String datoscliente = "Cliente: ";
            DataTable datosInsumos = new DataTable();
            String subtotal = "";
            String querySQL2 = "USE larousee; SELECT nombreCliente FROM cliente AS cli JOIN equipo AS eq ON cli.idCliente = eq.cliente_idCliente WHERE eq.idEquipo = " + nEquipo + ";";
            String querySQL3 = "USE larousee; SELECT IdInsumo, descripcion, precio FROM insumo WHERE equipo_idEquipo = "+nEquipo+" ;";
            String querySQL4 = "USE larousee; SELECT SUM(precio) FROM insumo WHERE equipo_idEquipo = "+nEquipo+";";
            
            textBox2.Text = "NO. Equipo: " + nEquipo;

            MySqlConnection conexionbd2 = BD.Conexion();
            conexionbd2.Open();
            MySqlConnection conexionbd3 = BD.Conexion();
            conexionbd3.Open();
            MySqlConnection conexionbd4 = BD.Conexion();
            conexionbd4.Open();
           


            // Para traer el nombre del cliente 
            try
            {
                MySqlDataReader reader2 = null;
                MySqlCommand comando4 = new MySqlCommand(querySQL2, conexionbd2);
                reader2 = comando4.ExecuteReader();
                //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                while (reader2.Read())
                { datoscliente += reader2.GetString(0); }
                textBox5.Text = datoscliente;
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message); }
            finally
            { conexionbd2.Close(); }


            try
            {
                MySqlDataReader reader3 = null;
                MySqlCommand comando5 = new MySqlCommand(querySQL3, conexionbd3);
                reader3 = comando5.ExecuteReader();
                datosInsumos.Load(reader3);
                dataGridView1.DataSource = datosInsumos;
                dataGridView1.Columns[0].HeaderText = "No.";
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Precio";
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message); }
            finally
            { conexionbd2.Close(); }


            try
            {
                MySqlDataReader reader4 = null;
                MySqlCommand comando6 = new MySqlCommand(querySQL4, conexionbd4);
                reader4 = comando6.ExecuteReader();
                while (reader4.Read())
                { subtotal += reader4.GetString(0); }
                richTextBox3.Text = subtotal;
                // datosSubtotal.Load(reader4);
                // var rows = datosSubtotal.AsEnumerable().ToArray();
                //float subtotal = 0F;
                //con esto se obtiene los datos de cierta columna del datatble que ya se cargon con el load de la base de datos
                //for (int i=0; i<rows.Length; i++)
                //{
                //subtotal = rows[i]["precio"].ToFloat;
                // }
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message); }
            finally
            { conexionbd2.Close(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String subtotal = richTextBox3.Text;

            if (richTextBox1.Text == null)
            {
                String servicio = "0.00";
                float total =
            float.Parse(subtotal, CultureInfo.InvariantCulture.NumberFormat)
            +
            float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat);
                Console.WriteLine(float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat));

                richTextBox2.Text = "Q" + total + "";
            }
            else
            {
                if (richTextBox1.Text == "")
                {
                    String servicio = "0.00";
                    float total =
                    float.Parse(subtotal, CultureInfo.InvariantCulture.NumberFormat)
                     +
                    float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat);
                    Console.WriteLine(float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat));

                    richTextBox2.Text ="Q"+ total + "";
                }
                else
                {
                    String servicio = richTextBox1.Text;
                    float total =
                    float.Parse(subtotal, CultureInfo.InvariantCulture.NumberFormat)
                     +
                    float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat);
                    Console.WriteLine(float.Parse(servicio, CultureInfo.InvariantCulture.NumberFormat));

                    richTextBox2.Text = "Q" + total + "";
                }
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nEquipo = txtNumeroEquipo.Text;
            String querySQL5 = "USE larousee; SELECT estado FROM equipo WHERE idEquipo = "+nEquipo+";";
            String querySQL6 = "USE larousee; UPDATE equipo SET estado = 'Entregado' WHERE idEquipo = "+nEquipo+";";
            String estado = null;
            MySqlConnection conexionbd5 = BD.Conexion();
            conexionbd5.Open();
            MySqlConnection conexionbd9 = BD.Conexion();
            conexionbd9.Open();
            try
            {
                MySqlDataReader reader5 = null;
                MySqlCommand comando4 = new MySqlCommand(querySQL6, conexionbd5);
                reader5 = comando4.ExecuteReader();
                //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                while (reader5.Read())
                { estado += reader5.GetString(0); }
                
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al CAMBIAR el estado: " + ex.Message); }
            finally
            { conexionbd5.Close(); }




            try
            {
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(querySQL5, conexionbd9);
                reader = comando.ExecuteReader();
                //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                while (reader.Read())
                { estado += reader.GetString(0); }
                label8.Text = estado;
                Console.WriteLine(estado);
                label8.Text = estado;
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el estado: " + ex.Message); }
            finally
            { conexionbd9.Close(); }



           
        }

        private void panelchilero3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
