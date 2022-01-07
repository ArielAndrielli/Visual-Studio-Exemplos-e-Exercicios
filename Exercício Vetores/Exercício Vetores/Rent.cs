using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Vetores
{
    class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        public Rent(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
