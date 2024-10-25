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
    public partial class Logo : Form
    {
        /*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
        private int Tiempo { get; set; } //creo un atributo para manejar el tiempo
        public Logo()
        {
            InitializeComponent();
            Tiempo = 10;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tiempo > 0)
            {
                Tiempo = Tiempo - 1; //Aqui el timer hace el recorrido para ir bajando
            }
            else
            {
                timer1.Stop(); //cuando el timer llego a cero
                new frmportal().Show(); //se muestra el otro formulario 
                this.Hide(); //el formulario actual se esconde
            }
        }
    }
}
