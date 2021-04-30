using StockManager.ABSTRACT;

namespace StockManager.MODEL
{
    public class Sale  : PROPERTIES
    {
        public string date { get; set; }
        public int count { get; set; }
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
    }
}
