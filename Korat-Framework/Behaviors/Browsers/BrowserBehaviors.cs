using KoratFramework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers
{
    public abstract class BrowserBehaviors : Behaviors<BrowserImages>
    {
        protected BrowserBehaviors(Korat korat) : base(korat)
        {

        }

        public virtual void FocusUrlBar()
        {
            Korat.Click(Images.UrlBarIcon);
        }

        public virtual void LaunchUrl(string url)
        {
            FocusUrlBar();
            Korat.SendString(url);
        }

        public virtual void ToNextPage()
        {
            Korat.Click(Images.NextButton);
        }

        public virtual void ToPrevPage()
        {
            Korat.Click(Images.PrevButton);
        }
    }
}
