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

        public void Close()
        {
            conn.Close();
        }
    }
}
