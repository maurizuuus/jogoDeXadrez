﻿using System;
using Entities.Tabuleiro;

namespace xadrez_console;

internal class Program
{
    static void Main(string[] args)
    {
        Posicao p;

        p = new Posicao(3, 4);

        Console.WriteLine("Posição: " + p);

    }
}