using System.Collections.Generic;
using Korat_Framework.Behaviors.Factories;
using Korat_Framework.Builders.Os;

namespace Korat_Framework.Builders.Browsers
{
    public class ChromeBuilder : Builder<UbuntuBuilder>
    {
        public ChromeBuilder(string versionNumber) : base(versionNumber)
        {

        }

        protected override List<string> VersionNumbers => new List<string>
        {
            "0.2.149", "0.3.154", "58.0.3029", "59.0.3071", "60.0"
        };

        protected override void Make()
        {
            string versions = GetHostHirarchy();

            Behaviors = new BrowserBehaviorFactory().Make(null, versions);
        }
    }
}
