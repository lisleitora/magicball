using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace magicball
{
    public partial class MainPage : ContentPage
    {
        bool _wait;
        List<string> _answers;
        public MainPage()
        {
            InitializeComponent();
            _answers = new List<string>();
            _answers.Add("sim");
            _answers.Add("não");
            _answers.Add("talvez");
            _answers.Add("é claro");
            _answers.Add("claro que não");

        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (_wait)
            {
                return;
            }
            _wait = true;
            _answerLabel.Text = "";
            var f = 200;
        await _ballImage.TranslateTo(f + 200, f + 200, 100, Easing.Linear);
            await _ballImage.TranslateTo(-f, -f, 600, Easing.Linear);
            await _ballImage.TranslateTo(0, 0, 600, Easing.SpringOut);

            int r = new Random().Next(0, 5);
            _answerLabel.Text = _answers[r];
            _wait = false;
        }
    }}
