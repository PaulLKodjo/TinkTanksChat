using Android.Gms.Ads;
using Android.Gms.Ads.Interstitial;
using Rentor.Droid;
using TinkTanksChat;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdInterstitial_Droid))]
namespace Rentor.Droid
{
    public class AdInterstitial_Droid : IAdInterstitial
    {
        InterstitialAd interstitialAd;

        public AdInterstitial_Droid()
        {
            //interstitialAd = new InterstitialAd(Android.App.Application.Context);

            //// TODO: change this id to your admob id
            //interstitialAd.AdUnitId = "ca-app-pub-5539185599858824/9381736705";
            LoadAd();
        }

        void LoadAd()
        {
            var requestbuilder = new AdRequest.Builder();
            //interstitialAd.LoadAd(requestbuilder.Build());
        }

        public void ShowAd()
        {
            //if (interstitialAd.IsLoaded)
            //interstitialAd.Show();

            LoadAd();
        }
    }
}
