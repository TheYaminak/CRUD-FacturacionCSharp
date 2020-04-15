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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }


        public override bool Guardar()
        {

            if (Utilidades.ValidarFormulario(this, errorProvider) == false)
            {
                try
                {
                    string cdm = string.Format("EXEC ActualizaArticulos '{0}', '{1}', '{2}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPre.Text.Trim());
                    Utilidades.Ejecutar(cdm);
                    MessageBox.Show("Se ha guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
            

        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
