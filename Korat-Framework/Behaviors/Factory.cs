using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors
{
    public abstract class Factory<T> where T : Behaviors
    {
        public abstract T Make(Korat korat, BrowserImages images, AppVersions appVersion);
    }
}
