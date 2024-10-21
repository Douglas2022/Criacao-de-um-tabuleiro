﻿using System;
using tabuleiro;

namespace Xadrez10
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++) 
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i,j) + " ");
                    }
                }
                               
                Console.WriteLine();
            
            }
        }
    }
}
