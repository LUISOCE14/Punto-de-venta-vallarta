
namespace Punto_de_venta_vallarta
{
    partial class ConsultarEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSelecccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.EditarEmpl = new FontAwesome.Sharp.IconButton();
            this.estadoEmple = new System.Windows.Forms.ComboBox();
            this.est = new System.Windows.Forms.Label();
            this.RolEmplea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telEmple = new System.Windows.Forms.TextBox();
            this.DirEmpl = new System.Windows.Forms.TextBox();
            this.NombreEmpl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CorreoEmple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosEmpleados
            // 
            this.DatosEmpleados.AllowUserToAddRows = false;
            this.DatosEmpleados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelecccionar,
            this.ID,
            this.NombreEm,
            this.Direccion,
            this.Telefono,
            this.CorreoEmpleado,
            this.idCargo,
            this.Cargo,
            this.estadoValor,
            this.Estado});
            this.DatosEmpleados.Location = new System.Drawing.Point(300, 178);
            this.DatosEmpleados.MultiSelect = false;
            this.DatosEmpleados.Name = "DatosEmpleados";
            this.DatosEmpleados.ReadOnly = true;
            this.DatosEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosEmpleados.RowTemplate.Height = 28;
            this.DatosEmpleados.Size = new System.Drawing.Size(937, 418);
            this.DatosEmpleados.TabIndex = 38;
            this.DatosEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosEmpleados_CellContentClick);
            this.DatosEmpleados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosEmpleados_CellPainting);
            // 
            // btnSelecccionar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.btnSelecccionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSelecccionar.HeaderText = "";
            this.btnSelecccionar.MinimumWidth = 6;
            this.btnSelecccionar.Name = "btnSelecccionar";
            this.btnSelecccionar.ReadOnly = true;
            this.btnSelecccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelecccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelecccionar.Width = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // NombreEm
            // 
            this.NombreEm.HeaderText = "Nombre";
            this.NombreEm.MinimumWidth = 6;
            this.NombreEm.Name = "NombreEm";
            this.NombreEm.ReadOnly = true;
            this.NombreEm.Width = 180;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 160;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 110;
            // 
            // CorreoEmpleado
            // 
            this.CorreoEmpleado.HeaderText = "Correo";
            this.CorreoEmpleado.MinimumWidth = 6;
            this.CorreoEmpleado.Name = "CorreoEmpleado";
            this.CorreoEmpleado.ReadOnly = true;
            this.CorreoEmpleado.Width = 160;
            // 
            // idCargo
            // 
            this.idCargo.HeaderText = "idCargo";
            this.idCargo.MinimumWidth = 6;
            this.idCargo.Name = "idCargo";
            this.idCargo.ReadOnly = true;
            this.idCargo.Visible = false;
            this.idCargo.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "estadoValor";
            this.estadoValor.MinimumWidth = 6;
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Visible = false;
            this.estadoValor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 85;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(597, 118);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(171, 28);
            this.cbobusqueda.TabIndex = 223;
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus.Location = new System.Drawing.Point(774, 120);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(205, 26);
            this.txtBus.TabIndex = 222;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 24;
            this.btnLimpiar.Location = new System.Drawing.Point(1051, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 29);
            this.btnLimpiar.TabIndex = 221;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.Location = new System.Drawing.Point(1001, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 29);
            this.btnBuscar.TabIndex = 220;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 219;
            this.label7.Text = "Buscar  Por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(651, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 82);
            this.label9.TabIndex = 218;
            this.label9.Text = "Lista de Empleados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 632);
            this.label10.TabIndex = 224;
            // 
            // txtIn
            // 
            this.txtIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIn.Location = new System.Drawing.Point(190, 104);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(29, 22);
            this.txtIn.TabIndex = 240;
            this.txtIn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 239;
            this.label2.Text = "Detalles del Empleado";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(225, 104);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(38, 22);
            this.txtid.TabIndex = 238;
            this.txtid.Visible = false;
            // 
            // EditarEmpl
            // 
            this.EditarEmpl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarEmpl.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarEmpl.IconColor = System.Drawing.Color.Black;
            this.EditarEmpl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarEmpl.IconSize = 20;
            this.EditarEmpl.Location = new System.Drawing.Point(51, 510);
            this.EditarEmpl.Name = "EditarEmpl";
            this.EditarEmpl.Size = new System.Drawing.Size(155, 48);
            this.EditarEmpl.TabIndex = 237;
            this.EditarEmpl.Text = "Editar";
            this.EditarEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarEmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarEmpl.UseVisualStyleBackColor = false;
            this.EditarEmpl.Click += new System.EventHandler(this.EditarEmpl_Click);
            // 
            // estadoEmple
            // 
            this.estadoEmple.BackColor = System.Drawing.Color.White;
            this.estadoEmple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoEmple.FormattingEnabled = true;
            this.estadoEmple.Location = new System.Drawing.Point(25, 459);
            this.estadoEmple.Name = "estadoEmple";
            this.estadoEmple.Size = new System.Drawing.Size(207, 28);
            this.estadoEmple.TabIndex = 236;
            // 
            // est
            // 
            this.est.AutoSize = true;
            this.est.BackColor = System.Drawing.Color.White;
            this.est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.est.Location = new System.Drawing.Point(23, 436);
            this.est.Name = "est";
            this.est.Size = new System.Drawing.Size(66, 20);
            this.est.TabIndex = 235;
            this.est.Text = "Estado:";
            // 
            // RolEmplea
            // 
            this.RolEmplea.BackColor = System.Drawing.Color.White;
            this.RolEmplea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolEmplea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolEmplea.FormattingEnabled = true;
            this.RolEmplea.Location = new System.Drawing.Point(25, 398);
            this.RolEmplea.Name = "RolEmplea";
            this.RolEmplea.Size = new System.Drawing.Size(206, 28);
            this.RolEmplea.TabIndex = 234;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 233;
            this.label6.Text = "Cargo:";
            // 
            // telEmple
            // 
            this.telEmple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEmple.Location = new System.Drawing.Point(25, 286);
            this.telEmple.Name = "telEmple";
            this.telEmple.Size = new System.Drawing.Size(206, 27);
            this.telEmple.TabIndex = 231;
            // 
            // DirEmpl
            // 
            this.DirEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirEmpl.Location = new System.Drawing.Point(24, 217);
            this.DirEmpl.Name = "DirEmpl";
            this.DirEmpl.Size = new System.Drawing.Size(206, 27);
            this.DirEmpl.TabIndex = 230;
            // 
            // NombreEmpl
            // 
            this.NombreEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpl.Location = new System.Drawing.Point(25, 158);
            this.NombreEmpl.Name = "NombreEmpl";
            this.NombreEmpl.Size = new System.Drawing.Size(206, 27);
            this.NombreEmpl.TabIndex = 229;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 227;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 226;
            this.label3.Text = "Direccion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 225;
            this.label8.Text = "Nombre Completo:";
            // 
            // CorreoEmple
            // 
            this.CorreoEmple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorreoEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoEmple.Location = new System.Drawing.Point(24, 345);
            this.CorreoEmple.Name = "CorreoEmple";
            this.CorreoEmple.Size = new System.Drawing.Size(206, 27);
            this.CorreoEmple.TabIndex = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 241;
            this.label1.Text = "Correo:";
            // 
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.CorreoEmple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.EditarEmpl);
            this.Controls.Add(this.estadoEmple);
            this.Controls.Add(this.est);
            this.Controls.Add(this.RolEmplea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telEmple);
            this.Controls.Add(this.DirEmpl);
            this.Controls.Add(this.NombreEmpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatosEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEmpleados";
            this.Text = "ConsultarEmpleados";
            this.Load += new System.EventHandler(this.ConsultarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosEmpleados;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtBus;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton EditarEmpl;
        private System.Windows.Forms.ComboBox estadoEmple;
        private System.Windows.Forms.Label est;
        private System.Windows.Forms.ComboBox RolEmplea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telEmple;
        private System.Windows.Forms.TextBox DirEmpl;
        private System.Windows.Forms.TextBox NombreEmpl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CorreoEmple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelecccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}