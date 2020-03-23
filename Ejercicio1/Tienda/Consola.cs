using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tienda.Consola
{
    class Consola
    {
        static void Main(string[] args)
        {

            String caseSwitch = "";
            String nombreU = "";
            int salir = 0;
            Negocio neg1 = new Negocio();

            while (salir == 0)
            {

                Console.WriteLine("Selecciona una opción: ");
                Console.WriteLine("1.-Insertar Usuario");
                Console.WriteLine("2.-Mostar Usuario (necesito nombre)");
                Console.WriteLine("0.-salir)");
                caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("Insertar usuario");
                        Consola.insertar(neg1);
                        break;
                    case "2":
                        Console.WriteLine("Recuperar por nombre: ");
                        nombreU = Console.ReadLine();
                        Consola.mostrar(neg1, nombreU);
                        break;
                    case "0":
                        salir = 1;
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }

            }
            



        }
        public static void insertar(Negocio nego)
        {
            String n, a, num;
            Console.WriteLine("Dame Nombre: ");
            n= Console.ReadLine();
            Console.WriteLine("Dame Apellido: ");
            a= Console.ReadLine();
            Console.WriteLine("Dame Numero: ");
            num= Console.ReadLine();
            nego.InsertarEnRepositorio(n, a, num);

            Consola.mostrar(nego, n);


        }
        public static void mostrar(Negocio nego,string nombreUsu)
        {
            int idUsu = 1;
            idUsu = nego.BuscarEnRepositorioPorNombre(nombreUsu);
            Console.WriteLine("Mostrando usuario:");
            Console.WriteLine("Id: {0}", idUsu);
            Console.WriteLine("Nombre: {0}",nego.ObtieneNombreUsuario(idUsu));
            Console.WriteLine("Apellido: {0}", nego.ObtieneApellidoUsuario(idUsu));
            Console.WriteLine("Numero: {0}", nego.ObtieneNumeroUsuario(idUsu));

        }

    }
}
