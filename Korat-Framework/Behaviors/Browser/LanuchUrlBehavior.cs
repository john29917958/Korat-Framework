using System;
using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public abstract class LanuchUrlBehavior : BrowserBehavior
    {
        protected string Url;

        protected LanuchUrlBehavior(Korat korat, BrowserImages images, string url) : base(korat, images)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Given URL should be specified.");
            }

            Url = url;
        }
    }
}
