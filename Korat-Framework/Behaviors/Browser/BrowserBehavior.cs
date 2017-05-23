using System;
using Korat_Framework.Resources;
using Korat_Framework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public abstract class BrowserBehavior : Behavior
    {
        protected BrowserImages Images;

        protected BrowserBehavior(Korat korat, BrowserImages images) : base(korat)
        {
            if (images == null)
            {
                throw new ArgumentNullException();
            }

            Images = images;
        }
    }
}
