using KoratFramework.Behaviors.Os.Windows;
using KoratFramework.Version;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Behaviors.Os
{
    public class WinBehaviorsPicker : BehaviorsPicker<WindowsBehaviors>
    {
        public WinBehaviorsPicker(Korat korat) : base(korat)
        {
        }

        public override WindowsBehaviors Pick(string version)
        {
            if (GreaterOrEquals(version, "7"))
            {
                return new WindowsBehaviors(Korat);
            }

            return null;
        }

        protected override bool GreaterOrEquals(string ntVersion, string nTbenchmark)
        {
            string version = ntVersion.ToLower().Replace("nt", string.Empty).Trim();
            string benchmark = nTbenchmark.ToLower().Replace("nt", string.Empty).Trim();

            return VersionComparer.GreaterEquals(version, benchmark);
        }
    }
}
