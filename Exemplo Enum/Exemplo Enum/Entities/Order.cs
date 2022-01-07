using Exemplo_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Enum.Entities
{
    class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
