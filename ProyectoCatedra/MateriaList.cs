﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    public class MateriaList
    {
        private Nodo cabeza;

        public void Add(Materia data)
        {
            Nodo newNodo = new Nodo();
            newNodo.Data = data;

            if (cabeza == null)
            {
                cabeza = newNodo;
            }
            else
            {
                Nodo current = cabeza;
                while (current.siguiente != null)
                {
                    current = current.siguiente;
                }
                current.siguiente = newNodo;
            }
        }

        public void Remove(Materia data)
        {
            if (cabeza == null)
            {
                return;
            }

            if (cabeza.Data.Equals(data))
            {
                cabeza = cabeza.siguiente;
                return;
            }

            Nodo current = cabeza;
            while (current.siguiente != null)
            {
                if (current.siguiente.Data.Equals(data))
                {
                    current.siguiente = current.siguiente.siguiente;
                    return;
                }
                current = current.siguiente;
            }
        }
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