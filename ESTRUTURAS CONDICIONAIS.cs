using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios
{
    class Program
    {

        static void Main(string[] args){
// -=-=-=-=-=-=-=-=- ESTRUTURAS CONDICIONAIS -=-=-=-=-=-=-=-=-

        //Exercicio 9
            //9) Faça um programa que receba um número e mostre uma mensagem caso este número seja maior que 10

            Console.WriteLine("Digite um número: ");
            int numeroex9 = int.Parse(Console.ReadLine());

            if(numeroex9 > 10){
                Console.WriteLine("O numero escolhido é maior que 10");
            }
            else if(numeroex9 < 10){
                Console.WriteLine("O numero escolhido é menor que 10");
            }
            else{
                Console.WriteLine("O numero escolhido é 10");
            }
        
        //Exercicio 10 
            // Escrever um programa que leia dois valores inteiros distintos e informe qual é o maior. 
            // Elaborar um programa que lê três valores a, b, c e os escreve. 
            // A seguir, encontre o maior dos três valores e o escreva com a mensagem : "É o maior”.

            Console.WriteLine("Digite um valor para A: ");
            int Aex10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            int Bex10 = int.Parse(Console.ReadLine());

            if(Aex10 > Bex10){
                Console.WriteLine("A é maior que B");
            }
            else if(Aex10 < Bex10){
                Console.WriteLine("A é menor que B");
            }
            else{
                Console.WriteLine("A é igual B");
            }

            Console.WriteLine("Digite um valor para X: ");
            int Xex10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y: ");
            int Yex10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Z: ");
            int Zex10 = int.Parse(Console.ReadLine());

            if(Xex10 > Yex10 && Xex10 > Zex10){
                Console.WriteLine("X é o maior dos numeros");
            }
            else if(Yex10 > Xex10 && Yex10 > Zex10){
                Console.WriteLine("Y é o maior dos numeros");
            }
            else if(Zex10 > Xex10 && Zex10 > Yex10){
                Console.WriteLine("Y é o maior dos numeros");
            }
            else if(Xex10 > Yex10 && Yex10 == Zex10){
                Console.WriteLine("X é o maior dos numeros");
            }
            else if(Yex10 > Xex10 && Xex10 == Zex10){
                Console.WriteLine("Y é o maior dos numeros");
            }
            else if(Zex10 > Xex10 && Xex10 == Yex10){
                Console.WriteLine("Z é o maior dos numeros");
            }
            else{
                Console.WriteLine("Todos os números são iguais");
            }

        //Exercicio 11
            //11) Faça um programa que leia os valores A, B e C. 
            // Mostre uma mensagem que informe se a soma de A com B é menor, maior ou igual a C.

            Console.WriteLine("Digite um valor para A: ");
            int Aex11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            int Bex11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para C: ");
            int Cex11 = int.Parse(Console.ReadLine());

            int somaex11 = Aex11 + Bex11;

            if(somaex11 > Cex11){
                Console.WriteLine("A soma de A e B é maior que o valor de C");
            }
            else if(somaex11 < Cex11){
                Console.WriteLine("A soma de A e B é menor que o valor de C");
                    
            }
            else{
                Console.WriteLine("A soma de A e B é igual ao valor de C");
            }

        // Exercicio 12
            //12) Faça um programa que leia um número N e imprima “F1”, “F2” ou “F3”, conforme a condição:
            //“F1”, se N <= 10
            //“F2”, se N > 10 e N <= 100
            //“F3”, se n > 100

            Console.WriteLine("Digite um valor para a letra N: ");
            int Nex12 = int.Parse(Console.ReadLine());

            if(Nex12 <= 10){
                Console.WriteLine("F1");
            }
            else if(Nex12 > 10 && Nex12 <= 100){
                Console.WriteLine("F2");
            }
            else{
                Console.WriteLine("F3");
           }

        // Exercicio 13
            //13)	Faça um programa que receba um número e diga se este número está no intervalo entre 100 e 200.
            Console.WriteLine("Digite um numero: ");
            int numex13 = int.Parse(Console.ReadLine());

            if(numex13 >= 100 && numex13 <= 200){
                Console.WriteLine("O numero está entre 100 e 200.");
            }
            else{
                Console.WriteLine("O numero não está entre 100 e 200.");   
            }

        // Exercicio 14
            //14) Ler dois valores para as variáveis A e B, e efetuar as trocas dos valores de forma que a variável A 
            //passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. 
            //Apresentar os valores trocados.

            Console.WriteLine("Valor de A: ");
            int Aex14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            int Bex14 = int.Parse(Console.ReadLine());

            int replaceA = Aex14;
            int replaceB = Bex14;

            Aex14 = replaceB;
            Bex14 = replaceA;

            Console.WriteLine("Valor de A e B foram trocados\nA: " + Aex14 + "\nB: " + Bex14);

        // Exercicio 15
            //15)	Considere que o último concurso vestibular apresentou três provas: Português, Matemática e 
            // Conhecimentos Gerais. Considerando que para cada candidato tem-se um registro contendo o seu nome e as 
            // notas obtidas em cada uma das provas, construa um programa que forneça:
            // a)  o nome e as notas em cada prova do candidato
            // b)  a média do candidato
            // c)  uma informação dizendo se o candidato foi aprovado ou não. Considere que um candidato é aprovado se 
            // sua média for maior que 7.0 e se não apresentou nenhuma nota abaixo de 5.0
           
            Console.WriteLine("Nome: ");
            string nomeex15 = Console.ReadLine();
            Console.WriteLine("Nota prova Português: ");
            double NPex15 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Nota prova Matemática: ");
            double NMex15 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Nota prova Conhecimentos gerais: ");
            double NCGex15 = double.Parse(Console.ReadLine()); 

            double mediaex15 = (NPex15 + NMex15 + NCGex15)/3;

            Console.WriteLine("Nome: " + nomeex15 + "\nNota - Português: " + NPex15 + 
            "\nNota - Matemática: " + NMex15 + "\nNota - Conhecimentos Gerais: " + NCGex15 + "\n\nMédia: " + mediaex15);
            
            if(mediaex15 > 7.0 && NPex15 > 5 && NMex15 > 5 && NCGex15 > 5){
               Console.WriteLine("\nAprovado!"); 
            }
            else{
                Console.WriteLine("\nReprovado");
            }
            
        // Exercicio 16
            //16) Faça um programa que leia dois números e indique se são iguais ou se são diferentes. 
            //Mostre o maior e o menor (nesta sequência).

            Console.WriteLine("A: ");
            int Aex16 = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int Bex16 = int.Parse(Console.ReadLine());

            if(Aex16 == Bex16){
                Console.WriteLine("A e B são iguais");
            }
            else{
                Console.WriteLine("A e B são diferentes.");
                if(Aex16 > Bex16){
                    Console.WriteLine("O maior: " + Aex16 + "\nO menor: " + Bex16);
                }
                else{
                    Console.WriteLine("O maior: " + Bex16 + "\nO menor: " + Aex16);
                }
            }
       
        // Exercicio 17
            //Crie o programa para calcular o aumento salarial de um empregado.
            // Por padrão, o aumento será de 15%.
            // Entretanto, deve ser aplicada uma regra diferente para cada faixa salarial. Regras:
            // a)  se 1.500,00 <= salarioAtual < 1.750,00: aumento igual a 12% 
            // b)  se 1.750,00 <= salarioAtual < 2.000,00: aumento igual a 10% 
            //c)  se 2.000,00 <= salarioAtual < 3.000,00: aumento igual a 7% 
            //d)  se salarioAtual acima de 3.000,00: aumento igual a 5%. 

            Console.WriteLine("Salario atual: ");
            double salarioex17 = double.Parse(Console.ReadLine());

            if(salarioex17 >= 1500 && salarioex17 < 1750){
                double aumentoex17 = salarioex17 + (salarioex17 * 0.12);
                Console.WriteLine("Salario com aumento: " + aumentoex17);
            }
            else if(salarioex17 >= 1750 && salarioex17 < 2000){
                double aumentoex17 = salarioex17 + (salarioex17 * 0.10);
                Console.WriteLine("Salario com aumento: " + aumentoex17);
            }
            else if(salarioex17 >= 2000 && salarioex17 < 3000){
                double aumentoex17 = salarioex17 + (salarioex17 * 0.07);
                Console.WriteLine("Salario com aumento: " + aumentoex17);
            }
            else{
                double aumentoex17 = salarioex17 + (salarioex17 * 0.05);
                Console.WriteLine("Salario com aumento: " + aumentoex17);
            }
