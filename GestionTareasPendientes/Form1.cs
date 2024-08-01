

namespace GestionTareasPendientes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                                                                    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var tarea = txt_tarea.Text;
            var materia = txt_materia.Text;
            var alumno = txt_alumno.Text;
            var fecha = dateTimePicker2.Text;

            string cadena = tarea + " // " + materia + "  // " + alumno + " // " + fecha;
            list_tareas.Items.Add(cadena);


        }
        public void limpiarCaja()
        {
            txt_tarea.Text = "";
            txt_materia.Text = "";
            txt_alumno.Text = "";
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( list_tareas.SelectedIndex != -1 )
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la tarea?", "Eliminar tarea", MessageBoxButtons.YesNo);
                list_tareas.Items.RemoveAt(list_tareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea");
            }
        }
            
    }
}
