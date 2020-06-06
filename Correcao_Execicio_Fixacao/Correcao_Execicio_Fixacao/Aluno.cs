using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Correcao_Execicio_Fixacao
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];
        double totalNotas;

        public double SomaNotas()
        {
            double soma = 0;

            Console.WriteLine("Digite as três notas dos alunos:");

            for (int iIndiceNotas = 0; iIndiceNotas < 3; iIndiceNotas++)
            {
                Notas[iIndiceNotas] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += Notas[iIndiceNotas];
            }

            return soma;
        }

        public bool VerificaStatus()
        {
            totalNotas = SomaNotas();

            if (totalNotas >= 60)
                return true;
            else
                return false;
        }

        public double CalculaRestante()
        {
            return 60 - totalNotas; ;
        }

        public override string ToString()
        {

            if (VerificaStatus() == true)
            {
                return "NOTA FINAL = " + totalNotas.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                        + "APROVADO" ;
            }
            else 
            {
                return "NOTA FINAL = " + totalNotas.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                        + "REPROVADO" + "\n"
                        + "FALTARAM " + CalculaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

            
        }

    }
}
