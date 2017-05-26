using KoratFramework.Behaviors.Browsers.Ie;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Behaviors.Browser
{
    public class IeBehaviorsPicker : BehaviorsPicker<IeBehaviors>
    {
        public IeBehaviorsPicker(Korat korat, BehaviorPool pool) : base(korat, pool)
        {

        }

        public override IeBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "ie7"))
            {
                return new IeBehaviors(Korat, Pool);
            }

            if (GreaterOrEquals(version, "edge"))
            {
                return new Edge(Korat, Pool);
            }

            return null;
        }

        protected override bool GreaterOrEquals(string version, string benchmark)
        {
            version = version.ToLower().Trim();
            benchmark = benchmark.ToLower().Trim();

            if (version.Contains("ie") && benchmark.Contains("edge"))
            {
                return true;
            }

            version = version.Replace("ie", string.Empty).Replace("edge", string.Empty).Trim();
            benchmark = benchmark.Replace("ie", string.Empty).Replace("edge", string.Empty).Trim();

            return VersionComparer.GreaterEquals(version, benchmark);
        }
    }
}
