using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Metodo que recebe uma string com caracter repetido
        /// </summary>
        /// <param name="s">String que vai ser posta </param>
        /// <param name="x">Caracter que vai ser adicionado</param>
        /// <param name="c">Caracter loop</param>
        /// <returns></returns>
        private static string Decor(string s, char x, int c)
        {
            string deco = new string(x, c);
            return $"{deco} {s} {deco}";
        }
        /// <summary>
        /// Inicio do programa
        /// </summary>
        /// <param name="args">Argumentos da linha de comando</param>

        private static void Main (string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine (Decor());
                return;
            }

            string ip = args[0];
            char dc = args[1][0];
            int co = int.Parse (args[2]);

            string BetterDecor = Decor(ip, dc, co);
            Console.WriteLine(BetterDecor);
            
        }
    }
}
