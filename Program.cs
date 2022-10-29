// See https://aka.ms/new-console-template for more information

using System;


namespace MediaEscolar 

{

    class Program
 
    {

        static void Main(string[] args)
        
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo, aqui você vai usar calculador de aprovação");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Media");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("");

            short resultado = short.Parse(Console.ReadLine());

            switch(resultado)
            {
                case 1: Media(); break;
                case 2: System.Environment.Exit(0); break;
            }
            


        }

        static void Media()
        {
        double nota1,nota2,nota3,nota4,nota5,nota6;
        double media;

        Console.WriteLine("Digite a primeira nota");
        nota1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota");
        nota2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota");
        nota3=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quarta nota");
        nota4=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quinta nota");
        nota5=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a sexta nota");
        nota6=Convert.ToDouble(Console.ReadLine());
       

        media = ( nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 4;

        if(media >=6)
         {
         
            Console.WriteLine("Parabéns, você foi Aprovado!");
         

         } else{
        
            Console.WriteLine("Infelizmente você foi Reprovado");
        
        
         }

            Console.ReadKey();

            Menu();

      }

    }
        
}

    