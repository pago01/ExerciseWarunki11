using System;
using System.ComponentModel.Design;

namespace ExerciseWarunki11
{
    //Data structure declaration

    class Program
    {
        private static void Main(string[] args)
        {
            int ocena = 0;
            string opis = "";
            bool parseresult;
            //Score read
            do
            {
                Console.WriteLine("Podaj ocenę od 1 do 6");
                parseresult = Int32.TryParse(Console.ReadLine(), out ocena);
            }
            while (!parseresult || ocena<1 || ocena>6);

           
            //Score description
            switch( ocena )
            {
                case 1:
                    opis = "Niedostateczny";
                    break;
                case 2:
                    opis = "Dopuszczający";
                    break;
                case 3:
                    opis = "Dostateczny";
                    break;
                case 4:
                    opis = "Dobry";
                    break;
                case 5:
                    opis = "Bardzo dobry";
                    break;
                case 6:
                    opis = "Celujący";
                    break;
            }
            Console.WriteLine(opis);
        }
    }
}


