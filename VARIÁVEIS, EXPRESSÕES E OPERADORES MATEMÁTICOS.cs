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
/*
    // -=-=-=-=-=-=-=-=- VARIÁVEIS, EXPRESSÕES E OPERADORES MATEMÁTICOS -=-=-=-=-=-=-=-=-

         // Exercicio 1 
            //1) Faça um programa que receba dois números e exiba o resultado da sua soma.

            Console.WriteLine("Digite um valor para X");
            int Xex1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y");
            int Yex1 = int.Parse(Console.ReadLine());
        
            int somaex1 = Xex1 + Yex1;

            Console.WriteLine("O resultado da soma é: " + somaex1);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
        

        // Exercicio 2
            //2) Faça um programa que receba dois números e ao final mostre a soma, subtração,
            // multiplicação e a divisão dos números lidos.

            Console.WriteLine("Digite um valor para X");
            float Xex = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y");
            float Yex2 = float.Parse(Console.ReadLine()); 
        
            float somaex2 = Xex2 + Yex2;
            float subex2 = Xex2 - Yex2;
            float multiex2 = Xex2 * Yex2;
            float divex2 = Xex2 / Yex2;
            
            Console.WriteLine("O resultado da soma é: " + somaex2);
            Console.WriteLine("O resultado da subtração é: " + subex2);
            Console.WriteLine("O resultado da multiplicação é: " + multiex2);
            Console.WriteLine("O resultado da divisão é: " + divex2);

        // Exercicio 3
            // 3) Faça um programa que:
            // a)	Leia o nome;
            // b)	Leia o sobrenome;
            // c)	Concatene o nome com o sobrenome;
            // d)	Apresente o nome completo.
        
            Console.WriteLine("Nome:");
            string nomeex3 = Console.ReadLine();
            Console.WriteLine("Sobrenome:");
            string sobrenomeex3 = Console.ReadLine();

            Console.WriteLine("Seu nome completo é " + nomeex3 + " " + sobrenomeex3);
        

        // Exercicio 4
            // 4) Escrever um programa que leia o nome de um vendedor, o seu salário fixo e o total de 
            // vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão
            // sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário no final do mês
            Console.WriteLine("Nome:");
            string nomeex4 = Console.ReadLine();
            Console.WriteLine("Vendas realizadas (Valor em dinheiro):  ");
            float vendasex4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Salário fixo: ");
            float salarioex4 = float.Parse(Console.ReadLine());

            float comissaoex4 = vendasex4 * 0.15f;
            float salariototalex4 = comissaoex4 + salarioex4;

            Console.WriteLine("Nome: " + nomeex4 + "\nSalario fixo: "+ salarioex4 + "\nComissão: " + comissaoex4 + "Salario total: " + salariototalex4);
        

        // Exercicio 5
            // 5) Escrever um programa que leia o nome de um aluno e as notas das três provas que ele obteve
            // no semestre. No final informar o nome do aluno e a sua média (aritmética).
            
            Console.WriteLine("Nome: ");
            string nomeex5 = Console.ReadLine();
            Console.WriteLine("Nota prova 1: ");
            double prova1ex5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota prova 2: ");
            double prova2ex5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota prova 3: ");
            double prova3ex5 = double.Parse(Console.ReadLine());

            double mediaex5 = (prova1ex5 + prova2ex5 + prova3ex5) / 3;
            Console.WriteLine("A média das notas é: " + mediaex5);


        // Exercicio 6
            //6) Faça um programa que:
            //a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
            //b) Obtenha o valor para a variável VH (valor hora trabalhada):
            //c) Obtenha o valor para a variável PD (percentual de desconto);
            //d) Calcule o salário bruto => SB = HT * VH;
            //e) Calcule o total de desconto => TD = (PD/100)*SB;
            //f) Calcule o salário líquido => SL = SB – TD;
            //g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário Liquido;

            Console.WriteLine("Horas trabalhadas no mês: ");
            float HTex6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor da hora trabalhada: ");
            float VHex6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Percentual de desconto: ");
            float PDex6 = float.Parse(Console.ReadLine());

            float SBex6 = HTex6 *VHex6;
            float TDex6 = (PDex6 / 100) * SBex6;
            float SLex6 = SBex6 - TDex6;

            Console.WriteLine("Horas trabalhadas: " + HTex6 + "\nSalario Bruto: " + SBex6 +
             "\nDesconto: " + TDex6 + "\nSalario Liquido: " + SLex6); 

        //Exercicio 7
            //7) Faça um programa que leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit.
            // A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em Fahrenheit e C é a 
            // temperatura em Celsius;

            Console.WriteLine("Temperatura em Cº: ");
            float GCex7 = float.Parse(Console.ReadLine());

            float GFex7 = (9 * GCex7 + 160) / 5;

            Console.WriteLine("Temperatura em Fº: " + GFex7);
 
        //Exercicio 8
            //8) Faça um programa que calcule a quantidade de litros de combustível gasta em uma  viagem,  utilizando
            // um  automóvel  que  faz  12Km  por  litro.  Para  obter  o cálculo, o usuário deve fornecer o tempo gasto 
            // na viagem e a velocidade média durante  ela.  Desta  forma,  será  possível  obter  a  distância  percorrida 
            // com  a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da distância, basta calcular a quantidade de litros 
            // de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os 
            // valores da velocidade média, tempo gasto na viagem, a distância percorrida e a quantidade de litros utilizada na viagem.
        
            Console.WriteLine("Tempo gasto na viagem: ");
            int tempoex8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Velocidade média: ");
            double velocex8 = double.Parse(Console.ReadLine());

            double distex8 = tempoex8 * velocex8;
            double LUex8 = distex8 / 12;

            Console.WriteLine("Velocidade média: " + velocex8 + "\nTempo de viagem: " 
            + tempoex8 + "\nDistancia percorrida: " + distex8 + "\nLitros usados na viagem: " + LUex8);

