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
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Droid.Shared.Attributes;
using MvxSample.ViewModels;

namespace MvxSample.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.main_container)]
    [Register("mvxsample.droid.views.ExtrasFragment")]
    public class ExtrasFragment:MvxFragment<ExtrasViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.ExtrasFragment, container, false);
            return view;
        }
    }
}