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
    public partial class ConsultarDepartamento : Consultas
    {
        public ConsultarDepartamento()
        {
            InitializeComponent();
        }

        private void ConsultarDepartamento_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Departamento").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                string cmd = "Select * From Departamento where Nombre Like ('%" + errorTextBox1.Text.Trim() + "%')";
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error inesperado" + error.Message);
            }
        }
    }
}
