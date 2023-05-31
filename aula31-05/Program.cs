using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula31_05
{
    internal class Program
    {
        public static void Vetor()
        {
            int[] vet = new int[6];
            vet[0] = 7;
            vet[5] = 26;
        }
        public static void Exercicio1()
        {
            int[] vet2;
            Random rand = new Random();
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());
            vet2 = new int[t];

            float soma = 0;
            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                Console.WriteLine(vet2[i]);
                soma = soma + vet2[i];

            }
            Console.WriteLine("a media é= " + soma / (float)t);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("digite o valor da posição [{0}]", i);
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}]={1}", i, vet2[i]);
            }
            Console.ReadKey();
        }
        public static void Exercicio2()
        {
            int[] vet3;
            int t;



            int smP = 0, smI = 0;
            Random rand = new Random();
            Console.WriteLine("entre com  o tamanho");
            t = int.Parse(Console.ReadLine());
            vet3 = new int[t];



            for (int i = 0; i < t; i++)
            {
                vet3[i] = rand.Next(10, 50);



                if (vet3[i] % 2 == 0)
                {
                    smP = vet3[i] + smP;
                }
                else
                {
                    smI = vet3[i] + smI;
                }



            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(vet3[i]);



            }
            Console.WriteLine(" os numeros pares somados sera de:  " + smP);
            Console.WriteLine(" os numeros inpares somados sera de:  " + smI);



            Console.ReadKey();
        }
        public static void Exercicio3()
        {
            int[] vet5;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet5 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet5[i] = rand.Next(1, 100);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);


            }
            Console.WriteLine();
            for (int i = t - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);


            }


            Console.ReadKey();

        }
        public static void Exercicio4()
        {
            float media = 0;
            int[] vet6;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet6 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet6[i] = rand.Next(10, 50);


            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet6[i]);
                if (vet6[i] % 3 == 0 && vet6[i] % 5 == 0)
                {
                    media = vet6[i] + media;
                }


            }

            media = media / (float)t;
            Console.WriteLine("a media aridimentica é " + media);

            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>MENU<<<<<<<<");
            Console.WriteLine("EXERCICIO 1");
            Console.WriteLine("EXERCICIO 2");
            Console.WriteLine("EXERCICIO 3");
            Console.WriteLine("EXERCICIO 4");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Exercicio1();
                        break;
                    }
                case 2:
                    {
                        Exercicio2();
                        break;
                    }
                case 3:
                    {
                        Exercicio3();
                        break;
                    }
                case 4:
                    {
                        Exercicio4();
                        break;
                    }
                    default:
                    Console.WriteLine("não existe esse exercicio");
                    break;

            }


        }
    }
}
