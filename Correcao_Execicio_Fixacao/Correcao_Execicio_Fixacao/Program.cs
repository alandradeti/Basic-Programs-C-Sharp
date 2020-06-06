using System;
using System.Globalization;
using Correcao_Execicio_Fixacao;

namespace Correcao_Execicio_Fixacao
{
    class Program
    {
        static void Exercicio1() 
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Exercicio2() 
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o nome, salário bruto e  o imposto: ");
            funcionario.Nome = Console.ReadLine();
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + funcionario);

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados:" + funcionario);

        }

        static void Exercicio3() 
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine(aluno);

        }
        static void Main(string[] args)
        {
            //Exercicio1();         
            //Exercicio2();
            //Exercicio3();
        }
    }
}
