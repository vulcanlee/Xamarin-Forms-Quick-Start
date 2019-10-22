using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MoreBinding
{
    public class MyItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public MySubItem MySubItemData { get; set; }
    }

    public class MySubItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public MyItem MyItemObject { get; set; }
        public ObservableCollection<MyItem> MyItemList { get; set; } = new ObservableCollection<MyItem>();
        public string NullTitle { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }

        public Dictionary<string, int> Dict { get; set; }

        public MyBindingContext()
        {
            Title = "更多資料綁定主題";
            Message1 = "這是雙向綁定預設文字";
            Message2 = "這是單向綁定預設文字";
            MyItemObject = new MyItem
            {
                FirstName = "Main FirstName",
                MySubItemData = new MySubItem
                {
                    FirstName = "Sub Firstname",
                }
            };

            MyItemList = new ObservableCollection<MyItem>();
            MyItemList.Add(new MyItem() { FirstName = "FN1", LastName = "LN1" });
            MyItemList.Add(new MyItem() { FirstName = "FN2", LastName = "LN2" });
            MyItemList.Add(new MyItem() { FirstName = "FN3", LastName = "LN3" });

            Dict = new Dictionary<string, int>();
            Dict.Add("item1", 100);
            Dict.Add("item2", 120);
            Dict.Add("item3", 140);
            Dict.Add("item4", 160);

        }
    }
}
