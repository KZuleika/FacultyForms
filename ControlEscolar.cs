using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;

namespace Faculty
{

    public class ControlEscolar
    {
        private SQLiteConn conn;

        public ControlEscolar()
        {
            conn = new SQLiteConn("faculty.db", true);
        }

        public List<Alumno> GetAlumnos()
        {
            return conn.GetAlumnos();
        }

        public List<Alumno> GetAlumnos(bool alfabetico)
        {   if(!alfabetico) return conn.GetAlumnos();
            return conn.GetAlumnosAlf();
        }

        public List<Materia> GetMaterias()
        {
            return conn.GetMaterias();
        }

        public List<Materia> MateriasActualizablesPorAlumno(int matricula)
        {
            return conn.MateriasActualizablesPorAlumno(matricula);
        }

        public void Close()
        {
            conn.Close();
        }

        public bool AltaAlumno(int matricula, string apellido, string nombre)
        {
            if (!conn.ValidarAlumno(matricula)) return false;
            else
            {
                conn.AltaAlumno(matricula, apellido, nombre);
            }
            return true;
        }
        public void AsignarCalificacion(int matricula, int clave, int calificacion)
        {
            conn.AsignarCalificacion(matricula, clave, calificacion);
        }

        public List<AlumnoPromedio> GetAlumnosPromedioTotal()
        {
            return conn.GetAlumnosPromedioTotal();
        }
        public List<AlumnoPromedio> GetAlumnosPromedioParcial()
        {
            return conn.GetAlumnosPromedioParcial();
        }
    }
}
