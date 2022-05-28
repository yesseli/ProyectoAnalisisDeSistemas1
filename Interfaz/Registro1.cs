using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        public int numeroEquipo;
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
           
            Ticket.Enabled = true;
            Ticket.BackColor= Color.FromArgb(52, 207, 252);
            //De aqui toma los valores de los textbox
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
            //Este formato de fecha se puede cambiar, no mas hay que saber como va xd en internet se puede conseguir
            String localDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // aqui hace l;a consulta en la base de datos, se une en un string pa mandarselo despues
            // Nota, el default es porque el idcliente es autoincrementable y asi me ahorro programar un monton xd
            String querySQL1 = "USE larousee; INSERT INTO cliente VALUES (default,'" + nombreCliente + "', '" + numero + "') ";
            String querySQL2 = "USE larousee; INSERT INTO equipo VALUES(default, '" + tipo+"','"+marca+"', '"+modelo+"','"+detalles+"', '"+motivo+"', '"+estado+"', '"+diagnostico+"', '"+articulos+"', (SELECT  idCliente FROM cliente ORDER BY idCliente DESC LIMIT 1), '"+localDate+"' )";
            //Para obtener el numero del equipo
            String querySQL3 = "USE larousee; SELECT  idCliente FROM cliente ORDER BY idCliente DESC LIMIT 1";
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
                    try
                    {
                        MySqlDataReader  reader = null;
                        MySqlCommand comando2 = new MySqlCommand(querySQL3, conexionbd);
                        reader = comando2.ExecuteReader();
                        //Siempre se tiene que verificar el reader si esta leyendo, poner solo el getstring no funciona, para eso es el if q(≧▽≦q)
                        if (reader.Read())
                        {
                            richTextBox1.Text = reader.GetString(0);
                            numeroEquipo = reader.GetInt32(0);
                        }
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al traer el dato: " + ex.Message);
                    }
                    finally
                    {
                        conexionbd.Close();
                    }
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

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }
        // De aqui para abajo es codigo que nos ayuda a imprimir el ticket hay que ponerle un printerdocument en la parte del designer
        private void Ticket_Click(object sender, EventArgs e)
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();

            printDocument1.PrinterSettings = ps;
            //Nombre de la impresora que se va usar
            printDocument1.PrinterSettings.PrinterName = "PDFCreator";
            //Tamaño de la impresora
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("200 x 100 mm", 200, 200);
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            String nombreCliente = txtNombreCliente.Text;
            String localDate = DateTime.Now.ToString("yyyy-MM-dd");
            int Y = 25;
            Font fontTitulo = new Font("Product Sans", 16, FontStyle.Regular, GraphicsUnit.Point);
            Font normal = new Font("Product Sans", 11, FontStyle.Regular, GraphicsUnit.Point);
            Font numEquipo = new Font("Product Sans", 50, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("LAROUSEE", fontTitulo, Brushes.Black, new RectangleF(45, 15, 140, 25));
            e.Graphics.DrawString("Equipo", normal, Brushes.Black, new RectangleF(75, Y += 17, 140, 20));
            e.Graphics.DrawString("#"+numeroEquipo, numEquipo, Brushes.Black, new RectangleF(25, Y += 17, 240, 70));
            e.Graphics.DrawString("Cliente: "+ nombreCliente, normal, Brushes.Black, new RectangleF(25, Y += 80, 240, 20));
            e.Graphics.DrawString("Fecha: "+localDate, normal, Brushes.Black, new RectangleF(30, Y += 23, 240, 20));
        }


    }
}
