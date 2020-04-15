using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreriaa;

namespace Factura
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario=" + Form1.Codigo;
            DataSet ds;

            ds = Utilidades.Ejecutar(cmd);
            lblAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            //this.reportViewer1.RefreshReport();
        }

        private void errorTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nom_Cli from Clientes where id_clientes ='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_Cli"].ToString().Trim();
                    txtCodigoProducto.Focus();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error " + error.Message);
            }

        }
        public static int cont_fila = 0;
        public static double total = 0;
        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;
                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoProducto.Text, txtDescripcion.Text,txtPrecio.Text,txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodigoProducto.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                    }
                }

                total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                lblTotal.Text = total.ToString("c");
                txtCodigoProducto.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                txtCodigoProducto.Focus();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = total.ToString("c");
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                cont_fila--;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes conCli = new ConsultarClientes();
            conCli.ShowDialog();

            if (conCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodigoProducto.Focus();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos conPro = new ConsultarProductos();
            conPro.ShowDialog();
            if(conPro.DialogResult == DialogResult.OK)
            {
                txtCodigoProducto.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantidad.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();

        }
        public override void Nuevo()
        {
            txtCodigoCli.Text = "";
            txtCliente.Text = "";
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "";
            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCodigoCli.Focus();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizaFacturas '{0}'", txtCodigoCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);

                    string NumFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("Exec ActualizaDetalles '{0}', '{1}', '{2}', '{3}'", NumFac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cmd);
                    
                    }
                    cmd = "Exec DatosFactura " + NumFac;
                    ds = Utilidades.Ejecutar(cmd);

                    //Ventana Reporte

                    Reporte rp = new Reporte();

                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo();




                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un erro inesperado " + error.Message);
                }
            }
        }
    }
}
