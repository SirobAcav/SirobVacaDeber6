namespace S6T1_MC
{
    partial class FRM_InventarioDA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProducto = new TextBox();
            txtPaquete = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProveedor = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            lstInventario = new ListBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            label7 = new Label();
            dtpFcaducidad = new DateTimePicker();
            dtpFingreso = new DateTimePicker();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.White;
            txtProducto.Cursor = Cursors.IBeam;
            txtProducto.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            txtProducto.ForeColor = Color.Navy;
            txtProducto.Location = new Point(262, 69);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(378, 36);
            txtProducto.TabIndex = 2;
            // 
            // txtPaquete
            // 
            txtPaquete.BackColor = Color.White;
            txtPaquete.Cursor = Cursors.IBeam;
            txtPaquete.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            txtPaquete.ForeColor = Color.Navy;
            txtPaquete.Location = new Point(262, 113);
            txtPaquete.Name = "txtPaquete";
            txtPaquete.Size = new Size(378, 36);
            txtPaquete.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(21, 116);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 5;
            label2.Text = "Paquete";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(368, 21);
            label3.Name = "label3";
            label3.Size = new Size(451, 28);
            label3.TabIndex = 6;
            label3.Text = "Inventario de Distribuidora de Alimentos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(21, 263);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 10;
            label4.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(21, 212);
            label5.Name = "label5";
            label5.Size = new Size(230, 28);
            label5.TabIndex = 9;
            label5.Text = "Fecha de Caducidad";
            // 
            // txtProveedor
            // 
            txtProveedor.Cursor = Cursors.IBeam;
            txtProveedor.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            txtProveedor.ForeColor = Color.Navy;
            txtProveedor.Location = new Point(262, 260);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(378, 36);
            txtProveedor.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(21, 371);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 14;
            label8.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(21, 313);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 13;
            label9.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            txtPrecio.ForeColor = Color.Navy;
            txtPrecio.Location = new Point(262, 368);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(378, 36);
            txtPrecio.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            txtStock.ForeColor = Color.Navy;
            txtStock.Location = new Point(262, 310);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(378, 36);
            txtStock.TabIndex = 11;
            // 
            // lstInventario
            // 
            lstInventario.BackColor = Color.MistyRose;
            lstInventario.Cursor = Cursors.Hand;
            lstInventario.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            lstInventario.ForeColor = Color.Navy;
            lstInventario.FormattingEnabled = true;
            lstInventario.ItemHeight = 28;
            lstInventario.Location = new Point(664, 67);
            lstInventario.Name = "lstInventario";
            lstInventario.Size = new Size(436, 312);
            lstInventario.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Red;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(21, 434);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(218, 79);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Red;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(236, 434);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(218, 79);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(455, 434);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(218, 79);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(671, 434);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(218, 79);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(21, 160);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 24;
            label7.Text = "Fecha de Ingreso";
            // 
            // dtpFcaducidad
            // 
            dtpFcaducidad.Cursor = Cursors.Hand;
            dtpFcaducidad.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            dtpFcaducidad.Location = new Point(262, 207);
            dtpFcaducidad.Name = "dtpFcaducidad";
            dtpFcaducidad.Size = new Size(378, 36);
            dtpFcaducidad.TabIndex = 25;
            // 
            // dtpFingreso
            // 
            dtpFingreso.CalendarMonthBackground = Color.White;
            dtpFingreso.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtpFingreso.Cursor = Cursors.Hand;
            dtpFingreso.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            dtpFingreso.Location = new Point(262, 155);
            dtpFingreso.Name = "dtpFingreso";
            dtpFingreso.Size = new Size(378, 36);
            dtpFingreso.TabIndex = 26;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Arial Black", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(888, 434);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(218, 79);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FRM_InventarioDA
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1112, 528);
            Controls.Add(btnEliminar);
            Controls.Add(dtpFingreso);
            Controls.Add(dtpFcaducidad);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lstInventario);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPaquete);
            Controls.Add(txtProducto);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_InventarioDA";
            Text = "FRM_InventarioDistribuidoraAlimentos";
            Load += FRM_InventarioF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProducto;
        private TextBox txtPaquete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProveedor;
        private Label label8;
        private Label label9;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private ListBox lstInventario;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnSalir;
        private Label label7;
        private DateTimePicker dtpFcaducidad;
        private DateTimePicker dtpFingreso;
        private Button btnEliminar;
    }
}
