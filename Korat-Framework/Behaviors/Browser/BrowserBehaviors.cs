using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public class BrowserBehaviors : Behaviors
    {
        public LanuchUrlBehavior LanuchUrl { get; set; }
        public PrevPageBehavior ToPreviousPage { get; set; }

        public BrowserBehaviors(Korat korat) : base(korat)
        {

        }
    }
}
