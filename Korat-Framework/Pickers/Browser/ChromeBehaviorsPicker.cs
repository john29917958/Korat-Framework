using KoratFramework.Behaviors.Browsers;
using KoratFramework.Behaviors.Browsers.Chrome;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Browser
{
    public class ChromeBehaviorsPicker : BehaviorsPicker<BrowserBehaviors>
    {
        public ChromeBehaviorsPicker(Korat korat) : base(korat)
        {

        }

        public override BrowserBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "60.0"))
            {
                return new ChromeBehaviorsV60(Korat);
            }

            if (GreaterOrEquals(version, "0.2.149"))
            {
                return new ChromeBehaviors(Korat);
            }

            return null;
        }

        protected override bool GreaterOrEquals(string version, string benchmark)
        {
            return VersionComparer.GreaterEquals(version, benchmark);
        }
    }
}
