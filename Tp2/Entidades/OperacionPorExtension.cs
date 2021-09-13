using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class OperacionPorExtension 
    {
        
        public static int DivisionPor(this int dividendo ,int divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch (Exception)
            {

                throw new ExcepcionPersonalizada();
            }

            
        }
       
    }
}
