using System;

namespace CalculandoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua data de nascimento: ");
            DateTime DataNasc = Convert.ToDateTime(Console.ReadLine());
            
            int idade = DateTime.Today.Year - DataNasc.Year;
            
                if (DateTime.Today.DayOfYear < DataNasc.DayOfYear)
                {
                    idade = idade - 1 ;
                    Console.WriteLine(idade);           

                }else{
                    Console.WriteLine(idade);
                }
        }
    }
}
