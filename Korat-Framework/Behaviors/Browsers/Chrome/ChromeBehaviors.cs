using KoratFramework.Factories.Resource;
using KoratFramework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Chrome
{
    public class ChromeBehaviors : BrowserBehaviors
    {
        public override string Version => "0.2.149";

        public ChromeBehaviors(Korat korat) : base(korat)
        {
            Images = Load();
        }

        protected sealed override BrowserImages Load()
        {
            return new ChromeImageFactory().Make(Version + "ubuntu_16.04");
        }
    }
}
