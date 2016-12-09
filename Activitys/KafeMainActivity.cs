using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6.Activitys
{
    [Activity(Label = "KafeMainActivity")]
    public class KafeMainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KafeMain);

            int kitchen = Intent.GetIntExtra("kitchen", 0);

        }
    }
}