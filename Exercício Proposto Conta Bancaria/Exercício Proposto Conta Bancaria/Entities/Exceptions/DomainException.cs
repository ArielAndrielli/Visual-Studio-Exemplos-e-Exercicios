using System;

namespace Exercício_Proposto_Conta_Bancaria.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
