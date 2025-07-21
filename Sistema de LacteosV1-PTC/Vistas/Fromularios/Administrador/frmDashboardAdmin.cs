using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vistas.Fromularios.Administrador
{
    public partial class frmDashboardAdmin : Form
    {
        public frmDashboardAdmin()
        {
            InitializeComponent();

        }

        private void btnGestionarEmpleados_Click(object sender, EventArgs e)
        {
            pnlMantemientoInventario.Visible = false;
            pnlMantenimientoProveedores.Visible = false;
            if (pnlManteniminetoEmpleado.Visible == false)
            {
                pnlManteniminetoEmpleado.Visible = true;
            }
            else
            {
                ocultarsubmenu(false);
            }

        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            ocultarsubmenu(false);
        }


        private void ocultarsubmenu(bool estado)
        {
            pnlMantemientoInventario.Visible = estado;
            pnlMantenimientoProveedores.Visible = estado;
            pnlManteniminetoEmpleado.Visible = estado;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            pnlManteniminetoEmpleado.Visible = false;
            pnlMantenimientoProveedores.Visible = false;
            if (pnlMantemientoInventario.Visible == false)
            {
                pnlMantemientoInventario.Visible = true;
            }
            else
            {
                ocultarsubmenu(false);
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            pnlMantemientoInventario.Visible = false;
            pnlManteniminetoEmpleado.Visible = false;
            if (pnlMantenimientoProveedores.Visible == false)
            {
                pnlMantenimientoProveedores.Visible = true;
            }
            else
            {
                ocultarsubmenu(false);
            }
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmRegistrarEmpleado form = new frmRegistrarEmpleado();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
            


        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmDashboardAdmin(object sender, EventArgs e)
        {
            
        }

        private void btnVerEmpleado_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerEmpleado form = new frmVerEmpleado();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
           
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmProductos form = new frmProductos();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

            pnlContenedor.Controls.Clear();

            frmCategorias form = new frmCategorias();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();

        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {

            pnlContenedor.Controls.Clear();

            frmGestionarProveedores form = new frmGestionarProveedores();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();

        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmVerProveedores form = new frmVerProveedores();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();


        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmReportes form = new frmReportes();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //frmDashboardAdmin dash = new frmDashboardAdmin();
            //dash.Show();

            //this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

           

        }
    }
    }
           