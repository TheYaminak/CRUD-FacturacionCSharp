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
    public partial class MantenimientoUsuarios : Mantenimiento
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }
        
        public override bool Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider) == false)
            {
                int estatus = 0;
                if (this.padmin.Checked == true)
                {
                    estatus = 1;
                }
                try
                {
                    string cdm = string.Format("EXEC ActualizaUsuarios '{0}', '{1}', '{2}', '{3}', '{4}'", txtIdUs.Text.Trim(), txtNomUs.Text.Trim(), txtCuentaUs.Text.Trim(), txtConUs.Text.Trim(), estatus);
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
                string cmd = string.Format("EXEC EliminarUsuarios '{0}'", txtIdUsu.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado el Usuario");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error.Message);
            }
        }

    







        private void MantenimientoUnidades_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
