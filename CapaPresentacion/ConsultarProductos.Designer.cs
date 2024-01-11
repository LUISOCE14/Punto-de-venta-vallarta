
namespace Punto_de_venta_vallarta
{
    partial class ConsultarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosProd = new System.Windows.Forms.DataGridView();
            this.btnSelecccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.ValorVentaPr = new System.Windows.Forms.TextBox();
            this.DescripcionProd = new System.Windows.Forms.TextBox();
            this.nombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditarProd = new FontAwesome.Sharp.IconButton();
            this.valorCompraPr = new System.Windows.Forms.TextBox();
            this.ModeloP = new System.Windows.Forms.TextBox();
            this.Exis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 130;
            this.label2.Text = "Detalles del Productos";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 632);
            this.label10.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 605);
            this.label1.TabIndex = 118;
            // 
            // DatosProd
            // 
            this.DatosProd.AllowUserToAddRows = false;
            this.DatosProd.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelecccionar,
            this.ID,
            this.nombre,
            this.Modelo,
            this.Descripcion,
            this.valorVenta,
            this.ValorCompra,
            this.Existencias});
            this.DatosProd.Location = new System.Drawing.Point(332, 194);
            this.DatosProd.MultiSelect = false;
            this.DatosProd.Name = "DatosProd";
            this.DatosProd.ReadOnly = true;
            this.DatosProd.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosProd.RowTemplate.Height = 28;
            this.DatosProd.Size = new System.Drawing.Size(905, 399);
            this.DatosProd.TabIndex = 204;
            this.DatosProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosProd_CellContentClick);
            this.DatosProd.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosProd_CellPainting);
            // 
            // btnSelecccionar
            // 
            this.btnSelecccionar.HeaderText = "";
            this.btnSelecccionar.MinimumWidth = 6;
            this.btnSelecccionar.Name = "btnSelecccionar";
            this.btnSelecccionar.ReadOnly = true;
            this.btnSelecccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelecccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelecccionar.Width = 35;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // valorVenta
            // 
            this.valorVenta.HeaderText = "Valor Venta";
            this.valorVenta.MinimumWidth = 6;
            this.valorVenta.Name = "valorVenta";
            this.valorVenta.ReadOnly = true;
            this.valorVenta.Width = 125;
            // 
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "Valor Compra";
            this.ValorCompra.MinimumWidth = 6;
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            this.ValorCompra.Width = 125;
            // 
            // Existencias
            // 
            this.Existencias.HeaderText = "Existencias";
            this.Existencias.MinimumWidth = 6;
            this.Existencias.Name = "Existencias";
            this.Existencias.ReadOnly = true;
            this.Existencias.Width = 90;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(570, 107);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(171, 28);
            this.cbobusqueda.TabIndex = 217;
            // 
            // txtBus
            // 
            this.txtBus.BackColor = System.Drawing.Color.White;
            this.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBus.Location = new System.Drawing.Point(747, 109);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(205, 26);
            this.txtBus.TabIndex = 216;
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
            this.btnLimpiar.Location = new System.Drawing.Point(1024, 109);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 29);
            this.btnLimpiar.TabIndex = 215;
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
            this.btnBuscar.Location = new System.Drawing.Point(974, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 29);
            this.btnBuscar.TabIndex = 214;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 213;
            this.label7.Text = "Buscar  Por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(639, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 82);
            this.label9.TabIndex = 212;
            this.label9.Text = "Lista de Productos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(195, 116);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 22);
            this.txtId.TabIndex = 227;
            this.txtId.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtindice.Enabled = false;
            this.txtindice.Location = new System.Drawing.Point(234, 116);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(33, 22);
            this.txtindice.TabIndex = 226;
            this.txtindice.Visible = false;
            // 
            // ValorVentaPr
            // 
            this.ValorVentaPr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValorVentaPr.Enabled = false;
            this.ValorVentaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorVentaPr.Location = new System.Drawing.Point(35, 473);
            this.ValorVentaPr.Name = "ValorVentaPr";
            this.ValorVentaPr.Size = new System.Drawing.Size(233, 27);
            this.ValorVentaPr.TabIndex = 225;
            this.ValorVentaPr.Visible = false;
            // 
            // DescripcionProd
            // 
            this.DescripcionProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProd.Location = new System.Drawing.Point(34, 320);
            this.DescripcionProd.Name = "DescripcionProd";
            this.DescripcionProd.Size = new System.Drawing.Size(233, 27);
            this.DescripcionProd.TabIndex = 223;
            // 
            // nombreProducto
            // 
            this.nombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto.Location = new System.Drawing.Point(35, 181);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(233, 27);
            this.nombreProducto.TabIndex = 221;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 219;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 220;
            this.label5.Text = "Descripcion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 218;
            this.label8.Text = "Nombre:";
            // 
            // EditarProd
            // 
            this.EditarProd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EditarProd.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarProd.IconColor = System.Drawing.Color.Black;
            this.EditarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarProd.IconSize = 15;
            this.EditarProd.Location = new System.Drawing.Point(55, 375);
            this.EditarProd.Name = "EditarProd";
            this.EditarProd.Size = new System.Drawing.Size(173, 41);
            this.EditarProd.TabIndex = 228;
            this.EditarProd.Text = "Editar";
            this.EditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarProd.UseVisualStyleBackColor = false;
            this.EditarProd.Click += new System.EventHandler(this.EditarProd_Click);
            // 
            // valorCompraPr
            // 
            this.valorCompraPr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorCompraPr.Enabled = false;
            this.valorCompraPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorCompraPr.Location = new System.Drawing.Point(37, 541);
            this.valorCompraPr.Name = "valorCompraPr";
            this.valorCompraPr.Size = new System.Drawing.Size(233, 27);
            this.valorCompraPr.TabIndex = 231;
            this.valorCompraPr.Visible = false;
            // 
            // ModeloP
            // 
            this.ModeloP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModeloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloP.Location = new System.Drawing.Point(34, 247);
            this.ModeloP.Name = "ModeloP";
            this.ModeloP.Size = new System.Drawing.Size(233, 27);
            this.ModeloP.TabIndex = 232;
            // 
            // Exis
            // 
            this.Exis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exis.Enabled = false;
            this.Exis.Location = new System.Drawing.Point(257, 435);
            this.Exis.Name = "Exis";
            this.Exis.Size = new System.Drawing.Size(33, 22);
            this.Exis.TabIndex = 233;
            this.Exis.Visible = false;
            // 
            // ConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.Exis);
            this.Controls.Add(this.ModeloP);
            this.Controls.Add(this.valorCompraPr);
            this.Controls.Add(this.EditarProd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.ValorVentaPr);
            this.Controls.Add(this.DescripcionProd);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatosProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProductos";
            this.Text = "ConsultarProductos";
            this.Load += new System.EventHandler(this.ConsultarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosProd;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtBus;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox ValorVentaPr;
        private System.Windows.Forms.TextBox DescripcionProd;
        private System.Windows.Forms.TextBox nombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton EditarProd;
        private System.Windows.Forms.TextBox valorCompraPr;
        private System.Windows.Forms.TextBox ModeloP;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelecccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.TextBox Exis;
    }
}