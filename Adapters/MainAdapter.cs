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

using Android.Graphics;
using System.Net;
using App6.Models;

namespace App6.Adapter
{
    class MainAdapter : BaseAdapter<pModelKitchen>
    {
        private List<pModelKitchen> kitchenList;
        private Context mContext;

        public MainAdapter(Context context, List<pModelKitchen> list)
        {
            kitchenList = list;
            mContext = context;
        }

        public override pModelKitchen this[int position]
        {
            get
            {
                return kitchenList[position];
            }
        }

        public override int Count
        {
            get
            {
                return kitchenList.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.mainAdapter, null, false);
            }

            TextView textViewTitle = row.FindViewById<TextView>(Resource.Id.textViewMainTitle);
            textViewTitle.Text = kitchenList[position].nameKitchen;
            return row;
        }
    }
}