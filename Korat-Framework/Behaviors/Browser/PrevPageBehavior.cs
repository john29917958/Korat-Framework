using System;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public class PrevPageBehavior : Behavior
    {
        protected string PrevIcon;

        public PrevPageBehavior(Korat korat, string prevIcon) : base(korat)
        {
            if (string.IsNullOrWhiteSpace(prevIcon))
            {
                throw new ArgumentException("Prev page icon should be given.");
            }

            PrevIcon = prevIcon;
        }

        public override void Execute()
        {
            Korat.Click(PrevIcon);
        }
    }
}
