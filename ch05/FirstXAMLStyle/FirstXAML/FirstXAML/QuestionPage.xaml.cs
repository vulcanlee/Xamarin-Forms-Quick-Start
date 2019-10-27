using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage : ContentPage
    {
        int value1 = 0;
        int value2 = 0;

        public QuestionPage()
        {
            InitializeComponent();
            CreateQuestion();
            btnReQuestion.Clicked += (s, e) =>
            {
                CreateQuestion();
            };
            btnSubmit.Clicked += (s, e) =>
            {
                int sum = int.Parse(entAnswer.Text);
                if ((value1 + value2) == sum)
                {
                    lbMessage.Text = "答對了";
                }
                else
                {
                    lbMessage.Text = "答錯了";
                }
            };
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