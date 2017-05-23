using KoratFramework.Behaviors.Browsers;
using KoratFramework.Factories.Behaviors;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();

            BrowserBehaviors behaviors = new BrowserBehaviorFactory(korat).Make("Chrome 60.0 ubuntu_16.04");
            behaviors.FocusUrlBar();
            behaviors.LaunchUrl("https://www.google.com.tw/");
            //...and so on...

            BrowserBehaviors easyReplaceableBehaviors = new BrowserBehaviorFactory(korat).Make("IE edge win10");
            easyReplaceableBehaviors.FocusUrlBar();
            easyReplaceableBehaviors.LaunchUrl("https://www.google.com.tw/");
            easyReplaceableBehaviors.ToPrevPage();
            //...and so on...
        }
    }
}
