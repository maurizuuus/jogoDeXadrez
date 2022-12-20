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
            PartidaDeXadrez partida = new PartidaDeXadrez();
           
            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                Console.WriteLine();

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                Console.Write("");
                Console.Write("estino: ");
                Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();
                partida.ExecutaMovimento(origem, Destino);
            }



            Tela.ImprimirTabuleiro(partida.Tab);
        }
        catch (TabuleiroExeception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}