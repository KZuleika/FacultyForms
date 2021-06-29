using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class Alumno
    {
        public int Matricula { get; }
        public string NombreCompleto { get; }

        public Alumno(int matricula, string nombreCompleto)
        {
            Matricula = matricula;
            NombreCompleto = nombreCompleto;
        }
    }

    public partial class SQLiteConn
    {
        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            string sql = "SELECT matricula, apellido   || ',' || nombre AS nombre_completo"
                + " FROM alumnos"
                + " ORDER BY  matricula;";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    alumnos.Add(new Alumno(rs.GetInt32("matricula"),
                                           rs.GetString("nombre_completo")));
                }
            }


            return alumnos;
        }
    }
}
