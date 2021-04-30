using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace StockManager.MODEL
{
    public class MaterialList : ObservableCollection<Material> { }
    public class Material
    {
        public Material(){}
        public string materials { get; set; }
        public int count { get; set; }
        public string brand { get; set; }
        public string m_price { get; set; }
       
        public new string  ToString()
        {
            return $"{materials},{count},{brand},{m_price}";
        }
    }
}
