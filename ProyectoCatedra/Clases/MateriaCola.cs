using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    //Se utiliza para ingresar los objetos dentro de la base de datos
    public class MateriaCola
    {
        private Nodo cabeza;
        private Nodo cola;

        public void EnColar(Materia data)
        {
            Nodo newNodo = new Nodo();
            newNodo.Data = data;

            if (cabeza == null)
            {
                cabeza = newNodo;
                cola = newNodo;
            }
            else
            {
                cola.siguiente = newNodo;
                cola = newNodo;
            }
        }
        //Crea un contador para saber cuantos nodos hay en la cola
        public int Count()
        {
            int count = 0;
            Nodo current = cabeza;
            while (current != null)
            {
                count++;
                current = current.siguiente;
            }
            return count;
        }
        //Inserta todos los elementos de la cola en un array de materias
        public Materia[] CopyToArray()
        {
            Materia[] materias = new Materia[Count()];

            Nodo current = cabeza;
            int i = 0;
            while (current != null)
            {
                materias[i] = current.Data;
                current = current.siguiente;
                i++;
            }

            return materias;
        }
    }
}
