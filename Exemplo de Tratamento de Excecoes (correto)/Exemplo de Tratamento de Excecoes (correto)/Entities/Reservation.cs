using System;
using Exemplo_de_Tratamento_de_Excecoes_correto.Entities;
using Exemplo_de_Tratamento_de_Excecoes_correto.Entities.Exceptions;

namespace Exemplo_de_Tratamento_de_Excecoes_correto.Entities
{
    class Reservation
    {
        #region Properties

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        #endregion

        #region Constructor

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("An error occurred while attempting to make your reservation: Check-Out date must be after Check-In date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        #endregion

        #region Methods

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("An error has occurred while attempting to make your reservation: Reservation dates for update must be future dates (you can't time-travel, dumbass)");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException ("An error occurred while attempting to make your reservation: Check-Out date must be after Check-In date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

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

        #endregion

    }
}

