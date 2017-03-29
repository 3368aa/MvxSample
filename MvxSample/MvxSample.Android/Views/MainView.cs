using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
using MvxSample.ViewModels;

namespace MvxSample.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = false, Theme ="@android:style/Theme.Light.NoTitleBar")]
    public class MainView : MvvmCross.Droid.FullFragging.Caching.MvxCachingFragmentActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainPage);

            var grp = FindViewById<RadioGroup>(Resource.Id.main_rg_toolbar);
            grp.CheckedChange += (s, e) =>
            {
                var btn = FindViewById<RadioButton>(e.CheckedId);
                if (btn.Checked == false) return;
                if (e.CheckedId == Resource.Id.main_rb_chat)
                {
                    ViewModel.ShowChat();
                }
                else if (e.CheckedId == Resource.Id.main_rb_friends)
                {
                    ViewModel.ShowFriends();
                } 
                else if (e.CheckedId == Resource.Id.main_rb_extras)
                {
                    ViewModel.ShowExtras();
                }
                else if (e.CheckedId == Resource.Id.main_rb_my)
                {
                    ViewModel.ShowMy();
                }
            };
            ViewModel.ShowChat();
        }
    }
}