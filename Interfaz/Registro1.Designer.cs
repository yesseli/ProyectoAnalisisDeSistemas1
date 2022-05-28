namespace interfazServicios
{
    partial class formServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelchilero1 = new interfazServicios.Panelchilero();
            this.Ticket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtDetalles = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtArticulos = new System.Windows.Forms.RichTextBox();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panelchilero1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.panelchilero1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 953);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelchilero1
            // 
            this.panelchilero1.BackColor = System.Drawing.Color.White;
            this.panelchilero1.ColorDeAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(254)))), ((int)(((byte)(245)))));
            this.panelchilero1.Colordearriba1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.panelchilero1.Controls.Add(this.Ticket);
            this.panelchilero1.Controls.Add(this.label8);
            this.panelchilero1.Controls.Add(this.richTextBox1);
            this.panelchilero1.Controls.Add(this.txtDetalles);
            this.panelchilero1.Controls.Add(this.label7);
            this.panelchilero1.Controls.Add(this.label5);
            this.panelchilero1.Controls.Add(this.txtModelo);
            this.panelchilero1.Controls.Add(this.button3);
            this.panelchilero1.Controls.Add(this.txtArticulos);
            this.panelchilero1.Controls.Add(this.txtMotivo);
            this.panelchilero1.Controls.Add(this.label6);
            this.panelchilero1.Controls.Add(this.label4);
            this.panelchilero1.Controls.Add(this.txtMarca);
            this.panelchilero1.Controls.Add(this.txtTipo);
            this.panelchilero1.Controls.Add(this.label3);
            this.panelchilero1.Controls.Add(this.label2);
            this.panelchilero1.Controls.Add(this.label1);
            this.panelchilero1.Controls.Add(this.txtNumero);
            this.panelchilero1.Controls.Add(this.txtNombreCliente);
            this.panelchilero1.Degradado = 30F;
            this.panelchilero1.ForeColor = System.Drawing.Color.Black;
            this.panelchilero1.Location = new System.Drawing.Point(32, 103);
            this.panelchilero1.Name = "panelchilero1";
            this.panelchilero1.Radiodelborde = 30;
            this.panelchilero1.Size = new System.Drawing.Size(480, 838);
            this.panelchilero1.TabIndex = 17;
            // 
            // Ticket
            // 
            this.Ticket.BackColor = System.Drawing.Color.SlateGray;
            this.Ticket.Enabled = false;
            this.Ticket.Font = new System.Drawing.Font("Product Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Ticket.Location = new System.Drawing.Point(185, 710);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(122, 102);
            this.Ticket.TabIndex = 30;
            this.Ticket.Text = "Ticket";
            this.Ticket.UseVisualStyleBackColor = false;
            this.Ticket.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(313, 708);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "N u m e r o:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Product Sans", 29.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(313, 736);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(106, 76);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(58, 284);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(361, 74);
            this.txtDetalles.TabIndex = 27;
            this.txtDetalles.Text = "";
            this.txtDetalles.TextChanged += new System.EventHandler(this.txtDetalles_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(58, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Detalles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(59, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Modelo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(58, 195);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PlaceholderText = "Ej. 15-cs0087fl";
            this.txtModelo.Size = new System.Drawing.Size(157, 27);
            this.txtModelo.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.button3.Font = new System.Drawing.Font("Product Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(58, 710);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 102);
            this.button3.TabIndex = 23;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(59, 629);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(361, 60);
            this.txtArticulos.TabIndex = 16;
            this.txtArticulos.Text = "";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(58, 422);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(361, 74);
            this.txtMotivo.TabIndex = 16;
            this.txtMotivo.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(59, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Artículos Extra";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(58, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Motivo de Entrega";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(252, 121);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Ej. HP";
            this.txtMarca.Size = new System.Drawing.Size(168, 27);
            this.txtMarca.TabIndex = 12;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(59, 121);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PlaceholderText = "Ej. Impresora";
            this.txtTipo.Size = new System.Drawing.Size(156, 27);
            this.txtTipo.TabIndex = 12;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(59, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo y Marca del Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(58, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero de Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Cliente";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(58, 550);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(361, 27);
            this.txtNumero.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(59, 50);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(361, 27);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 74);
            this.panel2.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Product Sans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(102, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 59);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Registro";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::interfazServicios.Properties.Resources._4;
            this.btnVolver.Location = new System.Drawing.Point(22, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(44, 46);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 1;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(550, 953);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form3";
            this.panel1.ResumeLayout(false);
            this.panelchilero1.ResumeLayout(false);
            this.panelchilero1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox btnVolver;
        private Label lblTitulo;
        private TextBox txtNombreCliente;
        private Panel panel2;
        private TextBox txtNumero;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMarca;
        private TextBox txtTipo;
        private Label label4;
        private RichTextBox txtArticulos;
        private RichTextBox txtMotivo;
        private Label label6;
        private Panelchilero panelchilero1;
        private Button button3;
        private Label label5;
        private TextBox txtModelo;
        private RichTextBox txtDetalles;
        private Label label7;
        private Label label8;
        private RichTextBox richTextBox1;
        private Button Ticket;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}