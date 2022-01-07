using System;
using System.Collections.Generic;
using System.Text;

namespace Are_Per_Dia_Retangulo
{
    class Rtgl
    {
        public double altura;
        public double largura;

        public double AreaRetangulo()
        {
            return altura * largura;
        }

        public double PerimetroRetangulo()
        {
            return (2 * altura) + (2 * largura);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt((altura * altura) + (largura * largura));
        }


    }
}
