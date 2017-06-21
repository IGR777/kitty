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
            MadamAge = 40,
        };

       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText MadamAge = FindViewById<EditText>(Resource.Id.MadamAge);
            EditText NumberCats = FindViewById<EditText>(Resource.Id.NumberCats);
        }

    }
}

