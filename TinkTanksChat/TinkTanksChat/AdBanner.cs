using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TinkTanksChat
{
    public  class AdBanner : View
    {
        public enum Sizes { Standardbanner, LargeBanner, MediumRectangle, FullBanner, Leaderboard, SmartBannerPortrait }
        public Sizes Size { get; set; }
        public static readonly BindableProperty AdUnitIdProperty =
            BindableProperty.Create<AdBanner, string>(p => p.AdUnitId, "");
        //AdUnitId example : ca-app-pub-5796681800623607/8623940979

        /// <summary>
        /// The ID of the AdMob ad to display
        /// This is the string Id from your Google Play account
        /// </summary>
        public string AdUnitId
        {
            get
            {
                return (string)GetValue(AdUnitIdProperty);
            }
            set
            {
                SetValue(AdUnitIdProperty, value);
            }
        }
    }
}
