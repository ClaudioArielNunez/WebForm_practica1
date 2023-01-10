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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Apenas se carga el formulario quiero q se cargue este listado de opciones
            //para el combo box de tecnologias

            //esta es una colleccion q trabaja con items, agregar(add)
            cboSeniority.Items.Add("Trainee");
            cboSeniority.Items.Add("Junior");
            cboSeniority.Items.Add("SemiSenior");
            cboSeniority.Items.Add("Senior");

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            //guardamos la fecha en DateTime, una tipo de variable especial para fechas
            DateTime fecha = dateTimeNacimiento.Value;
            //operador Ternario, es un if en una sola linea
            string tipoDeveloper = checkBoxTipeDev.Checked == true ? "Backend Developer" : "Frontend Developer";
            //capturamos el lenguaje de programación
            string lenguaje;
            if (radioBtnJAVA.Checked)
                lenguaje = "Java";
            else if (radioBtnJS.Checked)
            {
                lenguaje = "JavaScript";
            }
            else if (radioBtnCPLUS.Checked)
            {
                lenguaje = "C #";
            }
            else
                lenguaje = "Pyton";

            //capturamos el Seniority
            //porque lleva ToString? porque el metodo me devuelve un objeto, lo debo parsear
            string seniority = cboSeniority.SelectedItem.ToString();

            MessageBox.Show($"Nombre completo: {nombre} {apellido} \nFecha de Nacimiento: {fecha} \nTipo de Developer: {tipoDeveloper} \nTecnologia elegida: {lenguaje}\nSeniority actual: {seniority}");


            
        }
    }
}

    