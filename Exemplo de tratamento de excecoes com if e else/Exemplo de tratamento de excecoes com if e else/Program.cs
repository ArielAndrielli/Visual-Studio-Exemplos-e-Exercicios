using System;
using Exemplo_de_tratamento_de_excecoes_com_if_e_else.Entities;

namespace Exemplo_de_tratamento_de_excecoes_com_if_e_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("An error occurred while trying to make your reservation: Check-Out date must be after Check-In");

            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter the data to update the reservation: ");
                Console.Write("Check-In Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("An error has occurred while attempting to make your reservation: Reservation dates for update must be future dates (you can't time-travel, dumbass)");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("An error occurred while attempting to make your reservation: Check-Out date must be after Check-In date!");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }


            }
        }
    }
}
