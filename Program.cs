﻿using System;

namespace aplicacaoConsoleDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes = 10;
            for (int i=0; i< numeroDeVezes; i++){
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            }
        }
    }
}
