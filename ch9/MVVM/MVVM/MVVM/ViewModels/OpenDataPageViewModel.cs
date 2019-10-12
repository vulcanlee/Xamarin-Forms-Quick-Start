using MVVM.Models;
using MVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class OpenDataPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Keyword { get; set; } = "123";
        public bool IsShowDetail { get; set; } = false;
        public Command ReloadCommand { get; set; }
        public Command SearchKeyworkCommand { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command CloseDetailCommand { get; set; }
        public OpenDataItem OpenDataSelectedItem { get; set; }
        public ObservableCollection<OpenDataItem> OpenDataItems { get; set; } = new ObservableCollection<OpenDataItem>();
        public OpenDataPageViewModel()
        {
            ReloadCommand = new Command(async () =>
            {
                await LoadData();
            });
            ItemTappedCommand = new Command(() =>
            {
                IsShowDetail = true;
            });
            CloseDetailCommand = new Command(() =>
            {
                IsShowDetail = false;
            });
            SearchKeyworkCommand = new Command(async () =>
            {
                await LoadData(Keyword);
            });
        }

        public async Task LoadData(string keyword = null)
        {
            OpenDataService openDataService = new OpenDataService();
            var content = await openDataService.Get();
            OpenDataItems.Clear();
            foreach (var item in content)
            {
                if (string.IsNullOrEmpty(keyword) == false)
                {
                    if (item.連絡電話?.Contains(keyword) == false)
                    {
                        continue;
                    }
                }
                OpenDataItems.Add(item);
            }
        }
    }
}
