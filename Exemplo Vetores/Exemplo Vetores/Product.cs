using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Vetores
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        public Product(string nome, string email)
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
