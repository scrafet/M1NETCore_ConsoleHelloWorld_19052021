using System;
using System.Collections.Generic;
using System.Linq;

namespace M1NETCore_ConsoleHelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String nombreCurso = ".NET Core web con C#";
            int edad = 30;
            double monto = 350.5;

            string salario = "Mil dolares";
            string detalleEdad = String.Empty;

            //List<Persona> listado = new List<Persona>();
            var listado = new List<Persona>();

            var per1 = new Persona();
            per1.dni = "12456398";
            per1.nombre = "Jose Paolo";
            per1.telefono = 122356457;

            var per2 = new Persona("23456789", "Jefferson Carlos", 2345551);

            var per3 = new Persona();
            per3.dni = "23568978";
            per3.nombre = "Jaime";
            per3.telefono = 33652112;

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(per3);

            listado.Add(new Persona("33445566", "Edison Miguel", 363534));

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " +
                                    item.nombre + " " +
                                    item.telefono);
            }

            var busqueda = listado.Where(x => x.dni == "23456789").FirstOrDefault();

            Console.WriteLine("Se encontro a :" + busqueda.nombre);

            //Console.WriteLine("");
        }
    }
}