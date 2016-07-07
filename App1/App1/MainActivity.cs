using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "Project 4", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button1 = FindViewById<Button>(Resource.Id.MyButton);
            Button button2 = FindViewById<Button>(Resource.Id.MyButton);
            Button button3 = FindViewById<Button>(Resource.Id.MyButton);

            button1.Click += delegate { button1.Text = string.Format("{0} clicks!", count++); };
            button2.Click += delegate { button2.Text = string.Format("{0} homos!", count++); };
        }
    }
}

