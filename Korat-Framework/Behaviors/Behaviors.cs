using System;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors
{
    public abstract class Behaviors<TImage>
    {
        public abstract string Version { get; }

        protected Korat Korat;
        protected TImage Images;

        protected Behaviors(Korat korat)
        {
            if (korat == null)
            {
                throw new ArgumentNullException();
            }
        }

        protected abstract TImage Load();
    }
}
