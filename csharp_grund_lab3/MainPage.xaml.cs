using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace csharp_grund_lab3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MomsCalculator momsCalc = new MomsCalculator();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Calculate(object sender, EventArgs args)
        {
            momsCalc.Belopp = TrimDoubleValue(InputBelopp.Text);
            momsCalc.Moms = TrimDoubleValue((sender as Button).Text);
            OutputMomsSats.Text = TrimDoubleValue((sender as Button).Text).ToString();
            OutputUtraknatBelopp.Text = string.Format("{0:0.00}", momsCalc.UtraknatBelopp());
            OutputUtraknadMoms.Text = string.Format("{0:0.00}", momsCalc.UtraknadMoms());
        }

        private double TrimDoubleValue(string text)
        {
            if (text != null)
            {
                if (double.TryParse(Regex.Replace(text, "[^.0-9]", ""), out double momsValue))
                {
                    return momsValue;
                }
            }

            return 0;
        }
    }
}
