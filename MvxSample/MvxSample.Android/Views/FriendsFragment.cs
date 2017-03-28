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
    [MvxFragment(typeof(MainViewModel), Resource.Id.main_container, IsCacheableFragment =true)]
    [Register("mvxsample.droid.views.FriendsFragment")]
    public class FriendsFragment:MvxFragment<FriendsViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.FriendsFragment, container, false);
            return view;
        }
    }
}