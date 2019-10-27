using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CommandBind
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string BtnText { get; set; } = "吃甜點";
        public Command<string> DoWhatCommand { get; set; }
        public Command ChangePasswordCommand { get; set; }
        public string DoSomething { get; set; } = "";
        public string Password { get; set; } = "";
        public string Message { get; set; } = "";
        public MyBindingContext()
        {
            DoWhatCommand = new Command<string>(x =>
            {
                DoSomething = x;
            });
            ChangePasswordCommand = new Command(_ =>
            {
                Message = "密碼已經變更完成";
            }, OnCanExecute);
        }

        void OnPasswordChanged()
        {
            ChangePasswordCommand.ChangeCanExecute();
        }

        private bool OnCanExecute(object arg)
        {
            if (Password.Length >= 6)
                return true;
            else
                return false;
        }
    }
}
