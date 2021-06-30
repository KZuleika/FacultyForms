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

        public string NombreCompletoMatricula => $"{NombreCompleto} - {Matricula}";
        public Alumno(int matricula, string nombreCompleto)
        {
            Matricula = matricula;
            NombreCompleto = nombreCompleto;
        }
    }

    public class Materia
    {
        public int Clave { get; }
        public string Nombre { get; }
        public int Creditos { get; }
        public string NombreConClave => $"{Nombre} - {Clave}";
        public Materia(int clave, string nombre, int creditos)
        {
            Clave = clave;
            Nombre = nombre;
            Creditos = creditos;
        }
    }


    public partial class SQLiteConn
    {
        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            string sql = "SELECT matricula, apellido   || ', ' || nombre AS nombre_completo"
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

        public List<Alumno> GetAlumnosAlf()
        {
            List<Alumno> alumnos = new List<Alumno>();
            string sql = "SELECT matricula, apellido   || ', ' || nombre AS nombre_completo"
                + " FROM alumnos"
                + " ORDER BY  apellido, nombre, matricula;";

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

        public List<Materia> GetMaterias()
        {
            List<Materia> materias = new List<Materia>();
            
            string sql = "SELECT clave, materia, creditos"
                + " FROM materias"
                + " ORDER BY clave;";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    materias.Add(new Materia(rs.GetInt32("clave"),
                                           rs.GetString("materia"),
                                           rs.GetInt32("creditos")));
                }
            }

            return materias;
        }

        public bool ValidarAlumno(int matricula)
        {
            string sql = $"SELECT * FROM alumnos WHERE matricula = {matricula};";
            
            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                return !rs.NextRecord();
            }
        }

        public void AltaAlumno(int matricula, string apellido, string nombre)
        {
            string sql = $" INSERT INTO alumnos (matricula, nombre, apellido)"
                        + $" VALUES({matricula}, '{nombre}', '{apellido}');";
            ExecuteNonQuery(sql);

            sql = "SELECT clave FROM materias ORDER BY clave; ";
            List<int> claves = new List<int>();

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    claves.Add(rs.GetInt32("clave"));
                }
            }
            claves.ForEach(c => {
                sql = $"INSERT INTO calificaciones (matricula, clave, calificacion) VALUES ({matricula}, {c}, -1);";
                ExecuteNonQuery(sql);
            });
        }

        public List<Materia> MateriasActualizablesPorAlumno(int matricula)
        {
            List<Materia> materias = new List<Materia>();

            string sql = "SELECT m.clave as clave, m.materia as materia, c.calificacion as calificacion"
                        + " FROM calificaciones c"
                        + " CROSS JOIN materias m on m.clave = c.clave"
                        + $" WHERE c.matricula = {matricula} AND c.calificacion < 70"
                        + " ORDER BY m.materia; ";

            using (SQLiteRecordSet rs = ExecuteQuery(sql))
            {
                while (rs.NextRecord())
                {
                    materias.Add(new Materia(rs.GetInt32("clave"),
                                           rs.GetString("materia"),
                                           rs.GetInt32("calificacion")));
                }
            }

            return materias;
        }
    }
}
