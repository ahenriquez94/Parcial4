using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaMantenimiento
{
    public class Mantenimiento
    {
        Conexion cn = new Conexion();

        public String Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int doctor_no, hospital_cod;

        public int Hospital_cod
        {
            get { return hospital_cod; }
            set { hospital_cod = value; }
        }

        public int Doctor_no
        {
            get { return doctor_no; }
            set { doctor_no = value; }
        }
        private String apellido, especialidad;

       

        

        public void insertardoctor()
        {
            try
            {
                String insert = "INSERT INTO Doctor(Doctor_No,Hospital_Cod,Apellido,Especialidad)VALUES('" + doctor_no + "','" + hospital_cod + "','" + apellido + "','" + especialidad + "')";
                cn.Conectar();
            }
            catch
            {

            }
        }
    }
}
