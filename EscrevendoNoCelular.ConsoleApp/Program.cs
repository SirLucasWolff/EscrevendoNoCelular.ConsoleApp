using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    //Para digitar uma mensagem em um aparelho que não possui um teclado QWERTY embutido
    //é necessário fazer algumas combinações das 10 teclas numéricas do aparelho para
    //conseguir digitar.Cada número é associado a um conjunto de letras como a seguir:

    //Letras -> Número
    //ABC -> 2
    //DEF -> 3
    //GHI -> 4
    //JKL -> 5
    //MNO -> 6
    //PQRS -> 7
    //TUV -> 8
    //WXYZ -> 9
    //Espaço -> 0

    //Por exemplo, para digitar SEMPRE ACESSO O DOJOPUZZLES, você precisa digitar:
    //77773367_7773302_222337777_777766606660366656667889999_9999555337777

    class Program
    {
        private static Frases opcao;

        public enum Frases
        {
            OI,
            COMENDO,
            PIPOCA,
            CINEMA,
            CANTAR,
        }
        
        static void Main(string[] args)
        {
            //ABC
            int A = 2;
            int B = 22;
            int C = 222;
            //

            //DEF
            int D = 3;
            int E = 33;
            int F = 333;
            //

            //GHI
            int G = 4;
            int H = 44;
            int I = 444;
            //

            //JKL
            int J = 5;
            int K = 55;
            int L = 555;
            //

            //MNO
            int M = 6;
            int N = 66;
            int O = 666;
            //

            //PQRS
            int P = 7;
            int Q = 77;
            int R = 777;
            int S = 7777;
            //

            //TUV
            int T = 8;
            int U = 88;
            int V = 888;
            //

            //WXYZ
            int W = 9;
            int X = 99;
            int Y = 999;
            int Z = 9999;
            //

            //ESPAÇO
            int Espaco = 0;
            //

            //OPÇÕES DO MENU
            //opcao = Frases.OI;
            //opcao = Frases.COMENDO;
            opcao = Frases.PIPOCA;
            //opcao = Frases.CANTAR;
            //opcao = Frases.CINEMA;


            if (opcao == Frases.OI)
            {
                Console.WriteLine(Frases.OI);
                Console.Write(O.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == Frases.COMENDO)
            {
                Console.WriteLine(Frases.COMENDO);
                Console.Write(C.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.Write(M.GetHashCode());
                Console.Write(E.GetHashCode());
                Console.Write(N.GetHashCode());
                Console.Write(D.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == Frases.CINEMA)
            {
                Console.WriteLine(Frases.CINEMA);
                Console.Write(C.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.Write(N.GetHashCode());
                Console.Write(E.GetHashCode());
                Console.Write(M.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == Frases.PIPOCA)
            {
                Console.WriteLine(Frases.PIPOCA);
                Console.Write(P.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.Write(P.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.Write(C.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == Frases.CANTAR)
            {
                Console.WriteLine(Frases.CANTAR);
                Console.Write(C.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.Write(N.GetHashCode());
                Console.Write(T.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.Write(R.GetHashCode());
                Console.ReadKey();
            }

            
            
                
        }

        
    }
}
