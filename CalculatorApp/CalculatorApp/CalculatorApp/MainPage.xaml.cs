using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        string calSign;

        public MainPage()
        {
            InitializeComponent();
        }

        void displayCalSign(string sign)
        {
            displayLbl.Text = sign;
        }

        void OnNumBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnMultBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnSubstBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnAddBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnNegBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnDecBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }

        // skal rettes
        void OnEqualBtnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            calSign = btn.Text;
            displayCalSign(calSign);
        }
    }
}
