﻿using System;

namespace Exemplo_Interfaces.Entities
{
    class Rental
    {

        public DateTime Start { get; set; }

        public DateTime Finish { get; set; }

        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public Rental()
        {
        }

        public Rental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            //Invoice recebendo nulo
        }

        
    }
}
