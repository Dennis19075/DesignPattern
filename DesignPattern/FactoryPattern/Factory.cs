using System;
namespace DesignPattern.FactoryPattern
{
	//CREATOR - ABSTRACT CLASS
	public abstract class SaleFactory
	{
		public abstract ISale GetSale();
	}

    //CONCRETE CREATOR - Factory
    public class StoreSaleFactory: SaleFactory
    {

        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
 
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    //CONCRETE CREATOR - Factory - Internet Sale Factory
    public class InternetSaleFactory : SaleFactory
    {

        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_discount);
        }
        
    }

    //Concret Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta tiene un total de {total + _extra}");
        }
    }

    //Concret Product
    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta tiene un total de {total - _discount}");
        }
    }

    //Product
    public interface ISale
	{
		public void Sell(decimal total);
	}
}

