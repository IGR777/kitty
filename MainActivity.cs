using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace kitty
{
    [Activity(Label = "kitty", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TipInfo info = new TipInfo()
        {
            TipPercent = 15,
        };

        TextView TipPercent;
        TextView Total;
        TextView TipValue;

        public Activity1()
        {
            info.TipValueChanged += (sender, e) => {
                TipValue.Text = info.TipValue.ToString();
                Total.Text = (info.TipValue + info.Total).ToString();
            };
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

