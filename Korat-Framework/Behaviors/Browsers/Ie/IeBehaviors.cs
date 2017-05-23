using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Ie
{
    public class IeBehaviors : BrowserBehaviors
    {
        public override string Version => "7";

        public IeBehaviors(Korat korat) : base(korat)
        {

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
