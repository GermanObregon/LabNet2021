using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroNatural : INumeroEntero
    {
        public int Numero { get; set; }
        public NumeroNatural(int numero)
        {
            this.Numero = numero;
        }
        public int DividirPor(int numero)
        {
            try
            {
                return Numero / numero;
            }
            catch (DivideByZeroException e)
            {

                throw e;
            }

            

        }

        public int MultiplicarPor(int numero)
        {
            return Numero * numero;
        }

        public int Restar(int numero)
        {
            return Numero - numero;
        }

        public int Sumar(int numero)
        {
            return Numero + numero;
        }

        public int DivisionPorExtension(int numero)
        {
            return OperacionPorExtension.DivisionPor(Numero, numero);
        //    try
        //    {
               
        //    }
        //    catch (ExcepcionPersonalizada e)
        //    {

        //        throw e;
        //    }
        }
        public static void ThrowExcepcionPersonalizada()
        {
            throw new ExcepcionPersonalizada();
        }
    }


}
