using SirobVacaDeber6.Controllers;
using SirobVacaDeber6.Models;

namespace S6T1_MC
{
    public partial class FRM_InventarioDA : Form
    {
        private readonly ProductoController _productoController;
        public FRM_InventarioDA()
        {
            InitializeComponent();
            _productoController = new ProductoController();
        }

        private void FRM_InventarioF_Load(object sender, EventArgs e)
        {
            CargaLista();
        }

        public void CargaLista()
        {
            lstInventario.DataSource = null;
            lstInventario.DataSource = _productoController.todos();
            lstInventario.DisplayMember = "Producto";
            lstInventario.ValueMember = "ProductoId";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() == "" ||
                txtPaquete.Text.Trim() == "" ||
                txtProveedor.Text.Trim() == "" ||
                txtStock.Text.Trim() == "" ||
                txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            if (!uint.TryParse(txtStock.Text, out var stock))
            {
                MessageBox.Show("Stock debe ser número positivo.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out var pUnit))
            {
                MessageBox.Show("Precio unitario inválido.");
                return;
            }

            var producto = new ProductoModel
            {
                Producto = txtProducto.Text.Trim(),
                Paquete = txtPaquete.Text.Trim(),
                FechaIngreso = dtpFingreso.Value.Date,
                FechaCaducidad = dtpFcaducidad.Value.Date,
                Proveedor = txtProveedor.Text.Trim(),
                Stock = stock,
                Precio = pUnit
            };

            string res;
            if (lstInventario.Enabled == false)      // Editar
            {
                producto.ProductoId = Convert.ToInt32(lstInventario.SelectedValue);
                res = _productoController.Actualizar(producto);
            }
            else                                     // Nuevo registro
            {
                res = _productoController.Insertar(producto);
            }

            if (res == "ok")
            {
                MessageBox.Show("Se guardó con éxito");
                LimpiaCajas();
                CargaLista();
            }
            else
            {
                //lblErrores.Text = res;
                //lblErrores.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstInventario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista");
                return;
            }

            lstInventario.Enabled = false;
            var prod = _productoController.uno(Convert.ToInt32(lstInventario.SelectedValue));

            txtProducto.Text = prod.Producto;
            txtPaquete.Text = prod.Paquete;
            dtpFingreso.Value = prod.FechaIngreso;
            dtpFcaducidad.Value = prod.FechaCaducidad;
            txtProveedor.Text = prod.Proveedor;
            txtStock.Text = prod.Stock.ToString();
            txtPrecio.Text = prod.Precio.ToString("0.##");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiaCajas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiaCajas()
        {
            txtProducto.Text = "";
            txtPaquete.Text = "";
            txtProveedor.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            dtpFingreso.Value = DateTime.Today;
            dtpFcaducidad.Value = DateTime.Today;
            lstInventario.Enabled = true;
            lstInventario.ClearSelected();
            //lblErrores.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Verificar que haya un producto seleccionado
            if (lstInventario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista");
                return;
            }

            // 2. Confirmar la eliminación
            var nombre = ((ProductoModel)lstInventario.SelectedItem).Producto;
            var confirmar = MessageBox.Show(
                $"¿Está seguro de eliminar «{nombre}»?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            // 3. Llamar al controlador
            var id = Convert.ToInt32(lstInventario.SelectedValue);   // usa UInt32 si tu Id es uint
            var resultado = _productoController.Eliminar(id);

            // 4. Resultado
            if (resultado == "ok")
            {
                MessageBox.Show("Se eliminó con éxito");
                LimpiaCajas();
                CargaLista();
            }
            else
            {
                MessageBox.Show($"Error: {resultado}");
            }
        }
    }
}
