using System;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public class BrowserFactory : Factory<BrowserBehaviors>
    {
        public override BrowserBehaviors Make(Korat korat, AppVersions appVersion)
        {
            BrowserBehaviors browserBehaviors = new BrowserBehaviors(korat);

            switch (appVersion)
            {
                case AppVersions.Chrome0_2_149:
                    browserBehaviors.LanuchUrl = new Chrome.LaunchUrlBehavior(korat, "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "chrome-prev-icon.png");
                    return browserBehaviors;
                case AppVersions.Chrome60_0:
                    browserBehaviors.LanuchUrl = new Chrome.LaunchUrlBehavior(korat, "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "chrome-new-prev-icon-new.png");
                    return browserBehaviors;
                case AppVersions.IE7:
                    browserBehaviors.LanuchUrl = new IE.LaunchUrlBehavior(korat, "test", "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "ie-prev-icon.png");
                    return browserBehaviors;
                case AppVersions.IE8:
                    browserBehaviors.LanuchUrl = new IE.LaunchUrlBehavior(korat, "test", "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "new-ie-prev-icon.png");
                    return browserBehaviors;
                default:
                    throw new ArgumentException("Not specified app version.");
            }
        }
    }
}
