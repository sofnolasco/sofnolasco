using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace S17_SN_1143924
{
    internal class Program
    {
        //ACA VAN VARIABLES LOCALES

        //struct con info del medicamento 1.
        public struct medicamento
        {
            public string codigo;
            public string nombre;
            public int inventario;
            public decimal precio;

        }
        
            //ARREGOS para struct

            //1. arreglo medicamento, es tipo struct (medicamento), se llama "listadoMedicamentos y tiene ìndice [6] (osea 7 espacios 0-6)
            public static medicamento[] listadoMedicamentos = new medicamento[6];

    
    
            
        
        static void Main(string[] args)
        {
            medicamento med;
            med = new medicamento();
            med.codigo = "000";
            med.nombre = "ASPIRINA";
            med.inventario = 50;
            med.precio = 2;
            //para asignarle su lugar
            listadoMedicamentos[0]= med;

            med = new medicamento();
            med.codigo = "001";
            med.nombre = "DICLOFENACO";
            med.inventario = 45;
            med.precio = 5;
            listadoMedicamentos[1] = med;

            med = new medicamento();
            med.codigo = "002";
            med.nombre = "PASIFLORA";
            med.inventario = 12;
            med.precio = 3;
            listadoMedicamentos[2] = med;

            med = new medicamento();
            med.codigo = "003";
            med.nombre = "PARASETAMOL";
            med.inventario = 20;
            med.precio = 7;
            listadoMedicamentos[3] = med;

            med = new medicamento();
            med.codigo = "004";
            med.nombre = "SUCROL";
            med.inventario = 10;
            med.precio = 4;
            listadoMedicamentos[4] = med;

            med = new medicamento();
            med.codigo = "005";
            med.nombre = "JARABE PARA LA TOS";
            med.inventario = 8;
            med.precio = 12;
            listadoMedicamentos[5] = med;

            for (int i = 0; i <6; i++)
            {
                Console.WriteLine("còdigo: " + listadoMedicamentos[i].codigo+ " "+ "nombre: " + listadoMedicamentos[i].nombre + "  "+ "inventario: " + listadoMedicamentos[i].inventario + " precio: Q" + listadoMedicamentos[i].precio);
            }
            Console.ReadKey();

        }
       
    }
    
}
