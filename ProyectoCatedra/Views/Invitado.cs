using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    /*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
    public partial class Form1 : Form
    {
        public int carrera;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            frmregistro mostrar = new frmregistro();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carrera = 1;
            Pensum ventana = new Pensum(carrera);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carrera = 2;
            Pensum ventana = new Pensum(carrera);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carrera = 3;
            Pensum ventana = new Pensum(carrera);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carrera = 4;
            Pensum ventana = new Pensum(carrera);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmportal back = new frmportal();
            this.Hide();
            back.ShowDialog();
            this.Close();
        }
    }
}
