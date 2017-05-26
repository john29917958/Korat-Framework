using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers
{
    public abstract class BrowserBehaviors : Behaviors
    {
        protected BrowserBehaviors(Korat korat) : base(korat)
        {

        }

        public abstract void FocusUrlBar();

        public virtual void LaunchUrl(string url)
        {
            FocusUrlBar();
            Korat.SendString(url);
        }

        public virtual void ToNextPage()
        {
            //Korat.Click(Images.NextButton);
        }

        public virtual void ToPrevPage()
        {
            //Korat.Click(Images.PrevButton);
        }
    }
}
