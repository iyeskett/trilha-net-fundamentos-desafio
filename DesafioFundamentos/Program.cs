﻿using DesafioFundamentos.Models;
using System.Globalization;



// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

try
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:  Ex: 3,5");
    do
    {
        precoInicial = Estacionamento.ConverterPreco(Console.ReadLine());
        if (precoInicial >= 0)
        {
            break;
        }else
            Console.WriteLine("Preço inválido, digite novamente.");

    } while (true);


        Console.WriteLine("Agora digite o preço por hora: Ex: 4,0");
    do
    {
        precoPorHora = Estacionamento.ConverterPreco(Console.ReadLine());
        if (precoPorHora >= 0)
        {
            break;
        }
        else
            Console.WriteLine("Preço inválido, digite novamente.");

    } while (true);

    

    // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
    Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

    string opcao = string.Empty;
    bool exibirMenu = true;

    // Realiza o loop do menu
    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        switch (Console.ReadLine())
        {
            case "1":
                es.AdicionarVeiculo();
                break;

            case "2":
                es.RemoverVeiculo();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }

    Console.WriteLine("O programa se encerrou");
}
catch (Exception e)
{

    Console.WriteLine($"Um erro inesperado aconteceu: {e.Message}");
}


