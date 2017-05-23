using KoratFramework.Factories.Resource;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Chrome
{
    public class ChromeBehaviors : BrowserBehaviors
    {
        public override string Version => "0.2.149";

        public ChromeBehaviors(Korat korat) : base(korat)
        {
            Images = new ChromeImageFactory().Make(Version + " on ubuntu_16.04");
        }

        public override void FocusUrlBar()
        {
            Korat.Click(Images.UrlBarIcon);
        }

        public override void LaunchUrl(string url)
        {
            FocusUrlBar();
            Korat.SendString(url);
        }
    }
}
