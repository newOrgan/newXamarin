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
using App6.Models;
using App6.Adapters;

namespace App6.mActivitys
{
    [Activity(Label = "KafeMainActivity")]
    public class KafeMainActivity : Activity
    {
        ListView listView;
        private List<pModelKafe> list;

        KafeMainAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KafeMain);

            //
            listView = FindViewById<ListView>(Resource.Id.listViewKafe);

            int idKitchen  = Intent.GetIntExtra("id", 0);

            Toast.MakeText(this, idKitchen, ToastLength.Short).Show();


            list = new List<pModelKafe>
            {
                new pModelKafe {rest_id = 1, rest_string_id = "1", rest_name = "name 1", rest_adress = "Ангарский бульвар 44", rest_kitchen = 1, rest_spec = 1 },
                new pModelKafe {rest_id = 2, rest_string_id = "2", rest_name = "name 2", rest_adress = "Ангарский бульвар 44", rest_kitchen = 1, rest_spec = 1 },
                new pModelKafe {rest_id = 3, rest_string_id = "3", rest_name = "name 3", rest_adress = "Ангарский бульвар 44", rest_kitchen = 1, rest_spec = 1 },
                new pModelKafe {rest_id = 4, rest_string_id = "4", rest_name = "name 4", rest_adress = "Ангарский бульвар 44", rest_kitchen = 1, rest_spec = 1 },
            };

            adapter = new KafeMainAdapter(list, this);

            listView.Adapter = adapter;
        }
    }
}