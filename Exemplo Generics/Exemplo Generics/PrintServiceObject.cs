using System;

namespace Exemplo_Generics
{
    class PrintServiceObject
    {
        #region Propriedades

        private object[] __values = new object[10];
        private int _count = 0;

        #endregion

        #region Métodos

        public void addValue(object value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintSet is Full");
            }
            __values[_count] = value;
            _count++;
        }

        public object First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is Empty");
            }
            return __values[0];
        }

        public void print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(__values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(__values[_count - 1]);
            }
            Console.WriteLine("]");
        }

        #endregion
    }
}
