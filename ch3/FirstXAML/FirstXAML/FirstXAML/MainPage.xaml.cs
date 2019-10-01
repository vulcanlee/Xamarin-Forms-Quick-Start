using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstXAML
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int value1 = 0;
        int value2 = 0;
        public MainPage()
        {
            InitializeComponent();
            CreateQuestion();
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            int sum = int.Parse(entAnswer.Text);
            if((value1+value2)==sum)
            {
                lbMessage.Text = "答對了";
            }
            else
            {
                lbMessage.Text = "答錯了";
            }
        }

        private void btnReQuestion_Clicked(object sender, EventArgs e)
        {
            CreateQuestion();
        }
        void CreateQuestion()
        {
            Random random = new Random();
            value1 = random.Next(10, 99);
            value2 = random.Next(10, 99);

            lbValue1.Text = $"{value1}";
            lbValue2.Text = $"{value2}";

            lbQuestion.Text = $"請問 {value1} + {value2} = 多少?";
            lbMessage.Text = "";
        }
    }
}
