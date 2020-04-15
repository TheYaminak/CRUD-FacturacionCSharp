using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
