namespace Base
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.ApellidoP = new System.Windows.Forms.TextBox();
            this.ApellidoM = new System.Windows.Forms.TextBox();
            this.correo_txt = new System.Windows.Forms.TextBox();
            this.contraseña_txt = new System.Windows.Forms.TextBox();
            this.contraseña2_txt = new System.Windows.Forms.TextBox();
            this.telefono_txt = new System.Windows.Forms.TextBox();
            this.Trabajo_txt = new System.Windows.Forms.TextBox();
            this.Direccion_txt = new System.Windows.Forms.TextBox();
            this.Tarjeta_txt = new System.Windows.Forms.TextBox();
            this.cvv_txt = new System.Windows.Forms.TextBox();
            this.CI_txt = new System.Windows.Forms.TextBox();
            this.RFC_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Targeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_interbancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.Button();
            this.siguiente_button = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(569, 640);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(109, 37);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(702, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido Materno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(372, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(77, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(77, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(77, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(372, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contraseña:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(372, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trabajo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(365, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(198, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "¿Tienes especialidad?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(702, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Direccion:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(77, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "RFC:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(543, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Clave Interbancaria:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(77, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tarjeta";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(372, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "CVV";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label14.Location = new System.Drawing.Point(261, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(493, 39);
            this.label14.TabIndex = 15;
            this.label14.Text = "REGISTRO DE TRABAJADOR";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(702, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Repite Contraseña:";
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre_txt.Location = new System.Drawing.Point(81, 111);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(246, 22);
            this.Nombre_txt.TabIndex = 0;
            // 
            // ApellidoP
            // 
            this.ApellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApellidoP.Location = new System.Drawing.Point(365, 111);
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Size = new System.Drawing.Size(246, 22);
            this.ApellidoP.TabIndex = 18;
            this.ApellidoP.TextChanged += new System.EventHandler(this.Ap_txt_TextChanged);
            // 
            // ApellidoM
            // 
            this.ApellidoM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApellidoM.Location = new System.Drawing.Point(695, 111);
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Size = new System.Drawing.Size(246, 22);
            this.ApellidoM.TabIndex = 19;
            // 
            // correo_txt
            // 
            this.correo_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correo_txt.Location = new System.Drawing.Point(81, 223);
            this.correo_txt.Name = "correo_txt";
            this.correo_txt.Size = new System.Drawing.Size(246, 22);
            this.correo_txt.TabIndex = 20;
            this.correo_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseña_txt.Location = new System.Drawing.Point(365, 223);
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.Size = new System.Drawing.Size(246, 22);
            this.contraseña_txt.TabIndex = 21;
            // 
            // contraseña2_txt
            // 
            this.contraseña2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseña2_txt.Location = new System.Drawing.Point(695, 223);
            this.contraseña2_txt.Name = "contraseña2_txt";
            this.contraseña2_txt.Size = new System.Drawing.Size(246, 22);
            this.contraseña2_txt.TabIndex = 22;
            // 
            // telefono_txt
            // 
            this.telefono_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telefono_txt.Location = new System.Drawing.Point(81, 336);
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(246, 22);
            this.telefono_txt.TabIndex = 23;
            // 
            // Trabajo_txt
            // 
            this.Trabajo_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trabajo_txt.Location = new System.Drawing.Point(366, 336);
            this.Trabajo_txt.Name = "Trabajo_txt";
            this.Trabajo_txt.Size = new System.Drawing.Size(246, 22);
            this.Trabajo_txt.TabIndex = 24;
            // 
            // Direccion_txt
            // 
            this.Direccion_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Direccion_txt.Location = new System.Drawing.Point(695, 336);
            this.Direccion_txt.Name = "Direccion_txt";
            this.Direccion_txt.Size = new System.Drawing.Size(246, 22);
            this.Direccion_txt.TabIndex = 25;
            // 
            // Tarjeta_txt
            // 
            this.Tarjeta_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tarjeta_txt.Location = new System.Drawing.Point(81, 513);
            this.Tarjeta_txt.Name = "Tarjeta_txt";
            this.Tarjeta_txt.Size = new System.Drawing.Size(246, 22);
            this.Tarjeta_txt.TabIndex = 26;
            // 
            // cvv_txt
            // 
            this.cvv_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvv_txt.Location = new System.Drawing.Point(366, 513);
            this.cvv_txt.Name = "cvv_txt";
            this.cvv_txt.Size = new System.Drawing.Size(96, 22);
            this.cvv_txt.TabIndex = 27;
            // 
            // CI_txt
            // 
            this.CI_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CI_txt.Location = new System.Drawing.Point(547, 516);
            this.CI_txt.Name = "CI_txt";
            this.CI_txt.Size = new System.Drawing.Size(246, 22);
            this.CI_txt.TabIndex = 28;
            // 
            // RFC_txt
            // 
            this.RFC_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RFC_txt.Location = new System.Drawing.Point(81, 604);
            this.RFC_txt.Name = "RFC_txt";
            this.RFC_txt.Size = new System.Drawing.Size(246, 22);
            this.RFC_txt.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Correo,
            this.Contraseña,
            this.Telefono,
            this.Trabajo,
            this.Direccion,
            this.Targeta,
            this.CVV,
            this.Clave_interbancaria,
            this.RFC});
            this.dataGridView1.Location = new System.Drawing.Point(98, 713);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido Paterno";
            this.Apellido_Paterno.MinimumWidth = 6;
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            this.Apellido_Paterno.Width = 125;
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido Materno";
            this.Apellido_Materno.MinimumWidth = 6;
            this.Apellido_Materno.Name = "Apellido_Materno";
            this.Apellido_Materno.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Trabajo
            // 
            this.Trabajo.HeaderText = "Trabajo";
            this.Trabajo.MinimumWidth = 6;
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Targeta
            // 
            this.Targeta.HeaderText = "Targeta";
            this.Targeta.MinimumWidth = 6;
            this.Targeta.Name = "Targeta";
            this.Targeta.Width = 125;
            // 
            // CVV
            // 
            this.CVV.HeaderText = "CVV";
            this.CVV.MinimumWidth = 6;
            this.CVV.Name = "CVV";
            this.CVV.Width = 125;
            // 
            // Clave_interbancaria
            // 
            this.Clave_interbancaria.HeaderText = "Clave Interbancaria";
            this.Clave_interbancaria.MinimumWidth = 6;
            this.Clave_interbancaria.Name = "Clave_interbancaria";
            this.Clave_interbancaria.Width = 125;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 6;
            this.RFC.Name = "RFC";
            this.RFC.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(141, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 31;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(799, 640);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(109, 37);
            this.Borrar.TabIndex = 32;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // siguiente_button
            // 
            this.siguiente_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.siguiente_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siguiente_button.Location = new System.Drawing.Point(914, 640);
            this.siguiente_button.Name = "siguiente_button";
            this.siguiente_button.Size = new System.Drawing.Size(109, 37);
            this.siguiente_button.TabIndex = 33;
            this.siguiente_button.Text = "Siguiente";
            this.siguiente_button.UseVisualStyleBackColor = false;
            this.siguiente_button.Click += new System.EventHandler(this.siguiente_button_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(684, 640);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(109, 37);
            this.buscar.TabIndex = 34;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 946);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.siguiente_button);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RFC_txt);
            this.Controls.Add(this.CI_txt);
            this.Controls.Add(this.cvv_txt);
            this.Controls.Add(this.Tarjeta_txt);
            this.Controls.Add(this.Direccion_txt);
            this.Controls.Add(this.Trabajo_txt);
            this.Controls.Add(this.telefono_txt);
            this.Controls.Add(this.contraseña2_txt);
            this.Controls.Add(this.contraseña_txt);
            this.Controls.Add(this.correo_txt);
            this.Controls.Add(this.ApellidoM);
            this.Controls.Add(this.ApellidoP);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Nombre_txt;
        private System.Windows.Forms.TextBox ApellidoP;
        private System.Windows.Forms.TextBox ApellidoM;
        private System.Windows.Forms.TextBox correo_txt;
        private System.Windows.Forms.TextBox contraseña_txt;
        private System.Windows.Forms.TextBox contraseña2_txt;
        private System.Windows.Forms.TextBox telefono_txt;
        private System.Windows.Forms.TextBox Trabajo_txt;
        private System.Windows.Forms.TextBox Direccion_txt;
        private System.Windows.Forms.TextBox Tarjeta_txt;
        private System.Windows.Forms.TextBox cvv_txt;
        private System.Windows.Forms.TextBox CI_txt;
        private System.Windows.Forms.TextBox RFC_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Targeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_interbancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button siguiente_button;
        private System.Windows.Forms.Button buscar;
    }
}

