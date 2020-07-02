using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Class_Structures
{
    class Student
    {
        public string Name;
        public double[] Notes = new double[3];
        double TotalNotes;

        public double SumNotes()
        {
            double SumNotes = 0;

            Console.WriteLine("Enter the three student notes: ");

            for (int iIndiceNotas = 0; iIndiceNotas < 3; iIndiceNotas++)
            {
                Notes[iIndiceNotas] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                SumNotes += Notes[iIndiceNotas];
            }

            return SumNotes;
        }

        public bool CheckStatus()
        {
            TotalNotes = SumNotes();

            if (TotalNotes >= 60)
                return true;
            else
                return false;
        }

        public double CalculateRemaining()
        {
            return 60 - TotalNotes; ;
        }

        public override string ToString()
        {

            if (CheckStatus() == true)
            {
                return "NOTA FINAL = " + TotalNotes.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                        + "APROVADO" ;
            }
            else 
            {
                return "NOTA FINAL = " + TotalNotes.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                        + "REPROVADO" + "\n"
                        + "FALTARAM " + CalculateRemaining().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

        }

    }
}
