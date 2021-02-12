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

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int r = new Random().Next(0, 5);
            _answerLabel.Text = _answers[r];
        }
    }}
