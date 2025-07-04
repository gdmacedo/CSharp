/*
Projeto...: Controle e Análise de Transações com POO em C#
Módulo....: Identificador de Transações Suspeitas
Data......: 04 de julho de 2025
Autor.....: Macedo, Glener Diniz
Descrição.: Uma empresa de análise financeira está desenvolvendo um sistema para identificar transações suspeitas 
            com base em um valor limite. O objetivo do sistema é verificar se alguma transação ultrapassa o valor
            limite e marcá-la como suspeita. Se houver transações suspeitas, elas devem ser listadas. 
            Caso contrário, o sistema deve informar que não há transações suspeitas. 
            Além disso, o programa deve exibir o valor total das transações suspeitas e a quantidade de transações suspeitas.
            Este código apresentado aqui têm como objetivo principal exercitar os conceitos aprendidos e proporcionar
            a pratica do desenvolvimento, contato com lógica de programação. 


Entrada...: A entrada deve conter:
            - O valor limite para transações suspeitas.
            - O número de transações a serem analisadas.
            - Os valores das transações (valores inteiros ou decimais).

Saída.....: O programa deve exibir:
            - O valor total das transações que ultrapassam o limite.
            - O número de transações suspeitas.
            - Se nenhuma transação for suspeita, o programa deve exibir "Nenhuma transação suspeita".

Atenção...: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
            
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

// Criando a Classe AnalisadorDeTransacoes:
    public class AnalisadorDeTransacoes{
        public decimal Limite { get; set; }  
    
        // Criando a lista para armazenar as transações realizadas:
        public List<decimal> Transacoes = new List<decimal>();
    

        public AnalisadorDeTransacoes(decimal limite){
            Limite = limite;
            Transacoes = new List<decimal>();
        }
 
        public void AdicionarTransacao(decimal valor){
          // adicionando a transação à lista Transacoes
          Transacoes.Add(valor);
        }

        public List<decimal> ObterTransacoesSuspeitas(){
          //  retornando as transações que são superiores ao limite
          return Transacoes.Where(t => t > Limite).ToList();
        }

        public void ExibirRelatorio(){
            var suspeitas = ObterTransacoesSuspeitas();
        
            // Implementando a condição if para retornar uma mensagem informando que não há transações suspeitas:
            if (suspeitas.Count == 0){
                Console.WriteLine("Nenhuma transação suspeita");
            }

        
            else{
                decimal totalSuspeitas = suspeitas.Sum();
                int numeroSuspeitas = suspeitas.Count();
    
                string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";
  
                // Imprimindo o total das transações suspeitas com duas casas decimais
                // e a quantidade de transações suspeitas
                Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
            }
        }
    }

class Program{
    static void Main(){

        decimal limite = decimal.Parse(Console.ReadLine());  
        int quantidade = int.Parse(Console.ReadLine());
        var analisador = new AnalisadorDeTransacoes(limite);

        for (int i = 0; i < quantidade; i++){

             // adicionando a transação à instância do analisador
             decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             analisador.AdicionarTransacao(valor);
        }

        analisador.ExibirRelatorio();
    }
}