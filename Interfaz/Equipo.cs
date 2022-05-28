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
    public partial class Equipo : Form
    {
        public Equipo()
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
        //Registrar insumo
        private void button1_Click(object sender, EventArgs e)
        {
            String NEquipo = txtNEquipo.Text;
            String insumo = txtNombreInsumo.Text;
            String precio = txtPrecioInsumo.Text;
            String querySQL = "USE larousee; INSERT INTO insumo VALUES(default, '"+insumo+"', "+precio+", "+NEquipo+");";
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querySQL, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Insumo Registrado");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar insumo: " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }
        }
        //Ver numero de equipo
        private void button3_Click(object sender, EventArgs e)
        {
            String hol = dataGridView2.Text;
            String numeroEquipo = textBox2.Text;
            String datos = null ;
            String datosNu = null;
            String estado = null;
            String datoscliente = "Cliente: ";
            String datostelefono = "Telefono: ";
            DataTable datosInsumos = new DataTable();
            DataTable datosEquipo = new DataTable();
            String querySQL  = "USE larousee; SELECT descripcion   FROM insumo WHERE equipo_idEquipo = " + numeroEquipo + ";";
            String querySQL1 = "USE larousee; SELECT IdInsumo      FROM insumo WHERE equipo_idEquipo = " + numeroEquipo + ";";
            String querySQL2 = "USE larousee; SELECT nombreCliente FROM cliente AS cli JOIN equipo AS eq ON cli.idCliente = eq.cliente_idCliente WHERE eq.idEquipo = "+numeroEquipo+";";
            String querySQL3 = "USE larousee; SELECT telefono      FROM cliente AS cli JOIN equipo AS eq ON cli.idCliente = eq.cliente_idCliente WHERE eq.idEquipo = " + numeroEquipo + ";";
            String querySQL5 = "USE larousee; SELECT estado        FROM equipo WHERE idEquipo = "+ numeroEquipo + ";";
            String querySQL6 = "USE larousee; SELECT IdInsumo, descripcion, precio FROM insumo WHERE equipo_idEquipo = " + numeroEquipo + " ;";
            String querySQL7 = "USE larousee; SELECT tipoEquipo, Marca, modelo, detalles, accesorios, diagnostico FROM equipo WHERE idEquipo = " + numeroEquipo + " ;";


            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();
            MySqlConnection conexionbd1 = BD.Conexion();
            conexionbd1.Open();
            MySqlConnection conexionbd2 = BD.Conexion();
            conexionbd2.Open();
            MySqlConnection conexionbd3 = BD.Conexion();
            conexionbd3.Open();
            MySqlConnection conexionbd9 = BD.Conexion();
            conexionbd9.Open();

            MySqlConnection conexionbd10 = BD.Conexion();
            conexionbd10.Open();

            try
            {
                MySqlDataReader reader3 = null;
                MySqlCommand comando5 = new MySqlCommand(querySQL6, conexionbd3);
                reader3 = comando5.ExecuteReader();
                datosInsumos.Load(reader3);
                dataGridView1.DataSource = datosInsumos;
                dataGridView1.Columns[0].HeaderText = "Tipo";
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
                MySqlDataReader reader11 = null;
                MySqlCommand comando11 = new MySqlCommand(querySQL7, conexionbd10);
                reader11 = comando11.ExecuteReader();
                datosEquipo.Load(reader11);
                dataGridView2.DataSource = datosEquipo;
                dataGridView2.Columns[0].HeaderText = "Tipo";
                dataGridView2.Columns[1].HeaderText = "Marca";
                dataGridView2.Columns[2].HeaderText = "Modelo";
                dataGridView2.Columns[3].HeaderText = "Detalles";
                dataGridView2.Columns[4].HeaderText = "Accesorios";
                dataGridView2.Columns[5].HeaderText = "Diagnostico";
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message); }
            finally
            { conexionbd2.Close(); }


            try
            {
                MySqlDataReader reader3 = null;
                MySqlCommand comando5 = new MySqlCommand(querySQL6, conexionbd3);
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
            {       MySqlDataReader reader2 = null;
                    MySqlCommand comando4 = new MySqlCommand(querySQL2, conexionbd);
                    reader2 = comando4.ExecuteReader();
                    //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                    while (reader2.Read())
                    { datoscliente += reader2.GetString(0);}
                    textBox3.Text = datoscliente; }
            catch (MySqlException ex)
            {       MessageBox.Show("Error al traer el nombre del cliente: " + ex.Message);}
            finally
            {       conexionbd2.Close();}


            try
            {
                MySqlDataReader reader3 = null;
                MySqlCommand comando5 = new MySqlCommand(querySQL3, conexionbd3);
                reader3 = comando5.ExecuteReader();
                //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                while (reader3.Read())
                { datostelefono += reader3.GetString(0); }
                textBox4.Text = datostelefono;
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el numero de telefono: " + ex.Message); }
            finally
            { conexionbd3.Close(); }




            try
            {
                MySqlDataReader reader = null;
                MySqlCommand comando = new MySqlCommand(querySQL5, conexionbd9);
                reader = comando.ExecuteReader();
                //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                while (reader.Read())
                { estado += reader.GetString(0); }
                textBox1.Text = estado;
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el estado: " + ex.Message); }
            finally
            { conexionbd9.Close(); }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //este eventos es para que busque los equipos y sus insumos al darle enter
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(this, new EventArgs());
            }
        }
        //Borrar insumo
        private void button2_Click(object sender, EventArgs e)
        {
            String Nequipo = richTextBox2.Text;
            String Ninsumo = txtNumeroInsumo.Text;

            String querySQL = "DELETE FROM insumo WHERE idInsumo = "+Ninsumo+" AND equipo_idEquipo = "+Nequipo+";";
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(querySQL, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Insumo Eliminado");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar insumo: " + ex.Message);
            }
            finally
            {
                conexionbd.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form1>();
            Size = new Size(568, 1000);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.Size = new Size(568, 1000);
                panel1.Controls.Add(formulario);
                panel1.Tag = formulario;
                panel1.Size = new Size(568, 1000);
                // formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
                formulario.Size = new Size(568, 1000);
                formulario.Show();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            // if (Application.OpenForms["Form2"] == null)
            //btnFormCliente.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nEquipo = textBox2.Text;
            String clienteID = textBox2.Text;
            String querySQL = "USE larousee; SELECT cliente_idCLiente FROM equipo WHERE idEquipo = '"+nEquipo+"';";
            String querySQL1 = "USE larousee; DELETE FROM equipo WHERE idEquipo = '"+nEquipo+"';";
            String querySQL2 = "USE larousee; DELETE FROM cliente WHERE idCliente = '" + clienteID + "';";
            String querySQL3 = "USE larousee; DELETE FROM insumo WHERE equipo_idEquipo = '" + clienteID + "';";

            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();
            MySqlConnection conexionbd2 = BD.Conexion();
            conexionbd2.Open();
            MySqlConnection conexionbd3 = BD.Conexion();
            conexionbd3.Open();



            try
            {
                MySqlDataReader reader4 = null;
                MySqlCommand comando6 = new MySqlCommand(querySQL1, conexionbd2);
                comando6.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el equipo " );
                try
                {
                    MySqlDataReader reader5 = null;
                    MySqlCommand comando7 = new MySqlCommand(querySQL2, conexionbd2);
                    comando7.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado el cliente ");


                    try
                    {
                        MySqlDataReader reader6 = null;
                        MySqlCommand comando8 = new MySqlCommand(querySQL3, conexionbd3);
                        comando8.ExecuteNonQuery();
                        MessageBox.Show("Se ha eliminado los insumos");

                    }
                    catch (MySqlException ex)
                    { MessageBox.Show("Error al eliminar los insumos: " + ex.Message); }
                    finally
                    { conexionbd3.Close(); }



                }
                catch (MySqlException ex)
                { MessageBox.Show("Error al traer el numero de telefono: " + ex.Message); }
                finally
                { conexionbd2.Close(); }



            }
            catch (MySqlException ex)
            { MessageBox.Show("Error al traer el numero de telefono: " + ex.Message); }
            finally
            { conexionbd.Close(); }




        }

        private void txtNEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String diagnostico = richTextBox4.Text;
            String nEquipo = textBox5.Text;
            String querySQL = "USE larousee; UPDATE equipo SET diagnostico= '"+diagnostico+"' WHERE idEquipo = " + nEquipo + ";";
            MySqlConnection conexionbd = BD.Conexion();
            conexionbd.Open();



            try
            {
                MySqlDataReader reader3 = null;
                MySqlCommand comando5 = new MySqlCommand(querySQL, conexionbd);
                reader3 = comando5.ExecuteReader();
                MessageBox.Show("Diagnostico registrado");
            }
            catch (MySqlException ex)
            { MessageBox.Show("Error registrar diagnostico " + ex.Message); }
            finally
            { conexionbd.Close(); }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
