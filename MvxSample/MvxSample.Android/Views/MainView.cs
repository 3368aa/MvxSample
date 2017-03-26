using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MvxSample.ViewModels;

namespace MvxSample.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = false)]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainPage);

            // Create your application here
        }
    }
}