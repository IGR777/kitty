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
        Button calculateButton;
        EditText madamAge;
        SeekBar madamAgeSeekBar;
        TextView numberCats;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            madamAge = FindViewById<EditText>(Resource.Id.madamAge);
            numberCats = FindViewById<TextView>(Resource.Id.numberCats);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            madamAgeSeekBar = FindViewById<SeekBar>(Resource.Id.madamAgeSeekBar);
            
                     
        }

        protected override void OnStart()
        {
            base.OnStart();

            calculateButton.Click += CalculateButton_Click;

            madamAgeSeekBar.ProgressChanged += madamAgeSeekBar_ProgressChanged;

        }

        protected override void OnStop()
        {
            base.OnStop();

            calculateButton.Click += CalculateButton_Click;

            madamAgeSeekBar.ProgressChanged += madamAgeSeekBar_ProgressChanged;

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            int age = int.Parse(madamAge.Text);
            int Result = age / 8;
            numberCats.Text = Result.ToString() + " пушистиков";
        }

        private void madamAgeSeekBar_ProgressChanged(object sender, EventArgs e)
        {
            madamAge.Text = string.Format("{0}", madamAgeSeekBar.Progress);
        }

        
    }
}



