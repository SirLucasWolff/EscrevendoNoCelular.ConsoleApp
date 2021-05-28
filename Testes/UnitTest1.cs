using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        private object Frases;
        private FrasesTeste opcao;

        public enum FrasesTeste
        {
            CINEMA,
            PIPOCA,
            COMENDO,
            CANTAR,
            OI,
        }

        [TestMethod]
        public void TestMethod1()
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
            opcao = FrasesTeste.PIPOCA;
            //opcao = Frases.CANTAR;
            //opcao = Frases.CINEMA;


            if (opcao == FrasesTeste.OI)
            {
                Console.WriteLine(FrasesTeste.OI);
                Console.Write(O.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == FrasesTeste.COMENDO)
            {
                Console.WriteLine(FrasesTeste.COMENDO);
                Console.Write(C.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.Write(M.GetHashCode());
                Console.Write(E.GetHashCode());
                Console.Write(N.GetHashCode());
                Console.Write(D.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == FrasesTeste.CINEMA)
            {
                Console.WriteLine(FrasesTeste.CINEMA);
                Console.Write(C.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.Write(N.GetHashCode());
                Console.Write(E.GetHashCode());
                Console.Write(M.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == FrasesTeste.PIPOCA)
            {
                Console.WriteLine(FrasesTeste.PIPOCA);
                Console.Write(P.GetHashCode());
                Console.Write(I.GetHashCode());
                Console.Write(P.GetHashCode());
                Console.Write(O.GetHashCode());
                Console.Write(C.GetHashCode());
                Console.Write(A.GetHashCode());
                Console.ReadKey();
            }

            if (opcao == FrasesTeste.CANTAR)
            {
                Console.WriteLine(FrasesTeste.CANTAR);
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
