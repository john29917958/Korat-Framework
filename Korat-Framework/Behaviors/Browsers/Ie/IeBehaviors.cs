using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Ie
{
    public class IeBehaviors : BrowserBehaviors
    {
        public override string Version => "7";

        public IeBehaviors(Korat korat) : base(korat)
        {

        }
    }
}
