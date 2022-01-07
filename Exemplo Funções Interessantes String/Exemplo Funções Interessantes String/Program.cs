using System;

namespace Exemplo_Funções_Interessantes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            //ToUpper: Transforma tudo em letra maiúscula
            string s1 = original.ToUpper();

            //ToLower: Transforma tudo em letra minúscula
            string s2 = original.ToLower();

            //Trim: Apaga os espaços em branco
            string s3 = original.Trim();

            //IndexOf: Vai mostrar qual a primeira ocorrência de certa parte determinada
            int n1 = original.IndexOf("bc");

            //LastIndexOf: Vai mostrar a última ocorrência de certa parde determinada
            int n2 = original.LastIndexOf("bc");

            //Substring: Recorta a string a partir de certo ponto ----- Tem 2 sobrecargas nessa operação: dá pra informar o índice inicial ou o índice junto do tamanho que você quer cortar
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            //Substituir uma parte da string por outra
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            //IsNullOrEmpty: Testa pra ver se a string é vazia
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf: -" + n1 + "-");
            Console.WriteLine("LastIndexOf: -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");
        }
    }
}
