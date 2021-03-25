using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();

            List<Empleado> listaempleados = new List<Empleado>();



            Cargar();
            for (int valor = 0; valor<listaempleados.Count; valor++)
            {
               if(emp.salario < listaempleados[valor].salario)
                {
                    emp = listaempleados[valor];
                }
               
            }

            Console.WriteLine($"El empleado con el salario mayor es {emp.Nombre}");
            Console.WriteLine($"Tiene un salario de {emp.salario}");

            Console.WriteLine("Enter para terminar");
            Console.ReadKey();
            void Cargar()
            {
                listaempleados.Add(new Empleado(){ Nombre = "Luis", salario = 15000 });
                listaempleados.Add(new Empleado() { Nombre = "Maria", salario = 15000 });
                listaempleados.Add(new Empleado() { Nombre = "Jose", salario = 10000 });
                listaempleados.Add(new Empleado() { Nombre = "Daniela", salario = 35000 });
                listaempleados.Add(new Empleado() { Nombre = "Naomi", salario = 25000 });

            }
        }
        
    }
}
