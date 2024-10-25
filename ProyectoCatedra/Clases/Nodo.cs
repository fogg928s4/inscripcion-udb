using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    //Se ocupa dentro de la lista y cola sirve para reducir la cantidad de codigo que llevan los metodos de estas clases
    //ya que en un solo objeto se guarda tanto la informacion del nodo como un puntero siguiente
    internal class Nodo
    {
        public Materia Data { get; set; }
        public Nodo siguiente { get; set; }
    }
}
