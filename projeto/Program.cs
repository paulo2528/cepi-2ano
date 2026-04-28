using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paulo
{
    internal class Program
    {
        static void Main(string[] args)

        {

            

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome=Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario=double.Parse(Console.ReadLine());


            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());


            double salario_medio = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine( "salario medio = " + salario_medio );
          
        }
    }
}

