using Domain.DTO_S;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tp5.AccesData.Queries;
using Tp5.AccesData.Queries.Repository;
using Tp5.Service;

namespace Tp5.UI
{
    public class MenuPrincipal
    {
        public MenuPrincipal()
        {

            Console.WindowWidth = 150;
            Console.Title = "Menu Principal";
            Console.Clear();
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Por Favor elija una opcion para continuar \n" +
                                "\n \t 1-Query para devolver objeto customer. \n" +
                                "\t 2-Query para devolver todos los productos sin stock. \n" +
                                "\t 3-Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad.\n" +
                                "\t 4-Query para devolver todos los customers de la Región WA. \n" +
                                "\t 5-Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789. \n" +
                                "\t 6-Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula. \n" +
                                "\t 7-Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997. \n" +
                                "\t 8-Query para devolver los primeros 3 Customers de la  Región WA. \n" +
                                "\t 9-Query para devolver lista de productos ordenados por nombre. \n" +
                                "\t 10-Query para devolver lista de productos ordenados por unit in stock de mayor a menor. \n" +
                                "\t 11-Query para devolver las distintas categorías asociadas a los productos. \n" +
                                "\t 12-Query para devolver el primer elemento de una lista de productos. \n" +
                                "\t 13-Query para devolver los customer con la cantidad de ordenes asociadas. \n" +
                                "\t 14-Cerrar Programa \n");
            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine("Su Opcion:");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 14)
                {
                    Console.WriteLine("No existe esa opcion");
                    Thread.Sleep(2000);
                    Run();

                }
                switch (opcion)
                {

                    case 1:
                        try
                        {
                            ICustomersQuery customerQuery = new CustomersQuery();
                            CustomerService customerservice = new CustomerService(customerQuery);
                            Customers customer = customerservice.GetCustomer();
                            HelperExtension.ImprimirCustomer(customer);
                            Console.WriteLine("Presione Enter para volver al Menu Principal...");
                            Console.ReadLine();
                            Run();
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                       

                        break;
                    case 2:
                        IProductsQuery productsQuery = new ProductsQuery();
                        ProductsService porductService = new ProductsService(productsQuery);
                        HelperExtension.ImprimirProductsCategories(porductService.GetProductSinStock());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 3:
                        IProductsQuery productsQuery2 = new ProductsQuery();
                        ProductsService porductService2 = new ProductsService(productsQuery2);
                        HelperExtension.ImprimirProductsCategories(porductService2.GetProductConStockYPrecioMayor3());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();
                        break;

                    case 4:
                        ICustomersQuery customerQuery2 = new CustomersQuery();
                        CustomerService customerservice2 = new CustomerService(customerQuery2);
                        List<CustomerDto> customers = customerservice2.GetCustomersWashinton();
                        HelperExtension.ImprimirCustomers(customers);
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();
                        break;
                    case 5:
                        try
                        {
                            IProductsQuery productsQuery3 = new ProductsQuery();
                            ProductsService porductService3 = new ProductsService(productsQuery3);
                            HelperExtension.ImprimirProductCategory(porductService3.GetProductId798());
                            Console.WriteLine("Presione Enter para volver al Menu Principal...");
                            Console.ReadLine();
                            Run();
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("Presione Enter para volver al Menu Principal...");
                            Console.ReadLine();
                            Run();
                        }
                        break;
                    case 6:
                        ICustomersQuery customerQuery3 = new CustomersQuery();
                        CustomerService customerservice3 = new CustomerService(customerQuery3);
                        List<CustomerDto> customers2 = customerservice3.GetAllCustomers();
                        HelperExtension.ImprimirCustomersMayusculasYMinusculas(customers2);
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 7:
                        ICustomersQuery customerQuery4 = new CustomersQuery();
                        CustomerService customerservice4 = new CustomerService(customerQuery4);
                        List<CustomerOrdersDto> customers4 = customerservice4.GetCustomerOrder();
                        HelperExtension.ImprimirCustomerOrders(customers4);
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 8:
                        ICustomersQuery customerQuery5 = new CustomersQuery();
                        CustomerService customerservice5 = new CustomerService(customerQuery5);
                        List<CustomerDto> customers5 = customerservice5.Get3CustomersWA();
                        HelperExtension.ImprimirCustomers(customers5);
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 9:
                        IProductsQuery productsQuery4 = new ProductsQuery();
                        ProductsService porductService4 = new ProductsService(productsQuery4);
                        HelperExtension.ImprimirProductsCategories(porductService4.GetAllProductOrdenadosNombre());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 10:
                        IProductsQuery productsQuery5 = new ProductsQuery();
                        ProductsService porductService5 = new ProductsService(productsQuery5);
                        HelperExtension.ImprimirProductsCategories(porductService5.GetAllProductOrdenadosPrecioUnitario());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 11:
                        IProductsQuery productsQuery6 = new ProductsQuery();
                        ProductsService porductService6 = new ProductsService(productsQuery6);
                        HelperExtension.ImprimirProductsCategories(porductService6.GetAllProduct());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 12:
                        IProductsQuery productsQuery7 = new ProductsQuery();
                        ProductsService porductService7 = new ProductsService(productsQuery7);
                        HelperExtension.ImprimirProductCategory(porductService7.GetFirstProduct());
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 13:
                        ICustomersQuery customerQuery6 = new CustomersQuery();
                        CustomerService customerservice6 = new CustomerService(customerQuery6);
                        List<Customers> customers6 = customerservice6.GetDistintosCustomers();
                        HelperExtension.ImprimirDistintosCustomersCantidadOrdenes(customers6);
                        Console.WriteLine("Presione Enter para volver al Menu Principal...");
                        Console.ReadLine();
                        Run();

                        break;
                    case 14:
                        Environment.Exit(1);
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
       
       
    }
}
