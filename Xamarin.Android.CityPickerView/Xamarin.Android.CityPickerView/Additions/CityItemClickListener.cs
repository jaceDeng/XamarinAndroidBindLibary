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
using Com.Lljjcoder.Bean;

namespace Com.Lljjcoder.Interface
{
    public class CityItemClickListener : OnCityItemClickListener
    {
        public event EventHandler OnCancelEvent;
        public event EventHandler<CityItemClickSelectedEventArgs> OnSelectedEvent;
        public override void OnCancel()
        {
            OnCancelEvent?.Invoke(this, new EventArgs());
        }

        public override void OnSelected(ProvinceBean province, CityBean city, DistrictBean district)
        {
            OnSelectedEvent?.Invoke(this, new CityItemClickSelectedEventArgs()
            {
                Province = province,
                City = city,
                District = district
            });
        }
    }

    public class CityItemClickSelectedEventArgs : EventArgs
    {
        public ProvinceBean Province { get; set; }
        public CityBean City { get; set; }
        public DistrictBean District { get; set; }
    }
}