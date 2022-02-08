using System.Globalization;

namespace Exercício_Proposto_Herança_e_Polimorfia.Entities
{
    class Product
    {

        #region Properties

        public string Name { get; set; }

        public double Price { get; set; }

        #endregion

        #region Constructor

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        #endregion
        
        public virtual string priceTag()
        {
            return Name
            + " $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
