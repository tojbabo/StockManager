using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.VIEWMODEL
{
    public class VM_PRODUCT : VM
    {
        VM_SALE vm;

        /// <summary>
        /// 리스트 박스에 사용될 컬렉션은 vm_sale의 컬레션 사용
        /// 동일한 컬렉션을 사용하도록 
        /// </summary>
        public ObservableCollection<Product> products { get => vm.products; }
        /// <summary>
        /// vm_sale의 경로 변수 사용
        /// </summary>
        private string _path { get => vm.path_product; }
        public VM_PRODUCT(VM_SALE v)
        {
            vm = v;
        }
        public void ProductAdd(Product p)
        {
            p.code = Convert.ToString(products.Count());
            products.Add(p);
        }
        

        public void ProductsDel(List<Product> items)
        {
            foreach(var v in items)
            {
                products.Remove(v);
            }
        }

        public void ProductsSave()
        {

            List<string> datas = new List<string>();
            foreach (var v in products)
                datas.Add(v.ToString());
            FILE.write(_path, datas, false);


            
            vm.productLoad();                                                   // 새로 저장해서 DB내용 바뀌면 Sale에서 데이터를 다시 읽도록
        }
    }
}
