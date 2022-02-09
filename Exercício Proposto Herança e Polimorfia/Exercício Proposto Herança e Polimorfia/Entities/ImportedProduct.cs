using System.Globalization;

namespace Exercício_Proposto_Herança_e_Polimorfia.Entities
{
    class ImportedProduct : Product
    {
        #region Property

        public double CustomsFee { get; set; }

        #endregion

        #region Constructor

        public ImportedProduct(string name, double price, double customsFee) :base (name, price)
        {
            CustomsFee = customsFee;
        }

        #endregion
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name
                + " (Customs Fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ") "
                + TotalPrice().ToString().Trim();
        }

    }
}
