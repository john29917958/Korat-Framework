using Korat_Framework.Behaviors;
using Korat_Framework.Behaviors.Browser;
using Korat_Framework.Behaviors.Factories;
using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();
            /*
            BrowserImages images = ImageFactory.Make(AppVersions.Chrome0_2_149);
            
            BrowserBehaviors browserBehaviors = new BrowserBehaviorFactory().Make(korat, images, AppVersions.IE7);
            browserBehaviors.LanuchUrl.Execute();
            */
        }
    }
}
