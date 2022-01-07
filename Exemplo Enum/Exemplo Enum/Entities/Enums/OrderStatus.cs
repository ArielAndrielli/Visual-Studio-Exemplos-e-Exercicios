using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Enum.Entities.Enums
{
    enum OrderStatus : int
    {
        //Você pode atribuir o valor que quiser para os valores abaixo (Ex: Processing = 7) e se por acaso
        //você não definir um valor ele vai fazer uma contagem começando em 0

        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
