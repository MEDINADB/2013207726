using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaquetesTuristicos.Entities;

namespace PaquetesTuristicos
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateVentas data= new CreateVentas();
            List<VentaPaquete> listaVentas = data.generarVentas();

            Imprimir print = new Imprimir();
            Console.WriteLine("REPORTE VENTAS");

            for (int i = 0; i < listaVentas.Count; i++)
            {
                Console.WriteLine();
                print.ImprimirVenta(listaVentas[i]);
                Console.WriteLine("===============================================================");

            }



        }
    }
}
