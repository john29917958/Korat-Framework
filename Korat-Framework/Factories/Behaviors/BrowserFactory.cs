using System;
using KoratFramework.Behaviors.Browsers;
using KoratFramework.Behaviors.Browsers.Chrome;
using KoratFramework.Behaviors.Browsers.Ie;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Factories.Behaviors
{
    public class BrowserBehaviorFactory : Factory<BrowserBehaviors>
    {
        protected Korat Korat;

        public BrowserBehaviorFactory(Korat korat)
        {
            if (korat == null)
            {
                throw new ArgumentNullException("Given Korat instance should not be null.");
            }

            Korat = korat;
        }

        public override BrowserBehaviors Make(string version)
        {
            if (version.Contains("Chrome"))
            {
                version = version.Replace("Chrome", string.Empty).Trim();

                switch (version)
                {
                    case "0.2.149":
                        return new ChromeBehaviors(Korat);
                    case "60.0":
                        return new ChromeBehaviorsV60(Korat);
                    default:
                        throw new ArgumentOutOfRangeException("Not specified app version.");
                }
            }

            if (version.Contains("IE"))
            {
                version = version.Replace("IE", string.Empty).Trim();

                switch (version)
                {
                    case "7":
                        return new IeBehaviors(Korat);
                    case "edge":
                        return new Edge(Korat);
                    default:
                        throw new ArgumentOutOfRangeException("Not specified app version.");
                }
            }

            throw new ArgumentOutOfRangeException("Not specified app version.");
        }
    }
}
