using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        } 

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para ir a la otra ventana primero debemos
            //crear la instancia del objeto y luego la mostramos con .show
            Form1 ventana = new Form1();
            //ventana.Show();
            ventana.ShowDialog(); //de esta forma no se multiplican los formularios

        }

        private void toolStripBtnPerfil_ButtonClick(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void crearNuevoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmptyForm FormularioVacio = new EmptyForm();
            FormularioVacio.ShowDialog();

        }
    }
}
