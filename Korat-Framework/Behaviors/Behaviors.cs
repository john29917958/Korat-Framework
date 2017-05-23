using System;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors
{
    public abstract class Behaviors<TImage>
    {
        public abstract string Version { get; }
        public string HostInfo { get; protected set; }

        protected Korat Korat;
        protected TImage Images;

        protected Behaviors(Korat korat, string hostInfo)
        {
            if (korat == null)
            {
                throw new ArgumentNullException();
            }

            HostInfo = hostInfo;
        }

        protected abstract TImage Load();
    }
}
