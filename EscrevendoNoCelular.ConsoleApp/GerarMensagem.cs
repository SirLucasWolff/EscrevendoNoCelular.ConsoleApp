using System;

namespace EscrevendoNoCelular.ConsoleApp
{
    internal class GerarMensagem
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

        internal static void Mensagem()
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

            //opcao = Frases.CANTAR;
            opcao = Frases.CINEMA;
            //opcao = Frases.OI;
            //opcao = Frases.PIPOCA;
            //opcao = Frases.COMENDO;

            if (opcao == Frases.OI)
            {
                Oi(I, O);
            }

            if (opcao == Frases.COMENDO)
            {
                Comendo(C, D, E, M, N, O);
            }

            if (opcao == Frases.CINEMA)
            {
                Cinema(A, C, E, I, M, N);
            }

            if (opcao == Frases.PIPOCA)
            {
                Pipoca(A, C, I, O, P);
            }

            if (opcao == Frases.CANTAR)
            {
                Cantar(A, C, N, R, T);
            }
        }

        private static void Oi(int I, int O)
        {
            Console.WriteLine(Frases.OI);
            Console.Write(O.GetHashCode());
            Console.Write(I.GetHashCode());
            Console.ReadKey();
        }

        private static void Cinema(int A, int C, int E, int I, int M, int N)
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

        private static void Pipoca(int A, int C, int I, int O, int P)
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

        private static void Cantar(int A, int C, int N, int R, int T)
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

        private static void Comendo(int C, int D, int E, int M, int N, int O)
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

    }
}