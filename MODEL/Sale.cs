using StockManager.ABSTRACT;

namespace StockManager.MODEL
{
    public class Sale : PROPERTIES
    {
        private string _count;
        public string count
        {
            get => _count;
            set
            {
                _count = value;
                total = ((count!="")?System.Convert.ToInt32(_count):0) * ((product != null) ? product.price : 0);
                OnPropertyChanged(nameof(total));
            }
        }
        public int total { get; set; }
        private Product _p;
        public Product product
        {
            get => _p;
            set
            {
                _p = value;
                OnPropertyChanged(nameof(product));
            }
        }

        public new string ToString()
        {
            return $"{count},{total},{product.ToString()}";
        }
    }
}
