using System;
using System.Collections.Generic;

using System.Threading;

using Tp4.AccesData.Command;
using Tp4.AccesData.Queries;
using Tp4.AccesData.Validations;
using Tp4.Domain.DTO_S;
using Tp4.Domain.Models;
using FluentValidation;

namespace Tp4.Application
{
    public class MenuPrincipal
    {
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
                                "\n \t 1-Consultar Nombres de Clientes. \n" +
                                "\t 2-Consultar Nombre Cliente, Numero de Orden, Producto y Precio Unitario. \n" +
                                "\t 3-Agregar nueva Empresa de Envios. \n" +
                                "\t 4-Editar una Empresa de Envios. \n" +
                                "\t 5-Borrar empresa de envios. \n +" +
                                "\t 6-Listar empresas de envios. \n" +
                                "\t 7-Cerrar Programa.");
            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine("Su Opcion:");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 7)
                {
                    Console.WriteLine("No existe esa opcion");
                    Thread.Sleep(2000);
                    Run();

                }
                switch (opcion)
                {

                    case 1:
                        NombreClientesQuery Consulta = new NombreClientesQuery();
                        foreach (ClienteDto item in Consulta.GetAllClients())
                        {
                            Console.WriteLine($"Nombre de Cliente: {item.NombreCliente}");
                        }
                        Console.WriteLine("Presione Enter para Volver al Menu Principal");
                        Console.ReadLine();
                        Run();
                        break;
                    case 2:
                        string aux = "";
                        NombreClienteOrdenProducto consulta = new NombreClienteOrdenProducto();
                        foreach (NombreClienteOrdenProductoDto item in consulta.GetClientOrderProducts())
                        {
                            if (aux != item.IdOrden.ToString())
                            {
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Numero de Ordem: {item.IdOrden} , Nombre Cliente: {item.NombreCliente}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"\t Producto: {item.NombreProducto} , Precio Unitario: {item.PrecioUnitario}");

                                aux = item.IdOrden.ToString();

                            }
                            else 
                            {
                                Console.WriteLine($"\t Producto: {item.NombreProducto} , Precio Unitario: {item.PrecioUnitario}");
                            }

                           
                        }
                        Console.WriteLine("Presione Enter para Volver al Menu Principal");
                        Console.ReadLine();
                        Run();
                        break;
                    case 3:
                        ListarShippers();
                        AgregarCompania();
                        Run();
                        break;

                    case 4:
                        List<Shippers> shippers = ListarShippers();
                        Console.WriteLine("Selecione opcion de la compania que quiere editar");
                        int seleccion = Convert.ToInt32(Console.ReadLine());
                        if (seleccion > shippers.Count)
                        {
                            Console.WriteLine("No ingreso una opcion correcta");
                            Console.WriteLine("Volviendo al Menu Principal...");
                            Thread.Sleep(3000);
                            Run();
                        }
                        else
                        {
                            try
                            {
                                Console.WriteLine("Ingrese Nuevo Nombre");
                                string nuevoNombre = Console.ReadLine();
                                Console.WriteLine("Ingrese nuevo Telefono");
                                string nuevoTelefono = Console.ReadLine();
                                var shipper = new Shippers
                                {
                                    ShipperID = shippers[seleccion - 1].ShipperID,
                                    CompanyName = nuevoNombre,
                                    Phone = nuevoTelefono

                                };
                                ValidarShipper(shipper);
                                GenericRepository repositorio = new GenericRepository();
                                repositorio.Update<Shippers>(shipper);
                                Console.WriteLine("Se edito con exito");
                                Thread.Sleep(3000);
                                Run();

                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e.Message);
                                Thread.Sleep(3000);
                                Run();
                            }
                           
                        }
                       


                        break;
                    case 5:
                        List<Shippers> listaShippers = ListarShippers();
                        Console.WriteLine("Selecione opcion de la compania que quiere Borrar");
                        int selec = Convert.ToInt32(Console.ReadLine());
                        if (selec > listaShippers.Count)
                        {
                            Console.WriteLine("No ingreso una opcion correcta");
                            Console.WriteLine("Volviendo al Menu Principal...");
                            Thread.Sleep(3000);
                            Run();
                        }
                        else
                        {
                            var borrarShipper = new Shippers
                            {
                                ShipperID = listaShippers[selec - 1].ShipperID,
                                CompanyName = listaShippers[selec - 1].CompanyName,
                                Phone = listaShippers[selec - 1].Phone
                            };
                            GenericRepository repositorio = new GenericRepository();
                            repositorio.Delete<Shippers>(borrarShipper);
                            Console.WriteLine("Se Borro con exito");
                            Thread.Sleep(3000);
                            Run();
                        }
                        break;
                    case 6:
                        ListarShippers();
                        Console.WriteLine("Presione Enter para volver al Menu Principal");
                        Console.ReadLine();
                        Run();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                }

            }
            catch (Exception )
            {
                
                Console.WriteLine("No selecciono ninguna Opcion");
                Thread.Sleep(2000);
                Run();
            }



        }
        private static List<Shippers> ListarShippers()
        {
            Console.Clear();
            CompaniasEnvios consulta = new CompaniasEnvios();
            Console.WriteLine("Companias Existentes: \n");
            int contador = 1;
            foreach (Shippers item in consulta.GetShippers())
            {
                Console.WriteLine($" \t {contador} - Nombre Compania: {item.CompanyName} , Numero Telefono: {item.Phone} \n");
                contador++;
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            return consulta.GetShippers();
            //Console.ReadLine();
        }
        private static void AgregarCompania()
        {
            try
            {
                Console.WriteLine("Ingrese Nombre de la Compania:");
                string nombreCompania = Console.ReadLine();
                Console.WriteLine("Ingrese Numero de Telefono");
                string telefono = Console.ReadLine();
                Shippers nuevo = new Shippers
                {
                    CompanyName = nombreCompania,
                    Phone = telefono
                };
                ValidarShipper(nuevo);
                GenericRepository repositorio = new GenericRepository();
                repositorio.Add<Shippers>(nuevo);
                Console.WriteLine("Agregado con Exito");
                Console.WriteLine("Presione Enter para Volver al Menu Principal");
                Console.ReadLine();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(3000);
                AgregarCompania();
            }
              

        }
        private static void ValidarShipper(Shippers shipper)
        {
            var validar = new ShipperValidator();
            validar.ValidateAndThrow(shipper);
        }

    }

}

