using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxSample.Droid.Views
{
    [Activity(Label = "MvxTest", NoHistory =true, MainLauncher = true, Theme = "@style/AppSplash")]
    public class SplashScreenView : MvxSplashScreenActivity
    {
        public SplashScreenView() : base(Resource.Layout.SplashScreenPage)
        {
        }

    }
}