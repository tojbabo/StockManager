using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using StockManager.VIEW;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_SALE : VM
    {
        #region property

        private ObservableCollection<Sale> _Sales;
        public ObservableCollection<Sale> Sales
        {
            get
            {
                if (_Sales == null)
                    _Sales = new ObservableCollection<Sale>();
                return _Sales;
            }
            set
            {
                _Sales = value;
                OnPropertyChanged(nameof(Sales));
            }
        }
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> products
        {
            get
            {
                if (_products == null)
                    _products = new ObservableCollection<Product>();
                return _products;
            }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(products));
            }
        }
        #endregion
        private string path_product = @"db-product";
        WINDOWPRODUCT wp;
        public VM_SALE()
        {
            Sales = new ObservableCollection<Sale>();
            Sales.Add(new Sale());
            _productLoad();
        }

        public void ProductMODIFY()
        {
            if (wp == null)
            {
                wp = new WINDOWPRODUCT();
                wp.Closed += (s, e) => ProductWindowClose();
            }
            wp.Focus();
            wp.Show();

        }
        private void ProductWindowClose()
        {
            wp.Closed -= (s, e) => ProductWindowClose(); 
            wp = null;
        }
        public void ListADD()
        {
            Sales.Add(new Sale());
        }
        public void ListSAVE()
        {

        }
        public void ListRESET()
        {
            Sales.Clear();
        }

        private void _productLoad()
        {
            var lines = FILE.read(path_product);

            if (lines == null) return;

            foreach (string line in lines)
            {
                var datas = line.Split(',');
                products.Add(new Product
                {
                    code = datas[0],
                    category = datas[1],
                    name = datas[2],
                    price = datas[3],
                });
            }
        }

    }
}
