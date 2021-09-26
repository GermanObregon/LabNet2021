using Domain.DTO_S;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5.UI
{
    public static class HelperExtension
    {
        public static void ImprimirCustomer(this Customers customer)
        {
            Console.WriteLine($"Nombre Compañia: {customer.CompanyName} \n Nombre Contacto: {customer.ContactName}\n Ciudad: {customer.City} \n Pais: {customer.Country}");
        }
        public static void ImprimirCustomers(this List<CustomerDto> customers)
        {
            foreach (CustomerDto customer in customers)
            {
                Console.WriteLine($"Nombre Compañia: {customer.NombreCompania} \n Nombre Contacto: {customer.NombreContacto}\n Ciudad: {customer.Ciudad} \n Pais: {customer.Pais} \n Region: {customer.Region}");

            }
        }
        public static void ImprimirProductsCategories(this List<ProductCategoryDto> products)
        {
            foreach (ProductCategoryDto product in products)
            {
                Console.WriteLine($"Nombre Producto: {product.NombreProducto} \n Categoria: {product.Categoria}\n Precio Unitario: {product.PrecioUnitario} \n Stock: {product.Stock}");
            }

        }
        public static void ImprimirProductCategory(this ProductCategoryDto product)
        {
            Console.WriteLine($"Nombre Producto: {product.NombreProducto} \n Categoria: {product.Categoria}\n Precio Unitario: {product.PrecioUnitario} \n Stock: {product.Stock}");


        }
        public static void ImprimirCustomersMayusculasYMinusculas(this List<CustomerDto> customers)
        {
            foreach (CustomerDto customer in customers)
            {
                string mayusculas = customer.NombreCompania.ToUpper();
                string minusculas = customer.NombreCompania.ToLower();
                Console.WriteLine($"Nombre Compania => Mayusculas: {mayusculas} , Minusculas : {minusculas}");
            }
        }
        public static void ImprimirCustomerOrders(this List<CustomerOrdersDto> customers)
        {
            foreach (CustomerOrdersDto customer in customers)
            {
                Console.WriteLine($"Nombre Compañia: {customer.NombreCompania} \n Nombre Contacto: {customer.NombreContacto}\n Region: {customer.Region} \n Numero Orden: {customer.OrdenId} \n Fecha Orden: {customer.FechaOrden}\n");

            }
        }
        public static void ImprimirDistintosCustomersCantidadOrdenes(this List<Customers> customers)
        {
            //string aux = "";
            
            foreach (var customer in customers)
            {
                Console.WriteLine($"Nombre Compañia: {customer.CompanyName} , Contidad de Ordenes: {customer.Orders.Count}");
                //if (aux != customer.CompanyName)
                //{
                //    Console.WriteLine($"Nombre Compañia: {customer.CompanyName} \n Cantidad de Ordenes: {customer.}\n");
                //}
                //else
                //{
                //    Console.WriteLine($"Numero Orden: {customer.IdOrden}\n");
                //}
                //aux = customer.NombreCompania;
                
            }
            

        }
    }
}
