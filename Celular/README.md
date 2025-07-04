# Celular
## Criando um Sistema e Abstraindo um Celular com POO em C#
## Sistema e Abstraindo um Celular

### Author: Macedo, Glener Diniz - Desenvolvedor Full Stack
### Data.: 3 de julho de 2025.

### Orientador:
Leonardo Buta - Full-Stack

<p align="center">
  <img src="https://raw.githubusercontent.com/gdmacedo/CSharp/refs/heads/main/Celular/Imagens/0001.jpg" title="Sistema e Abstraindo um Celular">
</p>


## Desafio de projeto
Para este desafio, foi precio usar seus conhecimentos adquiridos no módulo de orientação a objetos, em C# com .NET.

## Contexto
Com a objetivo de modelar um sistema que trabalha com celulares. Para isso, foi solicitado pelo cliente, desenvolva uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

<p align="center">
  <img  src="https://raw.githubusercontent.com/gdmacedo/Glener-Talk/main/developer-MacedoGDiniz.jpg" alt="Macedo, Glener Diniz">
</p>


## Proposta
A Missão foi criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Fez parte do projeto criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** é abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** é uma classes filhas de Smartphone.
3. O método **InstalarAplicativo** é uma classe sobrescrita na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

