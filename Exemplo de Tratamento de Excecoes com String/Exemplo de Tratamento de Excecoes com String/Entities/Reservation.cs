using System;

namespace Exemplo_de_Tratamento_de_Excecoes_com_String.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "An error has occurred while attempting to make your reservation: Reservation dates for update must be future dates (you can't time-travel, dumbass)";
            }
            if (checkOut <= checkIn)
            {
                return "An error occurred while attempting to make your reservation: Check-Out date must be after Check-In date!";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }

        public override string ToString()
        {
            return "Room "
            + RoomNumber
            + ", Check-In: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Check-Out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }

    }
}
