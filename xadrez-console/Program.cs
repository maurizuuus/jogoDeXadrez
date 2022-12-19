using System;
using Entities.Tabuleiro2;
using Entities.Xadrez;
using Entities.Enums;
using Entities.Exceptions;

namespace xadrez_console;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 4));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(3, 4));
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(5, 6));

            


            Tela.ImprimirTabuleiro(tab);
        }
        catch (TabuleiroExeception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}