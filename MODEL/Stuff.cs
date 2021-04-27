namespace StockManager.MODEL
{
    public class Stuff
    {
        public int code { get; set; }
        public string category { get; set; }
        public string item { get; set; }
        public string price { get; set; }
        public new string  ToString()
        {
            return $"{code},{category},{item},{price}";
        }
    }
}
