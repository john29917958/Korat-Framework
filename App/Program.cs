using Korat_Framework.Resources;
using Korat_Framework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();
            
            BrowserImages images = ImageFactory.Make("chrome_60.0 ubuntu_16.04");
            /*
            BrowserBehaviors browserBehaviors = new BrowserBehaviorFactory().Make(korat, images, AppVersions.IE7);
            browserBehaviors.LanuchUrl.Execute();
            */
        }
    }
}
