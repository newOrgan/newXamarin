using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using App6.Models;
using App6.Adapter;
using System.Net;
using System.Collections.Generic;

namespace App6
{
    [Activity(Label = "App6", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        MainAdapter adapter;
        private List<pModelKitchen> list;

        ListView listView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Заполнение list 
            list = new List<pModelKitchen>
            {
                new pModelKitchen {nameKitchen = "name 1", Kitchen = 1  },
                new pModelKitchen {nameKitchen = "name 2", Kitchen = 2  },
                new pModelKitchen {nameKitchen = "name 3", Kitchen = 3  },
                new pModelKitchen {nameKitchen = "name 4", Kitchen = 4  },
                new pModelKitchen {nameKitchen = "name 5", Kitchen = 5  },
                new pModelKitchen {nameKitchen = "name 6", Kitchen = 6  },
                new pModelKitchen {nameKitchen = "name 7", Kitchen = 7  },
                new pModelKitchen {nameKitchen = "name 8", Kitchen = 8  },
                new pModelKitchen {nameKitchen = "name 9", Kitchen = 9  },
                new pModelKitchen {nameKitchen = "name 10", Kitchen = 10 },
                new pModelKitchen {nameKitchen = "name 11", Kitchen = 11 },
            };

            listView = FindViewById<ListView>(Resource.Id.listView);
            adapter = new MainAdapter(this, list);
            listView.Adapter = adapter;

            //click ListView
            listView.ItemClick += clickListView;

        }

        private void clickListView(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(App6.mActivitys.KafeMainActivity));
            intent.PutExtra("id", list[e.Position].Kitchen);
            StartActivity(intent);
        }
    }
}

