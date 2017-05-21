using System;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors
{
    public abstract class Behavior
    {
        protected Korat Korat;

        protected Behavior(Korat korat)
        {
            if (korat == null)
            {
                throw new ArgumentNullException("Korat instance should not be null");
            }

            Korat = korat;
        }

        public abstract void Execute();
    }
}
