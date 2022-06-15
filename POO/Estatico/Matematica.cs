using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    static internal class Matematica
    {
        public static int taxa = 0;

        public static int somar(int valor)
        {
            return valor + taxa;
        }
        public static int subtrair(int valor)
        {
            return valor - taxa;
        }

    }
}
