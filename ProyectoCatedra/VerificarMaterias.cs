using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    public class VerificarMaterias
    {

            public Materia[] EliminarMateriasRepetidas(Materia[] materias1, Materia[] materias2)
            {
                int contador = 0;
                Materia[] materiasNoRepetidas = new Materia[materias2.Length];

                for (int i = 0; i < materias2.Length; i++)
                {
                    bool repetida = false;
                    for (int j = 0; j < materias1.Length; j++)
                    {
                        if (materias2[i].Nombre == materias1[j].Nombre)
                        {
                            repetida = true;
                            break;
                        }
                    }
                    if (!repetida)
                    {
                        // La materia no está repetida, la añadimos al nuevo array
                        materiasNoRepetidas[contador] = materias2[i];
                        contador++;
                    }
                }

                // Si no se han encontrado materias no repetidas, devolvemos un array vacío
                if (contador == 0)
                {
                    return new Materia[0];
                }

                // Creamos un nuevo array con el tamaño justo para las materias no repetidas
                Materia[] resultado = new Materia[contador];
                Array.Copy(materiasNoRepetidas, resultado, contador);

                return resultado;
            }

    }
}
