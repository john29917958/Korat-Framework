using Korat_Framework.Behaviors;
using Korat_Framework.Behaviors.Browser;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();
            BrowserBehaviors browserBehaviors = new BrowserFactory().Make(korat, AppVersions.IE7);
            browserBehaviors.LanuchUrl.Execute();
        }
    }
}
