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
    public partial class MantenimientoDepartamento : Mantenimiento
    {
        public MantenimientoDepartamento()
        {
            InitializeComponent();
        }

        public override bool Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider) == false)
            {
                try
                {
                    string cdm = string.Format("EXEC ActualizaDepartamento '{0}', '{1}', '{2}'", txtIdDep.Text.Trim(), txtNomDep.Text.Trim(), txtEstatus.Text.Trim());
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
                string cmd = string.Format("EXEC ActualizaDepartamento '{0}'", txtIdDep.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el Departamento");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
        }






        private void MantenimientoDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}
