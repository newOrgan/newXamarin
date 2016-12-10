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

namespace App6.Models
{
    class pModelKafe
    {
        public int rest_id { get; set; }
        public string rest_string_id { get; set; }
        public string rest_name { get; set; }
        public string rest_adress { get; set; }
        public int rest_spec { get; set; }
        public int rest_kitchen { get; set; }
    }
}