using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;

namespace ProyectoCatedra
{
    //Clase que contiene los objetos de los usuarios estudiantes y todos sus datos. Se usa para ingresar estos datos a la base de datos
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string nacimiento;
        private string email;
        private string telefono;
        private string direccion;
        private string dui;
        private string carnet;
        private int carrera;
        private string contraseña;
        private string sexo; 
        //propiedades
        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        public string Apellido
        {
            get => apellido; 
            set => apellido = value; 
        }
        public string Nacimiento 
        { 
            get => nacimiento; 
            set => nacimiento = value; 
        }
        public string Email 
        { 
            get => email; 
            set => email = value; 
        }
        public string Telefono 
        { 
            get => telefono; 
            set => telefono = value; 
        }
        public string Direccion 
        { 
            get => direccion; 
            set => direccion = value; 
        }
        public string Dui 
        { 
            get => dui; 
            set => dui = value; 
        }
        public string Carnet 
        { 
            get => carnet; 
            set => carnet = value; 
        }
        public int Carrera 
        {
            get => carrera; 
            set => carrera = value; 
        }
        public string Contraseña 
        { 
            get => contraseña; 
            set => contraseña = value; 
        }
        public String Sexo
        {
            get => sexo;
            set => sexo = value;
        }
    }
}
