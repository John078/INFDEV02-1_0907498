﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace MapsAppSchets
{
    [Activity(Label = "MapsAppSchets", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {

            private GoogleMap mMap;

            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.Main);
                SetUpMap();
            }
            private void SetUpMap()
            {
                if (mMap == null)
                {
                    FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
                }

            }
            public void OnMapReady(GoogleMap googleMap)
            {
                mMap = googleMap;
            }
        


    }
}

