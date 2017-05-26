﻿using System;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Pickers
{
    public abstract class BehaviorsPicker<T> where T : Behaviors.Behaviors
    {
        protected Korat Korat;

        protected BehaviorsPicker(Korat korat)
        {
            if (korat == null)
            {
                throw new ArgumentNullException("Given Korat instance should not be null.");
            }

            Korat = korat;
        }

        public abstract T Pick(string version);
    }
}
