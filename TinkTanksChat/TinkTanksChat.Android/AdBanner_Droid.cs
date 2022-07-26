using Rentor;
using Android.Gms.Ads;
using Rentor.Droid;
using Rentor;
using Rentor.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using TinkTanksChat;

[assembly: ExportRenderer(typeof(AdBanner), typeof(AdBanner_Droid))]
namespace Rentor.Droid
{
    public class AdBanner_Droid : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            var adMobElement = Element as AdBanner;
            if ((adMobElement != null) && (e.OldElement == null))
            {
                var adView = new AdView(Context);

                switch ((adMobElement).Size)
                {
                    case AdBanner.Sizes.Standardbanner:
                        adView.AdSize = AdSize.Banner;
                        break;
                    case AdBanner.Sizes.LargeBanner:
                        adView.AdSize = AdSize.LargeBanner;
                        break;
                    case AdBanner.Sizes.MediumRectangle:
                        adView.AdSize = AdSize.MediumRectangle;
                        break;
                    case AdBanner.Sizes.FullBanner:
                        adView.AdSize = AdSize.FullBanner;
                        break;
                    case AdBanner.Sizes.Leaderboard:
                        adView.AdSize = AdSize.Leaderboard;
                        break;
                    case AdBanner.Sizes.SmartBannerPortrait:
                        adView.AdSize = AdSize.SmartBanner;
                        break;
                    default:
                        adView.AdSize = AdSize.Banner;
                        break;
                }

                adView.AdUnitId = adMobElement.AdUnitId;

                // TODO: change this id to your admob id
                //adView.AdUnitId = "ca-app-pub-5539185599858824/2922005331";

                var requestbuilder = new AdRequest.Builder();
                adView.LoadAd(requestbuilder.Build());

                SetNativeControl(adView);
            }
        }
    }
}
