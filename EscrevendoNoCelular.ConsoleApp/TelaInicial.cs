using System;

namespace EscrevendoNoCelular.ConsoleApp
{
    internal class TelaInicial
    {
        private static MenuInicial opcao;

        public enum MenuInicial
        {
            Iniciar,
            Sair,
        }

        internal static bool Menu()
        {
            opcao = MenuInicial.Iniciar;
            //opcao = MenuInicial.Sair;

            if (opcao == MenuInicial.Iniciar)
            {
                GerarMensagem.Mensagem();
            }

            if (opcao == MenuInicial.Sair)
            {
                Console.WriteLine("Perdeu Playboy!");
                return false;
            }

            return Menu();
        }
    }
}