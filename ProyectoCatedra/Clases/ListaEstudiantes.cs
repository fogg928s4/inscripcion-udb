using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    //Esta Lista es para que los nodos o estudiantes vayan ingresandose a la base de datos
    public class ListaEstudiantes
    {
        public NodoEstudianteL inicio;
        public int totalnodos;
    //Metodos constructores y de insercion
        public ListaEstudiantes()
        {
            inicio = null;
            totalnodos = 0;

        }
        public void InsertarI(Estudiante item)
        {
            //Este metodo se encarga de pasar de el nodo de la lista
            //luego envia este objeto a un metodo encargado en ingresar cada elemento de este dentro de la base de datos
            NodoEstudianteL puntero;
            NodoEstudianteL auxiliar = new NodoEstudianteL(item);

            if (inicio == null)
            {
                inicio = auxiliar;
                //Asigna los valores a la colo global
                ColaGlobal.Colainscripcion.Encolar(item);
                //Funcion para registrar en la base de datos
                if (RegistroCuenta.Registrar(item) >= 1)
                {
                    MessageBox.Show("Registro Ingresado en la Base de Datos");
                }
            }
            else
            {
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }
            this.totalnodos++;
        }

        public void InsertarF(Estudiante item)
        {
            //Insertar cada elemento de Estudiante en los nodos de la lista
            NodoEstudianteL auxiliar = new NodoEstudianteL(item);
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                NodoEstudianteL puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
            this.totalnodos++;
        }
        public Estudiante[] CopyToArray()
        {
            Estudiante[] estudiantes = new Estudiante[totalnodos];

            NodoEstudianteL current = inicio;
            int i = 0;
            while (current != null)
            {
                estudiantes[i] = current.infonodo;
                current = current.siguiente;
                i++;
            }
            return estudiantes;
        }
    }
}
