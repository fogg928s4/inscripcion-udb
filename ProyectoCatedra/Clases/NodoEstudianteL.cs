using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;

namespace ProyectoCatedra
{
    //se ocupa para los objetos de las listas
    public class NodoEstudianteL
    {
    //el nodo tendra como valor instancias de la clase Estudiante
        public Estudiante infonodo;
        public NodoEstudianteL siguiente;
        public NodoEstudianteL anterior
        { get; set; }
        //propiedades del nodo
        public NodoEstudianteL()
        {
            infonodo = null;
            siguiente = null;
        }
        public NodoEstudianteL(Estudiante valor)
        {
            infonodo = valor;
            siguiente = null;
        }
        public Estudiante Infonodo
        {
            get { return infonodo; }
            set { infonodo = value; }
        }
        public NodoEstudianteL Sig
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
