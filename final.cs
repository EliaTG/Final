using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Proyecto_final
{
    class Proyecto_final
    {
        private string[] empleados;
        private double[,] sueldos;
        private double[] sueldosVEC;

        public void Cargar() 
        {
            empleados=new String[5];
            sueldos=new double[5,3];
            Console.Write("Solo puede ingresar numeros en sueldos\n");
            for(int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                empleados[f]=Console.ReadLine();
                for(int c = 0; c < sueldos.GetLength(1); c++) 
                {                 
                    Console.Write("Ingrese sueldo:");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f,c]=double.Parse(linea);
                }
            }
        }

        public void SumaSueldos()
        {
            sueldosVEC = new double[5];
            for (int i = 0; i < sueldos.GetLength(0); i++)
            {
                double suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[i,c];
                }
                sueldosVEC[i] = suma;
            }
        }

        public void ImprimirTotalPagado() 
        {
    	    Console.WriteLine("Total de sueldos pagados por empleado.");
            for(int e = 0; e < sueldosVEC.Length; e++) 
            {
                Console.WriteLine(empleados[e]+" --- "+sueldosVEC[e]);
            }
        }

        public void EmpleadoMayorSueldo() 
        {
            double mayor=sueldosVEC[0];
            string name=empleados[0];
            for(int i = 0; i < sueldosVEC.Length; i++) 
            {
                if (sueldosVEC[i] > mayor) 
                {
                    mayor=sueldosVEC[i];
                    name=empleados[i];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es '{0}' con un sueldo de {1} $",name,mayor);
            Console.WriteLine("Presione INTRO para salir.");
        }

        static void Main(string[] args)
        {
            Proyecto_final p_final = new Proyecto_final();
            p_final.Cargar();
            p_final.SumaSueldos();
            p_final.ImprimirTotalPagado();
            p_final.EmpleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}
