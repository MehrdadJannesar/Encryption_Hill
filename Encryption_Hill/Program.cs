using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Hill
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, Sum = 0, End = 0;
            int[,] MTRX = new int[25, 25];
            int[,] ANS = new int[25, 1];
            string Text = null;

            Console.WriteLine("Enter your text please : " + "\n");
            Text = Console.ReadLine().ToLower();

            char[] Txt = Text.ToCharArray();
            End = Txt.Length;

            for (i = 0; i < End; i++)
            {
                if (Txt[i] != ' ')
                {
                    Txt[i] = Convert.ToChar(Txt[i] - 'a'); 
                }
            }
            Random rnd = new Random();
            for (i = 0; i < End; i++)
            {
                for (j = 0; j < End; j++)
                {

                    MTRX[i, j] = rnd.Next();
                }

            }
            for (i = 0; i < End; i++)
            {

                Sum = 0;
                for (j = 0; j < End; j++)
                {
                    Sum += MTRX[i, j] * (int)Txt[j];
                }
                ANS[i, 0] = Sum;
            }

            Console.Write("Your Encryption Hill is:" + "\n" + "\n");
            for (i = 0; i < End; i++)
            {
                char Hill = (char)(((ANS[i, 0]) % 26) + 97);
                Console.Write(Hill);
            }
            Console.Write("\n"+"\n" + "\n");

        }
    }
}
