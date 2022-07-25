using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double media;
            double nota4;


            Console.WriteLine("Digite a primeira nota: ");
            
            nota1 = double.Parse (Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            
            Console.WriteLine("A media do aluno foi: " + media);
            Math.Round(media);
            Console.ReadKey();

            if (media >= 6) 


            {
                Console.WriteLine("Aulno foi APROVADO!!!!");
            
            }
            else
            {
                Console.WriteLine("Aluno está de recuperação :(");
                Console.WriteLine("Digite a nova nota :");
                nota4 = double.Parse(Console.ReadLine());
                media = (media + nota4) / 2;
                Math.Round(media);

                if (media >= 6)


                {
                    Console.WriteLine("Aulno foi APROVADO!!!!");

                }
                else
                {
                    Console.WriteLine("O ALUNO FOI REPROVADO :(");
                    
                }






            }
            Console.ReadKey();
            


 }

    }
}
