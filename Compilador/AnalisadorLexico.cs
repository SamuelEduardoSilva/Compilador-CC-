using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Compilador
{
    class AnalisadorLexico
    {

        List<Token> tokens;
        public String analiseLexica;
        public  AnalisadorLexico()
        {
           string[] lines = System.IO.File.ReadAllLines(@"Tokens.txt");
            tokens = new List<Token>();
           foreach(string line in lines)
           {
                String[] subs = line.Split('&');
                Token x = new Token(subs[0], subs[1], subs[2]);
                tokens.Add(x);
            }
           
        }
        public bool Analisa(string texto)
        {
            String[] subs = texto.Split(new Char[] { '\n', ' ' , '\r' },
                                 StringSplitOptions.RemoveEmptyEntries);

            analiseLexica = "";
            int linha = 0;
            bool erro = false;
           
            foreach(string x in subs)
            {
                string termo = x;

                int coluna = 0;     
                Console.WriteLine(termo);
                linha++;
                bool achou = false;
                foreach(Token t in tokens)
                {
                    Console.Write(t.Regex);
                    Regex rgx = new Regex(t.Regex);
                    if (rgx.IsMatch(termo))
                    {
                        analiseLexica += ("Token " + linha + " encontrado! -> " + termo + " = " + t.Desc + System.Environment.NewLine);
                        achou = true;
                        break;
                    }
                }
                if (!achou)
                {

                    analiseLexica += "Erro léxico! O termo " + termo + " não corresponde a nenhum token da linguagem!" + System.Environment.NewLine;
                    erro = true;
                }
                   
            }

            return erro;
        }
    }
}
