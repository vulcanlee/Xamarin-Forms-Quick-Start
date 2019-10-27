using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirstCS
{
    public class QuestionPage : ContentPage
    {
        int value1 = 0;
        int value2 = 0;

        Label lbValue1 = new Label();
        Label lbValue2 = new Label();
        Label lbQuestion = new Label();
        Entry entAnswer = new Entry();
        Button btnReQuestion = new Button();
        Button btnSubmit = new Button();
        Label lbMessage = new Label();
        public QuestionPage()
        {
            CreateQuestion();

            lbValue1.FontSize = 20;
            lbValue1.TextColor = Color.Blue;
            lbValue2.FontSize = 20;
            lbValue2.TextColor = Color.Blue;

            lbQuestion.FontSize = 20;
            lbQuestion.TextColor = Color.Red;
            lbQuestion.Text = $"請問 {value1} + {value2} = 多少?";

            entAnswer.Keyboard = Keyboard.Numeric;

            lbMessage.FontSize = 30;
            lbMessage.TextColor = Color.Orange;

            btnReQuestion.Text = "產生問題";
            btnReQuestion.Clicked += (s, e) =>
            {
                CreateQuestion();
            };

            btnSubmit.Text = "提交";
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

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "數值1", FontSize=14 },
                    lbValue1,
                    new Label { Text = "數值2", FontSize=14 },
                    lbValue2,
                    new Label { Text = "問題", FontSize=14 },
                    lbQuestion,
                    new Label { Text = "答案", FontSize=14 },
                    entAnswer,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = {
                            btnReQuestion,
                            btnSubmit
                        }
                    },
                    lbMessage
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