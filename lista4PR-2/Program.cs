using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4PR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) É possivel atribuir "int" em "float", porem não é possivel o reverso porque float abrange mais numeros.

            // 2) console.readline digita uma entrada de texto no console e pressione enter para finalizar a entrada. Ele retorna o valor de entrada como string.
            // Portando, essa é a diferença deles, devemos deixar claro que console.readline é sempre uma string, enquanto o tipo de dado retornado pelo console.read é sempre um inteiro. E ele le um unico caracter.

            //3) Certificar-se de que a entrada do usuário é do tipo esperado: antes de fazer a leitura de um valor, é importante informar ao usuário o tipo de dado que se espera receber. Isso evita que o usuário digite um valor inválido ou de tipo diferente do esperado.
            //Validar a entrada do usuário: é importante verificar se o valor digitado pelo usuário é válido para o tipo de dado que se espera receber.Por exemplo, se esperamos receber um valor inteiro, devemos verificar se a entrada do usuário contém apenas dígitos numéricos e se está dentro do intervalo esperado.
            //Tratar possíveis erros: é possível que ocorram erros durante a entrada de dados pelo usuário, como a entrada de um valor inválido ou a interrupção do programa pelo usuário.É importante tratar esses erros de forma adequada para evitar que o programa quebre ou apresente resultados incorretos.
            // Utilizar métodos de conversão de tipos: após a leitura do valor pelo Console, é necessário converter o valor de string para o tipo de dado esperado.Para isso, podemos utilizar os métodos de conversão de tipos fornecidos pela linguagem, como int.Parse(), float.Parse() ou double.Parse().É importante tratar os possíveis erros que podem ocorrer durante a conversão, como a entrada de um valor inválido.

            // 4)

            // int num, num2, num3;

            //Console.WriteLine("Entre com um numero: ");
            //num = int.Parse(Console.ReadLine());

            //num2 = num / 2;
            //num3 = num % 2;
            //if (num3 == 0 && num2 * 2 > 10)
            // Console.WriteLine("mensagem 1");
            //else
            //  Console.WriteLine("mensagem 2");
            // console.readkey();

            // o objetivo é ver se o "resto" do numero q foi divido por 2 é igual a 0. Se você entrar com 8 vai ser mensagem2, se entrar entrar com 27 vai ser mensagem2 e se entrar com 28 é mensagem1.

            //5)

            // float posicaoinicial, posicaofinal, velocidadeconstante, instante;

            //Console.WriteLine("Digite a posição inicial: ");
            //posicaoinicial = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a velocidade media: ");
            //velocidadeconstante = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o tempo: ");
            //instante = float.Parse(Console.ReadLine());

            //posicaofinal = posicaoinicial + (velocidadeconstante * instante);

            //Console.WriteLine("A posição final é: " + posicaofinal);

            //Console.ReadKey();

            //6 

            //int numero;

            //Console.WriteLine("digite um numero: ");
            //numero = int.Parse(Console.ReadLine()); 

            //if (numero % 3 == 0 && numero % 5 == 0 && numero % 10 == 0)
            //{
            //    Console.WriteLine("É divisivel por 3, 5 e 10! ");
            //}

            //else if (numero % 3 == 0 && numero % 5 == 0)
            //{
            //    Console.WriteLine("É divisivel por 3 e 5! ");
            //}            

            //else if (numero % 3 == 0)
            //{
            //    Console.WriteLine("É divisivel somente por 3! ");
            //}

            //else if (numero % 5 == 0)
            //{
            //    Console.WriteLine("É divisivel somente por 5!");
            //}

            //Console.ReadKey();

            // 7

            //int km, escolakm, tempo;

            //Console.WriteLine("a quantos km fica sua casa? ");
            //km = int.Parse(Console.ReadLine());

            //tempo = km * 100;

            //if ( km * 100 ==)

            //Console.WriteLine("o tempo necessario é: " + tempo);

            //Console.ReadKey();

            // 8

            // double preco, custo, imposto, total, lucro, quantidade;
            
            //Console.WriteLine("=====MENU=====");
            //Console.WriteLine(" 1");
            //Console.WriteLine(" 2");
            //Console.WriteLine(" 3");
            //Console.WriteLine(" 4");
            //Console.WriteLine("=============");

            //Console.WriteLine("Digite a quantidade: ");
            //quantidade = int.Parse(Console.ReadLine());

            //switch (quantidade)
            //{
            //    case 1 :
            //        preco = 10.0;
            //        custo = 7.0;
            //        imposto = 1.0;
            //        break;

            //    case 2:
            //        preco = 12.0;
            //        custo = 8.0;
            //        imposto = 1.2;
            //        break;

            //    case 3:
            //        preco = 15.0;
            //        custo = 10.0;
            //        imposto = 1.5;
            //        break ;

            //    case 4:
            //        preco = 18.0;
            //        custo = 12.0;
            //        imposto = 1.8;
            //        break;

            //    default :
            //        Console.WriteLine("Opcao invalida!");
            //        break;

            //}
            //total = preco * quantidade;
            //lucro = (preco - custo) * quantidade - imposto;

            //Console.WriteLine("O valor da compra é: ", total);
            //Console.WriteLine("lucro liquido é: ", lucro);

            //Console.ReadKey();



        }

    }    }
