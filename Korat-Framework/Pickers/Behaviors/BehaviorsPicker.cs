using System;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers.Behaviors
{
    public abstract class BehaviorsPicker<T> where T : KoratFramework.Behaviors.Behaviors
    {
        protected Korat Korat;
        protected BehaviorPool Pool;

        protected BehaviorsPicker(Korat korat, BehaviorPool pool)
        {
            if (korat == null)
            {
                throw new ArgumentNullException("Given Korat instance should not be null.");
            }

            if (pool == null)
            {
                throw new ArgumentNullException("Given Pool instance should not be null.");
            }

            Korat = korat;
            Pool = pool;
        }

        public abstract T Pick(string version);

        protected abstract bool GreaterOrEquals(string version, string benchmark);
    }
}
