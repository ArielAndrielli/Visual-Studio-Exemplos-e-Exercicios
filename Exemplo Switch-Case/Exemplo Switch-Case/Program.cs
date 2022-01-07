using System;

namespace Exemplo_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inform a number from 1 to 7: ");

            int x = int.Parse(Console.ReadLine());
            string day;

            #region Sem estrutura switch-case

            if (x == 1)
            {
                day = "Sunday";
            }else if (x == 2)
            {
                day = "Monday";
            }else if (x == 3)
            {
                day = "Tuesday";
            }else if (x == 4)
            {
                day = "Wednesday";
            }else if (x == 5)
            {
                day = "Thursday";
            }else if (x == 6)
            {
                day = "Friday";
            }else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid Value!";
            }

            #endregion

            #region Com estrutura switch-case

            switch (x) 
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                    //Default: se nenhum dos casos funcionou, será executado o default
                default:
                    day = "Invalid Value!";
                    break;
            }

            #endregion

            Console.WriteLine("Day: " + day);
        }
    }
}
