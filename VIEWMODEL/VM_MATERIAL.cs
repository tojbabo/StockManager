using StockManager.ABSTRACT;
using StockManager.MODEL;
using StockManager.UTILITY;
using StockManager.VIEW;
using StockManager.VIEW.CHILD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StockManager.VIEWMODEL
{
    public class VM_MATERIAL : VM
    {
        WINDOWSTUFF ws;
        public ObservableCollection<Material> items { get; set; }
        private string path = @"db-content";
        public VM_MATERIAL()
        {
            items = new ObservableCollection<Material>(); //이거 꼭 만들어거 객체 생성해 줘야됨 아니면 역참조 에러남 시발!!!
        }
        public void ModifyStuff()
        {
            if (ws == null) { 
                ws = new WINDOWSTUFF(); //원준이 만든 윈도우스터프를 넣어서 생성
                ws.Closed += (s, e) => StuffWindowClose();
            }
            ws.Focus();
            ws.Show();
        }

        internal void LoadContent()
        {
            var lines = FILE.read(path);

            if (lines == null) return;

            foreach (string line in lines)
            {
                var datas = line.Split(',');
                items.Add(new Material
                {
                    materials = datas[0],
                    count = Convert.ToInt32(datas[1]),
                    brand = datas[2],
                    m_price = datas[3],
                });
            }
        }

        private void StuffWindowClose()
        {
            ws.Closed -= (s, e) => StuffWindowClose();
            ws = null;
        }

        internal void contentAdd()
        {
            //처음에는 빈껍데기만 추가
            items.Add(new Material());
        }

        internal void ContentSave()
        {
            //어짜피 바인딩은 눈에 보이는 것만, 내가 실제로 값을 넣으면 items로 들어가서 Materials에 저장됨과
            //동시에 다시 값이 들어가서 FILE에 쓰여진다.
            List<string> datas = new List<string>();
            foreach (Material s in items)
                datas.Add(s.ToString());
            FILE.write(path, datas,false); //이거 true로 바꾸면 새로 안써지고, 추가된다.
            MessageBox.Show("저장되었습니다.", "DB 저장");
        }
    }
}
