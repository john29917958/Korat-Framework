using System;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors
{
    public abstract class Behaviors
    {
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
