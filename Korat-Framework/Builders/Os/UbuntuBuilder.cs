using System.Collections.Generic;

namespace Korat_Framework.Builders.Os
{
    public class UbuntuBuilder : Builder<UbuntuBuilder>
    {
        public UbuntuBuilder(string versionNumber) : base(versionNumber)
        {
        }

        protected override List<string> VersionNumbers => new List<string>
        {
            "14.04",
            "16.10"
        };

        protected override void Make()
        {
            throw new System.NotImplementedException();
        }
    }
}
