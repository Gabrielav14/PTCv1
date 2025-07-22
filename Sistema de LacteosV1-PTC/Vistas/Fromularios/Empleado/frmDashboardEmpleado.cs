using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Fromularios.Administrador;

namespace Vistas.Fromularios.Empleado
{
    public partial class frmDashboardEmpleado : Form
    {
       
        public frmDashboardEmpleado()
        {
            InitializeComponent();
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            pnlMantenimientoVentas.Visible = false;
            if (pnlMantenimientoInventario.Visible == false)
            {
                pnlMantenimientoInventario.Visible = true;
            }
            else
            {
                ocultarsubmenu(false);
            }

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboardEmpleado_Load(object sender, EventArgs e)
        {
            ocultarsubmenu(false);
        }
        private void ocultarsubmenu(bool estado)
        {
            pnlMantenimientoInventario.Visible = estado;
            pnlMantenimientoVentas.Visible = estado;
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        { //Boton de Ventas

            pnlMantenimientoInventario.Visible = false;
            if (pnlMantenimientoVentas.Visible == false)
            {
                pnlMantenimientoVentas.Visible = true;
            }
            else
            {
                ocultarsubmenu(false);
            }

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmGestionarProductos form = new frmGestionarProductos();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerProductos form = new frmVerProductos();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerVentas form = new frmVerVentas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();
            
            frmRegistrarVentas form = new frmRegistrarVentas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmReportesEmpleado form = new frmReportesEmpleado();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnControlarFechas_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmControlFechas form = new frmControlFechas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }
    }
}
