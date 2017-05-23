using System;
using Korat_Framework.Behaviors.Browser;
using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Factories
{
    public class BrowserBehaviorFactory : BehaviorFactory<BrowserBehaviors>
    {
        public override BrowserBehaviors Make(Korat korat, string version)
        {
            BrowserBehaviors browserBehaviors = new BrowserBehaviors(korat);

            switch (version)
            {
                case "0.2.149":
                    browserBehaviors.LanuchUrl = new Browser.Chrome.LaunchUrlBehavior(korat, images, "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "chrome-prev-icon.png");
                    return browserBehaviors;
                case "0.3.154":
                    browserBehaviors.LanuchUrl = new Browser.Chrome.LaunchUrlBehavior(korat, images, "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "chrome-new-prev-icon-new.png");
                    return browserBehaviors;
                case "58.0.3029":
                    browserBehaviors.LanuchUrl = new Browser.IE.LaunchUrlBehavior(korat, images, "test", "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "ie-prev-icon.png");
                    return browserBehaviors;
                case "59.0.3071":
                    browserBehaviors.LanuchUrl = new Browser.IE.LaunchUrlBehavior(korat, images, "test", "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "new-ie-prev-icon.png");
                    return browserBehaviors;
                case "60.0":
                    browserBehaviors.LanuchUrl = new Browser.IE.LaunchUrlBehavior(korat, images, "test", "url");
                    browserBehaviors.ToPreviousPage = new PrevPageBehavior(korat, "new-ie-prev-icon.png");
                    return browserBehaviors;
                default:
                    throw new ArgumentException("Not specified app version.");
            }
        }
    }
}
