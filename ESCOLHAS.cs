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
// -=-=-=-=-=-=-=-=- ESCOLHAS -=-=-=-=-=-=-=-=-
        // Exercicio 18
            //18) Faça um programa que leia dois números e mostre qual o maior dos dois.
            Console.WriteLine("A: ");
            int Aex18 = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int Bex18 = int.Parse(Console.ReadLine());

            if(Aex18 > Bex18){
                Console.WriteLine("A é o maior");
            }
            else if(Aex18 == Bex18){
                Console.WriteLine("A e B são iguais");
            }
            else{
                Console.WriteLine("B é o maior");
            }

        // Exercicio 19
            //19) Um hotel cobra R$ 60.00 a diária e mais uma taxa de serviços. A taxa de serviços é de:
            // R$ 5.50 por diária, se o número de diárias for maior que 15;
            // R$ 6.00 por diária, se o número de diárias for igual a 15;
            // R$ 8.00 por diária, se o número de diárias for menor que 15.
            // Construa um programa que mostre o nome e o total da conta de um cliente.

            Console.WriteLine("Nome: ");
            string nomeex19 = Console.ReadLine();
            Console.WriteLine("Numero de diarias: ");
            int qntdiariasex19 = int.Parse(Console.ReadLine());

            double vldiariaex19 = 60.0;
            double taxa = 0;

            if(qntdiariasex19 > 15){
                taxa = 5.5;
            }
            else if(qntdiariasex19 <15){
                taxa = 8.0;
            }
            else{
                taxa = 6.0;
            }
            double valorfinalex19 = (vldiariaex19 * qntdiariasex19) + (qntdiariasex19 * taxa);
            Console.WriteLine("Nome: " + nomeex19 + "\nValor final: " + valorfinalex19);

        // Exercicio 20
            //20) Calcule a média aritmética das três notas de um aluno e mostre, além do valor da média, 
            // uma mensagem de "Aprovado", caso a média seja igual ou superior a 7; a mensagem “em prova final” 
            // caso a média seja menor que 7 e maior ou igual a 4; e "reprovado", caso contrário.

            Console.WriteLine("A: ");
            double Aex20 = double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            double Bex20 = double.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            double Cex20 = double.Parse(Console.ReadLine());
            
            double mediaex20 = (Aex20 + Bex20 + Cex20) / 3;

            if(mediaex20 >= 7.0){
                Console.WriteLine("Aprovado com nota: " + mediaex20);
            }
            else{
                Console.WriteLine("Reprovado com nota: " + mediaex20);
            }

        // Exercicio 21
            //21) Um determinado clube de futebol pretende classificar seus atletas em categorias e para isto ele 
            // contratou  um  programador  para  criar  um  programa  que executasse esta tarefa. 
            // Para isso o clube criou uma tabela que continha a faixa etária do atleta e sua categoria. 
            // A tabela está demonstrada abaixo:

            // IDADE           CATEGORIA 
            // De 05 a 10      Infantil
            // De 11 a 15      Juvenil
            // De 16 a 20      Junior
            // De 21 a 25      Profissional
            // Construa um programa que solicite o nome e a idade de um atleta e imprima a sua categoria.

            Console.WriteLine("Idade: ");
            int idadeex21 = int.Parse(Console.ReadLine());

            if(idadeex21 >=5 && idadeex21 <=10){
                Console.WriteLine("Infantil.");
            }
            else if(idadeex21 >=11 && idadeex21 <= 15){
                Console.WriteLine("Juvenil.");
            }
            else if(idadeex21 >=16 && idadeex21 <=20){
                Console.WriteLine("Junior.");
            }
            else if(idadeex21 >=21 && idadeex21 <=25){
                Console.WriteLine("Profissional.");
            }
            else{
                Console.WriteLine("Aposentado.");
            }

        // Exercicio 22
            //22) Faça um programa, utilizando estrutura de condição, que receba um número real, 
            // digitado pelo usuário e mostre o menu para selecionar o tipo de cálculo que deve ser realizado:
            // 101-Ao quadrado
            // 102-A metade
            // 103-10% do número
            // 104-O dobro

            Console.WriteLine("Digite um número real: ");
            int numeroex22 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha uma opção: \n101 - Ao quadrado \n102 - A metade \n103 - 10% do número \n104 - O dobro");
            int opçãoex22 = int.Parse(Console.ReadLine());
            
            if(opçãoex22 == 101)
            {
                int respostaex22 = numeroex22 * numeroex22; 
                Console.WriteLine(respostaex22);
            }
            else if(opçãoex22 == 102)
            {
                int respostaex22 = numeroex22 / 2;
                Console.WriteLine(respostaex22);
            }
            else if(opçãoex22 == 103)
            {
                int respostaex22 = (int)(numeroex22 * 0.10f);
                Console.WriteLine(respostaex22);
            }
            else if(opçãoex22 == 104)
            {
                int respostaex22 = numeroex22 * 2;
                Console.WriteLine(respostaex22);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        // Exercicio 23
            //23) Crie um programa que peça o nome, a altura e o peso de duas pessoas e apresente o nome da mais 
            // pesada e o nome da mais alta

            Console.WriteLine("Nome pessoa 1: ");
            string nome1ex23 = Console.ReadLine();
            Console.WriteLine("Altura pessoa 1: ");
            double altura1ex23 = double.Parse(Console.ReadLine());
            Console.WriteLine("Peso pessoa 1: ");
            double peso1ex23 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome pessoa 2: ");
            string nome2ex23 = Console.ReadLine();
            Console.WriteLine("Altura pessoa 2: ");
            double altura2ex23 = double.Parse(Console.ReadLine());
            Console.WriteLine("Peso pessoa 2: ");
            double peso2ex23 = double.Parse(Console.ReadLine());

            if(altura1ex23 > altura2ex23)
            {
                Console.WriteLine(nome1ex23 + " é mais alto que " + nome2ex23);
            }
            else if(altura1ex23 < altura1ex23)
            {
                Console.WriteLine(nome1ex23 + " é mais baixo que " + nome2ex23);
            }
            else
            {
                Console.WriteLine("A altura de " + nome1ex23 + " e de " + nome2ex23 + " é igual");
            }

            if(peso1ex23 > peso2ex23)
            {
                Console.WriteLine(nome1ex23 + " é mais pesado que " + nome2ex23);
            }
            else if(peso1ex23 < peso2ex23)
            {
                Console.WriteLine(nome1ex23 + " é mais leve que " + nome2ex23);
            }
            else{
                Console.WriteLine("O peso de " + nome1ex23 + " e de " + nome2ex23 + " é igual");
            }
            
        // Exercicio 24
            // 24) Faça  um  programa  que  receba  o  valor  da  venda,  escolha  a  condição  de pagamento no 
            // menu e mostre o total da venda final conforme condições a seguir:
            // Venda a Vista - desconto de 10%
            // Venda a Prazo 30 dias - desconto de 5% 
            // Venda a Prazo 60 dias - mesmo preço 
            // Venda a Prazo 90 dias - acréscimo de 5%
            // Venda com cartão de débito - desconto de 8% Venda com cartão de crédito - desconto de 7%

            Console.WriteLine("Valor da venda: ");
            double valorex24 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a opção de pagamento: ");
            Console.WriteLine("\n(A) - Venda a Vista - desconto de 10%\n(B) - Venda a Prazo 30 dias - desconto de 5%\n(C) - Venda a Prazo 60 dias - mesmo preço\n(D) - Venda a Prazo 90 dias - acréscimo de 5%\n(E) - Venda com cartão de débito - desconto de 8% Venda com cartão de crédito - desconto de 7%");
            string opçãoex24 = Console.ReadLine();
            if(opçãoex24 == "A" || opçãoex24 == "a" || opçãoex24 == "(A)" || opçãoex24 == "(a)")
            {
                valorex24 = valorex24 - valorex24 * 0.10;
                Console.WriteLine("O valor total da compra é: " + valorex24);
            }
            else if(opçãoex24 == "B" || opçãoex24 == "b" || opçãoex24 == "(B)" || opçãoex24 == "(b)")
            {
                valorex24 = valorex24 - valorex24 * 0.05;
                Console.WriteLine("O valor total da compra é: " + valorex24);
            }
            else if(opçãoex24 == "C" || opçãoex24 == "c" || opçãoex24 == "(C)" || opçãoex24 == "(c)")
            {
                Console.WriteLine("O valor total da compra é: " + valorex24);
            }
            else if(opçãoex24 == "D" || opçãoex24 == "d" || opçãoex24 == "(D)" || opçãoex24 == "(d)")
            {
                valorex24 = valorex24 + valorex24 * 0.05;
                Console.WriteLine("O valor total da compra é: " + valorex24);
            }
            else if(opçãoex24 == "E" || opçãoex24 == "e" || opçãoex24 == "(E)" || opçãoex24 == "(e)")
            {
                Console.WriteLine("Crédito ou debito?");
                string cartao = Console.ReadLine();
                if(cartao == "crédito" || cartao == "credito")
                {
                    valorex24 = valorex24 - valorex24 * 0.07;
                    Console.WriteLine("O valor total da compra é: " + valorex24);
                }
                else if(cartao == "débito" || cartao == "debito")
                {
                    valorex24 = valorex24 - valorex24 * 0.08;
                    Console.WriteLine("O valor total da compra é: " + valorex24);
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
            
        }
    }
}
