using KoratFramework.Behaviors.Browsers;
using KoratFramework.Behaviors.Browsers.Ie;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Browser
{
    public class IeBehaviorsPicker : BehaviorsPicker<BrowserBehaviors>
    {
        public IeBehaviorsPicker(Korat korat) : base(korat)
        {

        }

        public override BrowserBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "ie7"))
            {
                return new IeBehaviors(Korat);
            }

            if (GreaterOrEquals(version, "edge"))
            {
                return new Edge(Korat);
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
