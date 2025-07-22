namespace Vistas.Fromularios.Empleado
{
    partial class frmRegistrarVentas
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbDui = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new FontAwesome.Sharp.IconButton();
            this.btnAgergar = new FontAwesome.Sharp.IconButton();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.dvgCarrito = new System.Windows.Forms.DataGridView();
            this.gbTipodePago = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gbDatosCliente.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).BeginInit();
            this.gbTipodePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.LightGray;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(254, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(362, 25);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Registrar nueva venta (Compra): ";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbDatosCliente.Controls.Add(this.txtCorreo);
            this.gbDatosCliente.Controls.Add(this.lblDireccion);
            this.gbDatosCliente.Controls.Add(this.lblCorreo);
            this.gbDatosCliente.Controls.Add(this.lblDui);
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.mtbTelefono);
            this.gbDatosCliente.Controls.Add(this.mtbDui);
            this.gbDatosCliente.Controls.Add(this.txtDireccion);
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Controls.Add(this.txtApellido);
            this.gbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 37);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(471, 198);
            this.gbDatosCliente.TabIndex = 1;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(270, 48);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(177, 24);
            this.txtCorreo.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(6, 145);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(77, 16);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(235, 29);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(140, 16);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.ForeColor = System.Drawing.Color.White;
            this.lblDui.Location = new System.Drawing.Point(235, 86);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(37, 16);
            this.lblDui.TabIndex = 9;
            this.lblDui.Text = "DUI:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(235, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 16);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(6, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 16);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre del Cliente:";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(270, 164);
            this.mtbTelefono.Mask = "0000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(177, 24);
            this.mtbTelefono.TabIndex = 4;
            // 
            // mtbDui
            // 
            this.mtbDui.ForeColor = System.Drawing.Color.Black;
            this.mtbDui.Location = new System.Drawing.Point(270, 105);
            this.mtbDui.Mask = "00000000-0";
            this.mtbDui.Name = "mtbDui";
            this.mtbDui.Size = new System.Drawing.Size(177, 24);
            this.mtbDui.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(30, 164);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 24);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCliente.Location = new System.Drawing.Point(44, 48);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(133, 24);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(30, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 24);
            this.txtApellido.TabIndex = 0;
            // 
            // gbProducto
            // 
            this.gbProducto.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbProducto.Controls.Add(this.btnQuitar);
            this.gbProducto.Controls.Add(this.btnAgergar);
            this.gbProducto.Controls.Add(this.nudCantidad);
            this.gbProducto.Controls.Add(this.cbProducto);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(478, 37);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(326, 198);
            this.gbProducto.TabIndex = 2;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Red;
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQuitar.IconColor = System.Drawing.Color.Black;
            this.btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitar.Location = new System.Drawing.Point(44, 122);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(94, 43);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgergar
            // 
            this.btnAgergar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgergar.ForeColor = System.Drawing.Color.White;
            this.btnAgergar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgergar.IconColor = System.Drawing.Color.Black;
            this.btnAgergar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgergar.Location = new System.Drawing.Point(171, 123);
            this.btnAgergar.Name = "btnAgergar";
            this.btnAgergar.Size = new System.Drawing.Size(91, 42);
            this.btnAgergar.TabIndex = 2;
            this.btnAgergar.Text = "Agregar";
            this.btnAgergar.UseVisualStyleBackColor = false;
            this.btnAgergar.Click += new System.EventHandler(this.btnAgergar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.ForeColor = System.Drawing.Color.Black;
            this.nudCantidad.Location = new System.Drawing.Point(34, 46);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(56, 24);
            this.nudCantidad.TabIndex = 1;
            // 
            // cbProducto
            // 
            this.cbProducto.ForeColor = System.Drawing.Color.Black;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(144, 46);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 26);
            this.cbProducto.TabIndex = 0;
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbCarrito.Controls.Add(this.dvgCarrito);
            this.gbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarrito.ForeColor = System.Drawing.Color.Black;
            this.gbCarrito.Location = new System.Drawing.Point(12, 231);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(414, 167);
            this.gbCarrito.TabIndex = 3;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Carrito";
            // 
            // dvgCarrito
            // 
            this.dvgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCarrito.Location = new System.Drawing.Point(33, 23);
            this.dvgCarrito.Name = "dvgCarrito";
            this.dvgCarrito.Size = new System.Drawing.Size(288, 119);
            this.dvgCarrito.TabIndex = 0;
            // 
            // gbTipodePago
            // 
            this.gbTipodePago.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbTipodePago.Controls.Add(this.lblTotal);
            this.gbTipodePago.Controls.Add(this.cmbTipoPago);
            this.gbTipodePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipodePago.ForeColor = System.Drawing.Color.White;
            this.gbTipodePago.Location = new System.Drawing.Point(425, 231);
            this.gbTipodePago.Name = "gbTipodePago";
            this.gbTipodePago.Size = new System.Drawing.Size(286, 167);
            this.gbTipodePago.TabIndex = 4;
            this.gbTipodePago.TabStop = false;
            this.gbTipodePago.Text = "Tipo de Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(202, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 18);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmbTipoPago.Location = new System.Drawing.Point(30, 59);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 26);
            this.cmbTipoPago.TabIndex = 0;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(717, 279);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(74, 101);
            this.btnRegistrarVenta.TabIndex = 5;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Gold;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(713, 231);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(91, 42);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Limpiar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmRegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 401);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.gbTipodePago);
            this.Controls.Add(this.gbCarrito);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.lblVentas);
            this.Name = "frmRegistrarVentas";
            this.Text = "frmRegistrarVentas";
            this.Load += new System.EventHandler(this.frmRegistrarVentas_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).EndInit();
            this.gbTipodePago.ResumeLayout(false);
            this.gbTipodePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.DataGridView dvgCarrito;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbDui;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnAgergar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.GroupBox gbTipodePago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCorreo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}