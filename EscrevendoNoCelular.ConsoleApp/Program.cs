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
        public static void Main(string[] args)
        {
            TelaInicial.Menu();
            return;
        }
    }
}
