using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCatedra
{
    //sirve para ver materias inscritas y las que se pueden inscribir
    public  class Obtener_materias
    {
        public MateriaList MatariasCurs(string usuario)
        {
            MateriaList materiasC = new MateriaList(); 
            string query = "SELECT Materias.Codigo, Materias.Nombre, Materias.UV, Materias.Grupo, Inscripcion.Estado " +
                "FROM Materias"+
                " INNER JOIN Carrera ON Materias.ID = Carrera.ID" +
                " INNER JOIN Inscripcion ON Materias.Codigo = Inscripcion.CodigoMateria" +
                " INNER JOIN Usuario ON Inscripcion.Usuario = Usuario.Usuario" +
                " WHERE Usuario.Usuario = '" + usuario + "'";
            SqlCommand command = new SqlCommand(query, Conexion.obtenerconexion());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Materia materia = new Materia();
                materia.Codigo = (string)reader["Codigo"];
                materia.Nombre = (string)reader["Nombre"];
                materia.UV = (int)reader["UV"];
                int a = int.Parse((string)reader["Grupo"]);
                materia.Grupo = a;
                materia.Estado = (string)reader["Estado"];
                materiasC.Add(materia);
            }

            return materiasC;
        }
        public MateriaList materiasp(string usuario)
        {
            MateriaList materiasP = new MateriaList();
            string query = "dECLARE @Alumno as varchar(100)" +
                           " set @Alumno = '" + usuario + "'" +
                           " SELECT m.Codigo, m.Nombre, m.UV, m.Grupo, m.Requisito AS Prerequisito" +
                           " FROM Materias m" +
                           " LEFT JOIN Inscripcion i ON m.Codigo = i.CodigoMateria AND i.Usuario = @Alumno" +
                           " JOIN Carrera c ON c.ID = m.ID AND c.ID = (SELECT ID FROM Usuario WHERE Usuario = @Alumno)" +
                           " WHERE m.Requisito IN (" +
                           " SELECT i.CodigoMateria" +
                           "  FROM Inscripcion i" +
                           " WHERE i.Usuario = @Alumno AND i.Estado = 'aprobada'" +
                           " ) OR m.Requisito IS NULL; ";
            SqlCommand command = new SqlCommand(query, Conexion.obtenerconexion());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Materia materia1 = new Materia();
                materia1.Codigo = (string)reader["Codigo"];
                materia1.Nombre = (string)reader["Nombre"];
                materia1.UV = (int)reader["UV"];
                //int a = int.Parse((string)reader["Grupo"]); SOLUCIONAR DESPUES
                //materia1.Grupo = a;
                try
                {
                    materia1.Prerequisito = (string)reader["Prerequisito"];
                }
                catch
                {
                    materia1.Prerequisito = "";
                }
                materiasP.Add(materia1);
            }

            return materiasP;
        }
        
    }
}
