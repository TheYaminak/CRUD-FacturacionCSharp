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
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion ftc = new Facturacion();
            ftc.MdiParent = this;
            ftc.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtApellCli ManCli = new txtApellCli();
            ManCli.MdiParent = this;
            ManCli.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProducto ManPro = new MantenimientoProducto();
            ManPro.MdiParent = this;
            ManPro.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamento ManDep = new MantenimientoDepartamento();
            ManDep.MdiParent = this;
            ManDep.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoSuplidores ManSup = new MantenimientoSuplidores();
            ManSup.MdiParent = this;
            ManSup.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios ManUsu = new MantenimientoUsuarios();
            ManUsu.MdiParent = this;
            ManUsu.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConClick = new ConsultarClientes();
            ConClick.MdiParent = this;
            ConClick.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConClick = new ConsultarProductos();
            ConClick.MdiParent = this;
            ConClick.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDepartamento ConClick = new ConsultarDepartamento();
            ConClick.MdiParent = this;
            ConClick.Show();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarSuplidores ConClick = new ConsultarSuplidores();
            ConClick.MdiParent = this;
            ConClick.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios ConClick = new ConsultarUsuarios();
            ConClick.MdiParent = this;
            ConClick.Show();
        }
    }
}
