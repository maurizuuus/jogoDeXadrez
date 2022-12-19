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
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 9));


            Tela.ImprimirTabuleiro(tab);
        }
        catch (TabuleiroExeception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}