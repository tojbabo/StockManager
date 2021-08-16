using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace StockManager.UTILITY
{
    public static class LISTBOX
    {
        /// <summary>
        /// 리스트 박스 내 특정 컨트롤러로 부터 
        /// 해당 컨트롤러를 포함하는 리스트 박스 아이템을 가져옴
        /// </summary>
        /// <typeparam name="T">특정 컨트롤러의 종류</typeparam>
        /// <param name="list">찾고자 하는 리스트박스</param>
        /// <param name="control">컨트롤러의 객체</param>
        /// <param name="controlname">컨트롤러의 이름</param>
        /// <returns></returns>
        public static  ListBoxItem GetItemfromControl<T>(ListBox list, T control, string controlname)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListBoxItem listboxitem = (ListBoxItem)list.ItemContainerGenerator.ContainerFromItem(list.Items[i]);
                ContentPresenter content = FindVisualChild<ContentPresenter>(listboxitem);

                DataTemplate dtemplate = content.ContentTemplate;

                T temp = (T)dtemplate.FindName(controlname, content);
                if ((object)control == (object)temp) return listboxitem;
            }
            return null;
        }

        public static T Getcontrolfromidx<T>(ListBox list, int idx, string controlname)
        {
            if (list.Items.Count < idx || list.Items.Count == 0) return default(T);

            var v = (ListBoxItem)list.ItemContainerGenerator.ContainerFromItem(list.Items[idx]);
            if (v == null) return default(T);



            return GetControlfromItem<T>(v, controlname);

        }


        /// <summary>
        /// 리스트박스 아이템에서 특정 컨트롤을 찾아오는 함수
        /// </summary>
        /// <typeparam name="T">찾을 콘트롤의 종류</typeparam>
        /// <param name="item">콘트롤이 포함된 리스트박스 아이템</param>
        /// <param name="controlname">콘트롤의 이름</param>
        /// <returns>찾은 콘트롤</returns>
        public static T GetControlfromItem<T>(ListBoxItem item, string controlname)
        {
            ContentPresenter content = FindVisualChild<ContentPresenter>(item);

            DataTemplate dtemplate = content.ContentTemplate;

            T temp = (T)dtemplate.FindName(controlname, content);

            return temp;

        }
        private static ChildControl FindVisualChild<ChildControl>(DependencyObject DependencyObj)
        where ChildControl : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(DependencyObj); i++)
            {
                DependencyObject Child = VisualTreeHelper.GetChild(DependencyObj, i);

                if (Child != null && Child is ChildControl)
                {
                    return (ChildControl)Child;
                }
                else
                {
                    ChildControl ChildOfChild = FindVisualChild<ChildControl>(Child);

                    if (ChildOfChild != null)
                    {
                        return ChildOfChild;
                    }
                }
            }
            return null;
        }
    }
}
