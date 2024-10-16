namespace Upskilling
{
    public class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return Price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                _price = value;
            }
        }
        public int StockQuantity
        {
            get
            {
                return StockQuantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                Price = value;
            }
        }
        public bool IsAvailable
        {
            get { return IsAvailable; }
            set
            {
                IsAvailable = StockQuantity > 0;
            }
        }
        public void UpdateStock(int stockQuantity)
        {
            StockQuantity = stockQuantity;
            IsAvailable |= StockQuantity > 0;
        }
    }
}