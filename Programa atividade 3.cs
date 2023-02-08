using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            double subtotal = 0, dinheiro = 100;
            int opcao, opcaolanches, opcaolanches1, opcaolanches2, opcaolanches3, opcaolanches4, opcaolanches5, opcaolanches6, opcaolanches7, opcaobebidas;
            {
                Console.WriteLine("Etec lanches");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1-Lanches");
                Console.WriteLine("2-Bebidas");
                Console.WriteLine("3-Finalizar");
                opcao = Convert.ToInt32(Console.ReadKey());
                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha o seu lanche");
                    Console.WriteLine("1- x burguer ----------------------------- 10,00 ");
                    opcaolanches = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2- x bacon ------------------------------ 13,00");
                    opcaolanches1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3- x salada ----------------------------- 20,00");
                    opcaolanches2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("4- x salada bacon ---------------------------- 14,00");
                    opcaolanches3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("5- x egg------------------------------- 18,00");
                    opcaolanches4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("6- x frango ------------------------------- 25,00");
                    opcaolanches5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("7- x salsicha------------------------------- 70,00");
                    opcaolanches6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("8- x tudo ------------------------------- 30,00");
                    opcaolanches7 = Convert.ToInt32(Console.ReadLine());
                    if (opcaolanches == 1 && dinheiro > opcaolanches)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x burguer");
                        subtotal = subtotal + 10;
                    }
                    if (opcaolanches == 2 && dinheiro > opcaolanches1)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x bacon");
                        subtotal = subtotal + 13;
                    }
                    if (opcaolanches == 3 && dinheiro > opcaolanches2)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x salada");
                        subtotal = subtotal + 20;
                    }
                    if (opcaolanches == 4 && dinheiro > opcaolanches3)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x egg");
                        subtotal = subtotal + 14;
                    }
                    if (opcaolanches == 5 && dinheiro > opcaolanches4)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x frango");
                        subtotal = subtotal + 18;
                    }
                    if (opcaolanches == 6 && dinheiro > opcaolanches5)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x salsicha");
                        subtotal = subtotal + 10;
                    }
                    if (opcaolanches == 7 && dinheiro > opcaolanches6)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x tudo");
                        subtotal = subtotal + 10;
                    }
                    if (opcaolanches == 8 && dinheiro > opcaolanches7)
                    {
                        Console.Clear();
                        Console.WriteLine("Você selecionou o lanche x salada bacon");
                        subtotal = subtotal + 10;
                    }
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha a sua Bebida");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("1- Shake da Etec --------------------- 10,00");
                    opcaobebidas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2- Agua abençoada -------------------- 20,00");
                    opcaobebidas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3- White Horse ----------------------- 50,00");
                    opcaobebidas = Convert.ToInt32(Console.ReadLine());
                }
                if (opcaobebidas == 1 && dinheiro > opcaobebidas)
                {
                    Console.Clear();
                    Console.WriteLine("Você selecionou a bebida shake da etec");
                    subtotal = subtotal + 10;
                }
                if (opcaobebidas == 2 && dinheiro > opcaobebidas)
                {
                    Console.Clear();
                    Console.WriteLine("Você selecionou o agua abençoada");
                    subtotal = subtotal + 13;
                }
                if (opcaobebidas == 3 && dinheiro > opcaobebidas)
                {
                    Console.Clear();
                    Console.WriteLine("Você selecionou o white horse");
                    subtotal = subtotal + 20;
                }

                Console.WriteLine("Deseja Continuar");
                escolha = Console.ReadLine();

            } while (escolha == N) ;

            Console.ReadKey();
        }
    }
}
