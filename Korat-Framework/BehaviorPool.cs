using System;
using System.Collections.Generic;

namespace KoratFramework
{
    public class BehaviorPool
    {
        private readonly List<Behaviors.Behaviors> _behaviorsPool;

        public BehaviorPool()
        {
            _behaviorsPool = new List<Behaviors.Behaviors>();
        }

        public bool HasBehaviorsType<T>() where T : Behaviors.Behaviors
        {
            foreach (Behaviors.Behaviors behaviors in _behaviorsPool)
            {
                if (behaviors is T)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Add<T>(T behaviors) where T : Behaviors.Behaviors
        {
            if (behaviors == null)
            {
                throw new ArgumentNullException("Given behaviors should not be null.");
            }

            if (!HasBehaviorsType<T>())
            {
                _behaviorsPool.Add(behaviors);
                return true;
            }

            return false;
        }

        public bool Remove(Behaviors.Behaviors behaviors)
        {
            return _behaviorsPool.Remove(behaviors);
        }

        public T Request<T>() where T : Behaviors.Behaviors
        {
            foreach (Behaviors.Behaviors behaviors in _behaviorsPool)
            {
                T actualBehaviors = behaviors as T;

                if (actualBehaviors != null)
                {
                    return actualBehaviors;
                }
            }

            return null;
        }
    }
}
