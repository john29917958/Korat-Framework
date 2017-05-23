using KoratFramework.Factories;
using KoratFramework.Resources;
using KoratFramework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();
            
            BrowserImages images = Factory<>.Make("chrome_60.0 ubuntu_16.04");
            /*
            BrowserBehaviors browserBehaviors = new BrowserBehaviorFactory().Make(korat, images, AppVersions.IE7);
            browserBehaviors.LanuchUrl.Execute();
            */
        }
    }
}
