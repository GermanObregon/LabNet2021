using System;

using System.Threading;
using TransportePublicoApp.Aplicacion;

namespace TransportePublicoApp.Pantallas
{
    public class MenuPrincipal
    {
        EnListarTransportes Transportes = new EnListarTransportes();
        public MenuPrincipal()
        {
            Console.WindowWidth = 138;
            Console.Title = "Menu Principal";
            Console.Clear();
            
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Por Favor elija una opcion para continuar \n" +
                                "\n \t 1-Crear un Taxi. \n" +
                                "\t 2-Crear Omnibus \n" +
                                "\t 3-Dar marcha a Transportes. \n" +
                                "\t 4-Detener Transportes. \n" +
                                "\t 5-Salir. \n");
            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine("Su Opcion:");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 5)
                {
                    Console.WriteLine("No existe esa opcion");
                    Thread.Sleep(2000);
                    Run();

                }
                switch (opcion)
                {

                    case 1:
                        CrearTaxi();
                        break;

                    case 2:
                        CrearOmnibus();
                        break;
                    
                    case 3:
                        PonerEnMarcha();
                        break;

                    case 4:
                        DetenerLaMarcha();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }

            }
            catch (Exception)
            {
                Console.WriteLine("No selecciono ninguna Opcion");
                Thread.Sleep(2000);
                Run();
            }




        }
        private void CrearOmnibus() {
            Console.Clear();
            try
            {
                Console.WriteLine("Indique numero de Linea: \n");
                int NumeroLinea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indique cantidad de pasajeros: \n");
                int CantidadPasajeros = Convert.ToInt32(Console.ReadLine());
                Omnibus Omnibus = new Omnibus(NumeroLinea, CantidadPasajeros);
                Transportes.EnlistarOmnibus(Omnibus);
                Console.WriteLine("Omnibus creado con exito. \n");
                Thread.Sleep(2000);
                Run();
            }
            catch (Exception)
            {

                Console.WriteLine("Indique un numero por favor.");
                Thread.Sleep(2000);
                CrearOmnibus();
            }

        }
       
        private void CrearTaxi()
        {
            Console.Clear();
            Taxi Taxi;
            try
            {
                Console.WriteLine("Indique numero de taxi: \n");
                int NumeroTaxi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indique cantidad de pasajeros: \n");
                int CantidadPasajeros = Convert.ToInt32(Console.ReadLine());
                Taxi = new Taxi(NumeroTaxi, CantidadPasajeros);
                Transportes.EnlistarTaxi(Taxi);
                Console.WriteLine("Taxi creado con exito. \n");
                Thread.Sleep(2000);
                Run();
            }
            catch (Exception)
            {

                Console.WriteLine("Indique un numero por favor.");
                Thread.Sleep(2000);
                CrearTaxi();
            }

            
        }
        private void DetenerLaMarcha()
        {
            {
                Console.Clear();
                Console.WriteLine("Deteniendo Marcha...");
                Console.WriteLine("=======================================================================================================================================");

                if (Transportes.GetTaxis().Count != 0)
                {
                    for (int i = 0; i < Transportes.GetTaxis().Count; i++)
                    {
                        string Detener = Transportes.GetTaxis()[i].Detener();
                        Console.WriteLine(Detener);
                        
                        Thread.Sleep(500);

                    }
                    Transportes.GetTaxis().Clear();
                }
                else
                {
                    Console.WriteLine("No hay ningun Taxi para Detener la marcha");

                }

                if (Transportes.GetOmnibus().Count != 0)
                {
                    for (int i = 0; i < Transportes.GetOmnibus().Count; i++)
                    {
                        string Detener = Transportes.GetOmnibus()[i].Detener();
                        Console.WriteLine(Detener);
                        
                        Thread.Sleep(500);

                    }
                    Transportes.GetOmnibus().Clear();
                }
                else
                {
                    Console.WriteLine("No hay ningun Omnibus para Detener la marcha marcha");
                }
                Console.WriteLine("Volviendo al Menu Principal...");
                Thread.Sleep(4000);
                Run();

            }

        }
        private void PonerEnMarcha()
        {
            Console.Clear();
            Console.WriteLine("Poniemdo en Marcha...");
            Console.WriteLine("=======================================================================================================================================");

            if (Transportes.GetTaxis().Count != 0)
            {
                for (int i = 0; i < Transportes.GetTaxis().Count; i++)
                {
                    string avanzar = Transportes.GetTaxis()[i].Avanzar();
                    Console.WriteLine(avanzar);
                    Thread.Sleep(500);

                }
            }
            else
            {
                Console.WriteLine("No hay ningun Taxi para poner en marcha");

            }

            if (Transportes.GetOmnibus().Count != 0)
            {
                for (int i = 0; i < Transportes.GetOmnibus().Count; i++)
                {
                    string avanzar = Transportes.GetOmnibus()[i].Avanzar();
                    Console.WriteLine(avanzar);
                    Thread.Sleep(500);

                }
            }
            else
            {
                Console.WriteLine("No hay ningun Omnibus para poner en marcha");
            }
            Console.WriteLine("Volviendo al Menu Principal...");
            Thread.Sleep(4000);
            Run();

        }
    }
}
