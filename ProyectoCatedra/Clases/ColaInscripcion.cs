using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCatedra
{
    public class ColaInscripcion
    {
        //Nodos que definen el inicio y final de la cola
        private NodoEstudianteL front;
        private NodoEstudianteL rear;
        private string carnetr;
        private string materia;
        public ColaInscripcion()
        {
            front = null;
            rear = null;
        }
        public bool EstaVacia()
        {
            if (front == null)
                return true;
            else
                return false;
        }
        public void Encolar(Estudiante nuevo)
        {
            //Agrega los datos de un estudiante al nodo de la cola como objeto de la clase Estudiante
            NodoEstudianteL nodo = new NodoEstudianteL
            {
                infonodo = nuevo,
            };

            if (EstaVacia())
            {
                front = rear = nodo;
            }
            else
            {
                rear.siguiente = nodo;
                nodo.anterior = rear;
                rear = nodo;
            }
        }
        public NodoEstudianteL Dequeue()
        {
            //Este metodo se encarga de comprobar si la cola esta vacia
            //y si no esta vacia, te reordena los nodos y selecciona el que se desea sacar
            if (EstaVacia())
            {
                return null;
            }
            else
            {
                NodoEstudianteL temp = front;
                if (front == rear)
                {
                    front = rear = null;
                }
                else
                {
                    front = front.siguiente;
                    front.anterior = null;
                }
                return temp;
            }
        }

    }
}
