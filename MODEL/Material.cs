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
        public Material(string materials, int count, string brand, string m_price)
        {
            this.materials = materials;
            this.count = count;
            this.brand = brand;
            this.m_price = m_price;
        }
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
