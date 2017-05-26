using System;
using KoratFramework.Behaviors.Os;
using KoratFramework.Exceptions;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers
{
    public abstract class BrowserBehaviors : Behaviors
    {
        protected OsBehaviors Os;

        protected BrowserBehaviors(Korat korat, BehaviorPool pool) : base(korat)
        {
            if (pool == null)
            {
                throw new ArgumentNullException("Behaviors pool should not be null.");
            }

            Os = pool.Request<OsBehaviors>();
            if (Os == null)
            {
                throw new BehaviorsNotFoundException("OS behavior cannot be found from behaviors pool.");
            }
        }

        public abstract void FocusUrlBar();

        public virtual void LaunchUrl(string url)
        {
            FocusUrlBar();
            Korat.SendString(url);
        }

        public string GetUrlText()
        {
            FocusUrlBar();
            return Os.Copy();
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
