using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    public  class Materia
    {
        public string codigo;
        public string nombre;
        public int uv;
        public string estado;
        public int grupo;
        public string prerequisito;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int UV
        {
            get { return uv; }
            set { uv = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string Prerequisito
        {
            get { return prerequisito; }
            set { prerequisito = value; }
        }
    }
}
