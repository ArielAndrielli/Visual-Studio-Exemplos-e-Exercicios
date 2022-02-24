using System;
using System.Collections.Generic;

namespace Exemplo_Dictionary_e_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "988776655";
            cookies["phone"] = "899990967"; // Como não pode ter repetição esse segundo valor phone vai sobrescrever o primeiro phone

            //Pode adicionar valores dessa forma também: -> cookies.Add("key", "value");

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key!");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES: ");
            foreach(KeyValuePair<string, string> item in cookies) // A variável item pode ser definidada da forma 'var item' também
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
