using System;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors
{
    public abstract class Behaviors
    {
        public abstract string Version { get; }
        protected Korat Korat;

        protected Behaviors(Korat korat)
        {
            if (korat == null)
            {
                throw new ArgumentNullException("Given Korat instance should not be null.");
            }
            
            Korat = korat;
        }
    }
}
