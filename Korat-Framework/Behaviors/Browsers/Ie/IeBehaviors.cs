using KoratFramework.Factories.Resource;
using KoratFramework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Ie
{
    public class IeBehaviors : BrowserBehaviors
    {
        public override string Version => "7";

        public IeBehaviors(Korat korat) : base(korat)
        {
            Images = Load();
        }
        
        protected sealed override BrowserImages Load()
        {
            return new IeImageFactory().Make(Version + "win7");
        }
    }
}
