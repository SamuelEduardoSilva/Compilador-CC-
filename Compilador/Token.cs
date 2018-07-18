using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    class Token
    {
       
        public string Nome { get; set; }
        public string Regex { get; set; }
        public string Desc { get; set; }

        public Token(string nome, string regex, string desc)
        {
            Nome = nome;
            Regex = regex;
            Desc = desc;
        }
    }
}
