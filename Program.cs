using System;

namespace propiedades_2
{
    internal class Program
    {
        static void Main(string[] Args)
        {
            SueldoEmpleado MiEmpleado = new SueldoEmpleado("", 19);

            Console.WriteLine("Empleado N°1");
            
            Console.WriteLine("NOMBRE: " + MiEmpleado.NOMBRE);
            Console.WriteLine("EDAD: " + MiEmpleado.EDAD);

            MiEmpleado.SUELDO = 9000;
            Console.WriteLine("SUELDO: US$" + MiEmpleado.SUELDO);
        }
    }
    class SueldoEmpleado
    {
        private double _sueldo;
        private string _nombre;
        private int _edad;

        public SueldoEmpleado(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public string NOMBRE
        {
            get => _nombre;           
        }

        public int EDAD
        {
            get { return _edad; }
        }

        private double EvaluaSueldo()
        {
            if (_sueldo < 0)
                return _sueldo = 0;
            
            else            
                return this._sueldo;            
        }

        public double SUELDO
        {
            set => _sueldo = value;

            get => _sueldo;
        }
    }
}