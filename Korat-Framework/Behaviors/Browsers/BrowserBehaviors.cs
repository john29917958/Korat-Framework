using System.Collections.Generic;
using System.Windows.Forms;
using KoratFramework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers
{
    public abstract class BrowserBehaviors : Behaviors
    {
        protected BrowserImages Images;

        protected BrowserBehaviors(Korat korat) : base(korat)
        {
            
        }

        public abstract void FocusUrlBar();

        public abstract void LaunchUrl(string url);

        public virtual void PrevPage()
        {
            Korat.Click(Images.PrevButton);
        }

        public virtual void NextPage()
        {
            Korat.Click(Images.NextButton);
        }

        public virtual void NewTab()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.T });
        }

        public virtual void CloseCurrentTab()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.W });
        }
    }
}
