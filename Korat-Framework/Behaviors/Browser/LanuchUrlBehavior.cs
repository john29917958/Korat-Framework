using System;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser
{
    public abstract class LanuchUrlBehavior : Behavior
    {
        protected string Url;

        protected LanuchUrlBehavior(Korat korat, string url) : base(korat)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Given URL should be specified.");
            }

            Url = url;
        }
    }
}
