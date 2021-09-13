using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada() : base("Mesansaje de error desde una extension")
        {

        }
    }
}
