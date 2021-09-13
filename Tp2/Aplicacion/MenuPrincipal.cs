using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Aplicacion
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
                                "\n \t 1-Ejercicio 1 \n" +
                                "\t 2-Ejercicio 2 y 3 \n" +
                                "\t 3-Ejercicio 4 \n" +
                                "\t 4-Cerrar Programa \n");
            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine("Su Opcion:");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 4)
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
                            int numero;
                            Console.WriteLine("Ingrese un Numero Entero");
                            numero = Convert.ToInt32(Console.ReadLine());
                            DivisionPorCero(numero);
                            break;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);

                        }
                        finally 
                        {
                            Console.WriteLine("Se termino la Operacion");
                            Thread.Sleep(4000);
                            Run();

                        }
                        break;
                    
                    case 2:
                        try
                        {
                            Console.WriteLine("Ingrese un Numero Natural (Dividendo)");
                            int auxDividendo = Convert.ToInt32(Console.ReadLine());
                            NumeroNatural dividendo = new NumeroNatural(auxDividendo);
                            Console.WriteLine("Ingrese un Numero Natural (Divisor)");
                            int divisor = Convert.ToInt32(Console.ReadLine());
                            int resultado = dividendo.DividirPor(divisor);
                            Console.WriteLine($"El resultado de la division es: {resultado}");


                        }
                        catch (DivideByZeroException e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("No se Puede dividir por cer ni con el chasquido del gautelete de Thanos");
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine("No ingreso un Numero");
                        }
                        finally
                        {
                            Console.WriteLine("Se termino la Operacion");
                            Thread.Sleep(6000);
                            Run();
                        }
                        

                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Ingrese un Numero Natural (Dividendo)");
                            int auxDividendo = Convert.ToInt32(Console.ReadLine());
                            NumeroNatural dividendo = new NumeroNatural(auxDividendo);
                            Console.WriteLine("Ingrese un Numero Natural (Divisor)");
                            int divisor = Convert.ToInt32(Console.ReadLine());
                            int resultado = dividendo.DivisionPorExtension(divisor);
                            Console.WriteLine($"El resultado de la division es: {resultado}");

                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message); 
                        }
                        finally
                        {
                            Console.WriteLine("Se termino la Operacion");
                            Thread.Sleep(6000);
                            Run();
                        }

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
        public static int DivisionPorCero(int numero)
        {
            return numero / 0;
        }
        public static int DivisionEntre2Numeros (NumeroNatural divisor , NumeroNatural dividendo)
        {
            return dividendo.Numero / divisor.Numero;
        }
    }
}
