
namespace Punto_de_venta_vallarta
{
    partial class RegistrarEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cargoEmple = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dirEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreEmpleado = new System.Windows.Forms.TextBox();
            this.registrar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.correoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idFoli = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.idFoli);
            this.groupBox1.Controls.Add(this.cargoEmple);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dirEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreEmpleado);
            this.groupBox1.Controls.Add(this.registrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.correoEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.telEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(293, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 417);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del empleado";
            // 
            // cargoEmple
            // 
            this.cargoEmple.BackColor = System.Drawing.SystemColors.Control;
            this.cargoEmple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoEmple.FormattingEnabled = true;
            this.cargoEmple.Location = new System.Drawing.Point(201, 264);
            this.cargoEmple.Name = "cargoEmple";
            this.cargoEmple.Size = new System.Drawing.Size(285, 30);
            this.cargoEmple.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "Cargo:";
            // 
            // dirEmpleado
            // 
            this.dirEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirEmpleado.Location = new System.Drawing.Point(201, 212);
            this.dirEmpleado.Name = "dirEmpleado";
            this.dirEmpleado.Size = new System.Drawing.Size(285, 28);
            this.dirEmpleado.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Direccion:";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleado.Location = new System.Drawing.Point(201, 79);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(285, 28);
            this.nombreEmpleado.TabIndex = 94;
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.SpringGreen;
            this.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.registrar.IconColor = System.Drawing.Color.Black;
            this.registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrar.IconSize = 20;
            this.registrar.Location = new System.Drawing.Point(251, 340);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(191, 37);
            this.registrar.TabIndex = 97;
            this.registrar.Text = "Registrar";
            this.registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Nombre Completo:";
            // 
            // correoEmpleado
            // 
            this.correoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoEmpleado.Location = new System.Drawing.Point(201, 166);
            this.correoEmpleado.Name = "correoEmpleado";
            this.correoEmpleado.Size = new System.Drawing.Size(285, 28);
            this.correoEmpleado.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Telefono:";
            // 
            // telEmpleado
            // 
            this.telEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEmpleado.Location = new System.Drawing.Point(201, 123);
            this.telEmpleado.Name = "telEmpleado";
            this.telEmpleado.Size = new System.Drawing.Size(285, 28);
            this.telEmpleado.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 58);
            this.label1.TabIndex = 99;
            this.label1.Text = "Registro de Empleados";
            // 
            // idFoli
            // 
            this.idFoli.BackColor = System.Drawing.SystemColors.Control;
            this.idFoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idFoli.Enabled = false;
            this.idFoli.Location = new System.Drawing.Point(500, 27);
            this.idFoli.Name = "idFoli";
            this.idFoli.Size = new System.Drawing.Size(100, 28);
            this.idFoli.TabIndex = 119;
            // 
            // RegistrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarEmpleados";
            this.Text = "RegistrarEmpleados";
            this.Load += new System.EventHandler(this.RegistrarEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dirEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreEmpleado;
        private FontAwesome.Sharp.IconButton registrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cargoEmple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idFoli;
    }
}