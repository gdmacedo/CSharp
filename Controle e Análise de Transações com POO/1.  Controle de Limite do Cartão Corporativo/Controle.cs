/*
Projeto...: Controle e Análise de Transações com POO em C#
Módulo....: Controle de Limite do Cartão Corporativo
Data......: 04 de julho de 2025
Autor.....: Macedo, Glener Diniz
Descrição.: Este sistema tem a missão de controlar as despesas para cartões corporativos usados por funcionários. 
            Cada funcionário possui um limite mensal e pode fazer diversas transações. 
            O sistema foi programado para  informar se o funcionário está dentro do limite ou se ultrapassou o valor permitido.
            Este código apresentado aqui têm como objetivo principal exercitar os conceitos aprendidos e proporcionar
            a pratica do desenvolvimento, contato com lógica de programação. 

Entrada...: A entrada contem o limite do cartão (número decimal) e em seguida uma lista com os valores de cada transação feita
            no mês.
            - O primeiro valor representa o limite do cartão.
            - O segundo valor representa a quantidade de transações.
            - As próximas linhas contêm os valores das transações (uma por linha).

Saída.....: Deverá retornar o total gasto e uma mensagem indicando se o limite foi ultrapassado ou não.

Atenção...: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição
            do desafio de código.
            
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


class CartaoCorporativo
{
    public decimal Limite { get; }
    public List<decimal> Transacoes { get; }

    public CartaoCorporativo(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        // Adicionando o valor à lista Transacoes
         Transacoes.Add(valor);
    }

    public decimal CalcularTotal()
    {
        return Transacoes.Sum();
    }

    public bool UltrapassouLimite()
    {
        return CalcularTotal() > Limite;
    }

    public void ExibirResumo()
    {
        // Imprimindo o total gasto com duas casas decimais
        // e uma mensagem informando se o limite foi ultrapassado ou não
        decimal total = CalcularTotal();
        Console.WriteLine("Total gasto: " + total.ToString("F2", CultureInfo.InvariantCulture));

        if (UltrapassouLimite())
        {
            Console.WriteLine("Limite ultrapassado");
        }
        else
        {
            Console.WriteLine("Limite OK");
        }
    }
}

class Program
{
    static void Main()
    {
        decimal limite = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int quantidade = int.Parse(Console.ReadLine());

        var cartao = new CartaoCorporativo(limite);

        for (int i = 0; i < quantidade; i++)
        {
            decimal valor = decimal.Parse(Console.ReadLine());
            
            // Adicionando a transação à instância do cartão
            cartao.AdicionarTransacao(valor);
        }

        cartao.ExibirResumo();
    }
}