using StockManager.ABSTRACT;
using StockManager.MODEL;
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

        WINDOWPRODUCT wp;
        public VM_SALE()
        {
            Sales = new ObservableCollection<Sale>();
        }

        public void ProductMODIFY()
        {
            if (wp == null)
                wp = new WINDOWPRODUCT();

            wp.Show();
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
    }
}
