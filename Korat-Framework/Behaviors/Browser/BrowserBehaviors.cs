using System;
using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public class BrowserBehaviors : Behaviors
    {
        protected BrowserBehavior Images;

        public LanuchUrlBehavior LanuchUrl { get; set; }
        public PrevPageBehavior ToPreviousPage { get; set; }

        public BrowserBehaviors(Korat korat) : base(korat)
        {

        }
    }
}
