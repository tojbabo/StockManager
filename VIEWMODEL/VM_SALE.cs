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
        public string path_product = @"db-product";
        public string path_sale = @"db-sales";
        WINDOWPRODUCT wp;
        public VM_SALE()
        {
            Sales = new ObservableCollection<Sale>();
            Sales.Add(new Sale());
            productLoad();
        }

        /// <summary>
        /// 수정 버튼 클릭 이벤트 처리
        /// </summary>
        public void ProductMODIFY()
        {
            if (wp == null)
            {
                wp = new WINDOWPRODUCT();
                wp.Closed += (s, e) => ProductWindowClose();                // 자식 윈도우 종료이벤트 추가
            }
            wp.Focus();
            wp.Show();

        }
        public void ListADD()
        {
            Sales.Add(new Sale());
        }
        public void ListSAVE()
        {
            List<string> datas = new List<string>();
            foreach (var v in Sales)
            {
                if (v.product == null) continue;
                datas.Add(v.ToString());
            }
            FILE.write(path_sale, datas, false);
        }
        public void ListRESET()
        {
            Sales.Clear();
            Sales.Add(new Sale());
        }

        /// <summary>
        /// 파일 읽어서 컬렉션에 추가하는 함수
        /// </summary>
        public void productLoad()
        {
            products.Clear();

            var lines = FILE.read(path_product);

            if (lines == null) return;

            foreach (string line in lines)
            {
                try
                {
                    var datas = line.Split(',');
                products.Add(new Product
                {
                    code = datas[0],
                    category = datas[1],
                    name = datas[2],
                    price = Convert.ToInt32(datas[3]),
                    comment = datas[4]
                });
                }
                catch { continue; }
            }

        }

        public void ListLoad()
        {
            Sales.Clear();

            var lines = FILE.read(path_sale);

            if (lines == null) return;

            foreach (string line in lines)
            {
                try
                {
                    var datas = line.Split(',');
                    Sales.Add(new Sale
                    {
                        date = datas[0],
                        count = datas[1],
                        total = Convert.ToInt32(datas[2]),
                        product = new Product()
                        {
                            code = datas[3],
                            category = datas[4],
                            name = datas[5],
                            price = Convert.ToInt32(datas[6]),
                            comment = datas[7],
                        }
                    });
                }
                catch { continue; }
            }
            ListADD();
        }

        /// <summary>
        /// ProductWindow의 종료 이벤트
        /// </summary>
        private void ProductWindowClose()
        {
            wp.Closed -= (s, e) => ProductWindowClose();                    // 없어도 되는 코드,, 혹시몰라서 사용
                                                                            // 자식 윈도우의 종료 이벤트 중복 방지
            wp = null;
        }

    }
}
