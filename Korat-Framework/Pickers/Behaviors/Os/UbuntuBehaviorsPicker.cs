using KoratFramework.Behaviors.Os.Ubuntu;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Behaviors.Os
{
    public class UbuntuBehaviorsPicker : BehaviorsPicker<UbuntuBehaviors>
    {
        public UbuntuBehaviorsPicker(Korat korat, BehaviorPool pool) : base(korat, pool)
        {

        }

        public override UbuntuBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "14.04"))
            {
                return new UbuntuBehaviors(Korat);
            }

            return null;
        }

        protected override bool GreaterOrEquals(string version, string benchmark)
        {
            return VersionComparer.GreaterEquals(version, benchmark);
        }
    }
}
