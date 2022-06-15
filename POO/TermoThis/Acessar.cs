using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        string user = "admin";
        string pass = "123abc";
        
        public bool login (string user, string pass)
        {
            return this.user == user && this.pass == pass;
            // nesse caso o this server para distinguir de qual
            // variável estamos falando, pois existem duas iguais
        }

    }
}
