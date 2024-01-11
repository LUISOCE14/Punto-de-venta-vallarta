
namespace Punto_de_venta_vallarta
{
    partial class ConsultarProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DatosProveedores = new System.Windows.Forms.DataGridView();
            this.txtIndi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.EditPro = new FontAwesome.Sharp.IconButton();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.est = new System.Windows.Forms.Label();
            this.CorrPro = new System.Windows.Forms.TextBox();
            this.TelProv = new System.Windows.Forms.TextBox();
            this.NomEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NombreProved = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadovalor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(607, 107);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(171, 28);
            this.cbobusqueda.TabIndex = 223;
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus.Location = new System.Drawing.Point(784, 109);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1061, 108);
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
            this.btnBuscar.Location = new System.Drawing.Point(1011, 108);
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
            this.label7.Location = new System.Drawing.Point(470, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 219;
            this.label7.Text = "Buscar  Por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(655, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 82);
            this.label9.TabIndex = 218;
            this.label9.Text = "Lista de Proveedores";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 632);
            this.label10.TabIndex = 224;
            // 
            // DatosProveedores
            // 
            this.DatosProveedores.AllowUserToAddRows = false;
            this.DatosProveedores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DatosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelecccionar,
            this.Codigo,
            this.Nombre,
            this.Empresa,
            this.Telefono,
            this.Correo,
            this.estadovalor,
            this.Estado});
            this.DatosProveedores.Location = new System.Drawing.Point(319, 192);
            this.DatosProveedores.MultiSelect = false;
            this.DatosProveedores.Name = "DatosProveedores";
            this.DatosProveedores.ReadOnly = true;
            this.DatosProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosProveedores.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DatosProveedores.RowTemplate.Height = 28;
            this.DatosProveedores.Size = new System.Drawing.Size(909, 391);
            this.DatosProveedores.TabIndex = 225;
            this.DatosProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosProveedores_CellContentClick);
            this.DatosProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosProveedores_CellPainting);
            // 
            // txtIndi
            // 
            this.txtIndi.Location = new System.Drawing.Point(196, 93);
            this.txtIndi.Name = "txtIndi";
            this.txtIndi.Size = new System.Drawing.Size(32, 22);
            this.txtIndi.TabIndex = 237;
            this.txtIndi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 236;
            this.label2.Text = "Detalles del Proveedor";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(234, 93);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(32, 22);
            this.txtid.TabIndex = 235;
            this.txtid.Visible = false;
            // 
            // EditPro
            // 
            this.EditPro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPro.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditPro.IconColor = System.Drawing.Color.Black;
            this.EditPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditPro.IconSize = 20;
            this.EditPro.Location = new System.Drawing.Point(73, 464);
            this.EditPro.Name = "EditPro";
            this.EditPro.Size = new System.Drawing.Size(155, 40);
            this.EditPro.TabIndex = 234;
            this.EditPro.Text = "Editar";
            this.EditPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditPro.UseVisualStyleBackColor = false;
            this.EditPro.Click += new System.EventHandler(this.EditPro_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.White;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(38, 398);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(221, 28);
            this.cboEstado.TabIndex = 233;
            // 
            // est
            // 
            this.est.AutoSize = true;
            this.est.BackColor = System.Drawing.Color.White;
            this.est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.est.Location = new System.Drawing.Point(37, 375);
            this.est.Name = "est";
            this.est.Size = new System.Drawing.Size(66, 20);
            this.est.TabIndex = 232;
            this.est.Text = "Estado:";
            // 
            // CorrPro
            // 
            this.CorrPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorrPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrPro.Location = new System.Drawing.Point(38, 336);
            this.CorrPro.Name = "CorrPro";
            this.CorrPro.Size = new System.Drawing.Size(221, 27);
            this.CorrPro.TabIndex = 231;
            // 
            // TelProv
            // 
            this.TelProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TelProv.Location = new System.Drawing.Point(39, 278);
            this.TelProv.Name = "TelProv";
            this.TelProv.Size = new System.Drawing.Size(220, 26);
            this.TelProv.TabIndex = 230;
            // 
            // NomEmpresa
            // 
            this.NomEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomEmpresa.Location = new System.Drawing.Point(41, 219);
            this.NomEmpresa.Name = "NomEmpresa";
            this.NomEmpresa.Size = new System.Drawing.Size(218, 27);
            this.NomEmpresa.TabIndex = 229;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 228;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 227;
            this.label3.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(37, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 226;
            this.label8.Text = "Empresa:";
            // 
            // NombreProved
            // 
            this.NombreProved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreProved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProved.Location = new System.Drawing.Point(40, 153);
            this.NombreProved.Name = "NombreProved";
            this.NombreProved.Size = new System.Drawing.Size(226, 27);
            this.NombreProved.TabIndex = 239;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 238;
            this.label1.Text = "Nombre de proveedor:";
            // 
            // btnSelecccionar
            // 
            this.btnSelecccionar.HeaderText = "";
            this.btnSelecccionar.MinimumWidth = 6;
            this.btnSelecccionar.Name = "btnSelecccionar";
            this.btnSelecccionar.ReadOnly = true;
            this.btnSelecccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelecccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelecccionar.Width = 32;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.MinimumWidth = 6;
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 160;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 180;
            // 
            // estadovalor
            // 
            this.estadovalor.HeaderText = "EstadoValor";
            this.estadovalor.MinimumWidth = 6;
            this.estadovalor.Name = "estadovalor";
            this.estadovalor.ReadOnly = true;
            this.estadovalor.Visible = false;
            this.estadovalor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 90;
            // 
            // ConsultarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.NombreProved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.EditPro);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.est);
            this.Controls.Add(this.CorrPro);
            this.Controls.Add(this.TelProv);
            this.Controls.Add(this.NomEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DatosProveedores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProveedores";
            this.Text = "ConsultarProveedores";
            this.Load += new System.EventHandler(this.ConsultarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtBus;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DatosProveedores;
        private System.Windows.Forms.TextBox txtIndi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton EditPro;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label est;
        private System.Windows.Forms.TextBox CorrPro;
        private System.Windows.Forms.TextBox TelProv;
        private System.Windows.Forms.TextBox NomEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombreProved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelecccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadovalor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}