using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    public class VerificarCarrera
    {
        public string Verificar(int id)
        {
            string carrera = "";
            if(id == 1)
            {
                carrera = "Ingeneria en Sistemas";
                return carrera;
                
            }
            else if(id == 2)
            {
                carrera = "Licenciatura en Informatica";
                return carrera;
            }
            else if(id == 3)
            {
                carrera = "Licenciatura en Diseño Grafico";
                return carrera;
            }
            else if(id == 4)
            {
                carrera = "Ingeneria en Telecomunicaciones";
                return carrera;
            }
            return carrera;
            
        }
    }
}
