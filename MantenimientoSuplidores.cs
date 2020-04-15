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
    public partial class MantenimientoSuplidores : Mantenimiento
    {
        public MantenimientoSuplidores()
        {
            InitializeComponent();
        }
        
        public override bool Guardar()
        {

            if (Utilidades.ValidarFormulario(this, errorProvider) == false)
            {
                try
                {
                    string cdm = string.Format("EXEC ActualizaSuplidores '{0}', '{1}', '{2}'", txtIdSup.Text.Trim(), txtNomSup.Text.Trim(), txtDirSup.Text.Trim());
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
                string cmd = string.Format("EXEC EliminarSuplidores '{0}'", txtIdSup.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el Suplidor");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
        }
        





        private void MantenimientoDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void errorTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
