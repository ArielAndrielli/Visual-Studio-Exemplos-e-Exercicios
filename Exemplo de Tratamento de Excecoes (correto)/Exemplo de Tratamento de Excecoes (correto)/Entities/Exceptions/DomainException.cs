using System;

namespace Exemplo_de_Tratamento_de_Excecoes_correto.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) :base(message)
        {
        }
    }
}
