using KoratFramework.Behaviors.Browsers.Chrome;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Behaviors.Browser
{
    public class ChromeBehaviorsPicker : BehaviorsPicker<ChromeBehaviors>
    {
        public ChromeBehaviorsPicker(Korat korat, BehaviorPool pool) : base(korat, pool)
        {

        }

        public override ChromeBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "60.0"))
            {
                return new ChromeBehaviorsV60(Korat, Pool);
            }

            if (GreaterOrEquals(version, "0.2.149"))
            {
                return new ChromeBehaviors(Korat, Pool);
            }

            return null;
        }

        protected override bool GreaterOrEquals(string version, string benchmark)
        {
            return VersionComparer.GreaterEquals(version, benchmark);
        }
    }
}
