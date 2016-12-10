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

namespace App6.Adapters
{
    class KafeMainAdapter : BaseAdapter<pModelKafe>
    {
        Context mContext;
        List<pModelKafe> listKafe;

        public KafeMainAdapter(List<pModelKafe> list, Context context)
        {
            mContext = context;
            listKafe = list;
        }

        public override pModelKafe this[int position]
        {
            get
            {
                return listKafe[position];
            }
        }

        public override int Count
        {
            get
            {
                return listKafe.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.KafeMainAdapter, null, false);
            }
            TextView kafeTitle = row.FindViewById<TextView>(Resource.Id.kafe_title);
            kafeTitle.Text = listKafe[position].rest_name;

            TextView kafeAdress = row.FindViewById<TextView>(Resource.Id.kafe_adress);
            kafeAdress.Text = listKafe[position].rest_adress;

            return row;

        }
    }
}