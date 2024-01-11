
namespace Punto_de_venta_vallarta
{
    partial class ConsultarCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.DatosCompra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nomEmp = new System.Windows.Forms.TextBox();
            this.IdEmpleado = new System.Windows.Forms.TextBox();
            this.IDCOMPRA = new System.Windows.Forms.TextBox();
            this.Fecha1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Empresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.correoProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelefonoProvee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreProvee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Iva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(1112, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 217;
            this.label10.Text = "Total:";
            // 
            // DatosCompra
            // 
            this.DatosCompra.AllowUserToAddRows = false;
            this.DatosCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DatosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Modelo,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.DatosCompra.Location = new System.Drawing.Point(152, 319);
            this.DatosCompra.MultiSelect = false;
            this.DatosCompra.Name = "DatosCompra";
            this.DatosCompra.ReadOnly = true;
            this.DatosCompra.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosCompra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DatosCompra.RowTemplate.Height = 28;
            this.DatosCompra.Size = new System.Drawing.Size(889, 285);
            this.DatosCompra.TabIndex = 216;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Producto";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 170;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio ";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 120;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.Control;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Enabled = false;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(1064, 510);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(161, 30);
            this.Total.TabIndex = 218;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(957, 27);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 35);
            this.btnLimpiar.TabIndex = 213;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(670, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 30);
            this.txtBuscar.TabIndex = 212;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(835, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 34);
            this.btnBuscar.TabIndex = 211;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 33);
            this.label7.TabIndex = 210;
            this.label7.Text = "ID Compra :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 40);
            this.label2.TabIndex = 209;
            this.label2.Text = "Detalles de compra";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1213, 225);
            this.groupBox3.TabIndex = 236;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de compra";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.nomEmp);
            this.groupBox5.Controls.Add(this.IdEmpleado);
            this.groupBox5.Controls.Add(this.IDCOMPRA);
            this.groupBox5.Controls.Add(this.Fecha1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(558, 165);
            this.groupBox5.TabIndex = 100;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion Compra";
            // 
            // nomEmp
            // 
            this.nomEmp.BackColor = System.Drawing.SystemColors.Control;
            this.nomEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomEmp.Enabled = false;
            this.nomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomEmp.Location = new System.Drawing.Point(235, 106);
            this.nomEmp.Name = "nomEmp";
            this.nomEmp.Size = new System.Drawing.Size(289, 26);
            this.nomEmp.TabIndex = 57;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.IdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdEmpleado.Enabled = false;
            this.IdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IdEmpleado.Location = new System.Drawing.Point(35, 106);
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Size = new System.Drawing.Size(128, 26);
            this.IdEmpleado.TabIndex = 56;
            // 
            // IDCOMPRA
            // 
            this.IDCOMPRA.BackColor = System.Drawing.SystemColors.Control;
            this.IDCOMPRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDCOMPRA.Enabled = false;
            this.IDCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IDCOMPRA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDCOMPRA.Location = new System.Drawing.Point(236, 36);
            this.IDCOMPRA.Name = "IDCOMPRA";
            this.IDCOMPRA.Size = new System.Drawing.Size(119, 26);
            this.IDCOMPRA.TabIndex = 55;
            // 
            // Fecha1
            // 
            this.Fecha1.BackColor = System.Drawing.SystemColors.Control;
            this.Fecha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fecha1.Enabled = false;
            this.Fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fecha1.Location = new System.Drawing.Point(35, 40);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(155, 26);
            this.Fecha1.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "ID Empleado:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Control;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(233, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 18);
            this.label26.TabIndex = 50;
            this.label26.Text = "ID Compra:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(232, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 20);
            this.label27.TabIndex = 2;
            this.label27.Text = "Empleado:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(31, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 20);
            this.label28.TabIndex = 1;
            this.label28.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.Empresa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.correoProveedor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TelefonoProvee);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nombreProvee);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(573, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 165);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // Empresa
            // 
            this.Empresa.BackColor = System.Drawing.SystemColors.Control;
            this.Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Empresa.Enabled = false;
            this.Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Empresa.Location = new System.Drawing.Point(285, 106);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(330, 26);
            this.Empresa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 88);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empresa:";
            // 
            // correoProveedor
            // 
            this.correoProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.correoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correoProveedor.Enabled = false;
            this.correoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.correoProveedor.Location = new System.Drawing.Point(18, 106);
            this.correoProveedor.Name = "correoProveedor";
            this.correoProveedor.Size = new System.Drawing.Size(248, 26);
            this.correoProveedor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Correo :";
            // 
            // TelefonoProvee
            // 
            this.TelefonoProvee.BackColor = System.Drawing.SystemColors.Control;
            this.TelefonoProvee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonoProvee.Enabled = false;
            this.TelefonoProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoProvee.Location = new System.Drawing.Point(426, 51);
            this.TelefonoProvee.Name = "TelefonoProvee";
            this.TelefonoProvee.Size = new System.Drawing.Size(189, 24);
            this.TelefonoProvee.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 26);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // nombreProvee
            // 
            this.nombreProvee.BackColor = System.Drawing.SystemColors.Control;
            this.nombreProvee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreProvee.Enabled = false;
            this.nombreProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProvee.Location = new System.Drawing.Point(163, 51);
            this.nombreProvee.Name = "nombreProvee";
            this.nombreProvee.Size = new System.Drawing.Size(257, 24);
            this.nombreProvee.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 24);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nombre :";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(19, 51);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(132, 24);
            this.txtIdCliente.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1104, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 237;
            this.label3.Text = "IVA %16:";
            // 
            // Iva
            // 
            this.Iva.BackColor = System.Drawing.SystemColors.Control;
            this.Iva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Iva.Enabled = false;
            this.Iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iva.Location = new System.Drawing.Point(1064, 448);
            this.Iva.Name = "Iva";
            this.Iva.Size = new System.Drawing.Size(161, 30);
            this.Iva.TabIndex = 238;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1104, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 239;
            this.label4.Text = "SubTotal:";
            // 
            // subtotal
            // 
            this.subtotal.BackColor = System.Drawing.SystemColors.Control;
            this.subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotal.Enabled = false;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(1064, 389);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(161, 30);
            this.subtotal.TabIndex = 240;
            // 
            // ConsultarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Iva);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DatosCompra);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarCompras";
            this.Text = "ConsultarCompras";
            ((System.ComponentModel.ISupportInitialize)(this.DatosCompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DatosCompra;
        private System.Windows.Forms.TextBox Total;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox correoProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TelefonoProvee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreProvee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox nomEmp;
        private System.Windows.Forms.TextBox IdEmpleado;
        private System.Windows.Forms.TextBox IDCOMPRA;
        private System.Windows.Forms.TextBox Fecha1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Iva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subtotal;
    }
}