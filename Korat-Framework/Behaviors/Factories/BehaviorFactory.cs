using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Factories
{
    public abstract class BehaviorFactory<T> where T : Behaviors
    {
        public abstract T Make(Korat korat, string version);
    }
}
