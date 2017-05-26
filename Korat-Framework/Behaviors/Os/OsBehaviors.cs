using System.Collections.Generic;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Os
{
    public abstract class OsBehaviors : Behaviors
    {
        protected OsBehaviors(Korat korat) : base(korat)
        {

        }

        public abstract void OpenApp(string appName);

        public abstract void OpenTerminal();

        public virtual void CloseApp()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Alt, Keys.F4 });
        }

        public abstract string Copy();
    }
}
