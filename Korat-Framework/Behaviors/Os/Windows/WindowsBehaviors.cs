using System.Collections.Generic;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Os.Windows
{
    public class WindowsBehaviors : OsBehaviors
    {
        public override string Version => "7";

        public WindowsBehaviors(Korat korat) : base(korat)
        {

        }
        
        public override void OpenApp(string appName)
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.R });
            Korat.SendString(appName);
            Korat.SendKey(Keys.Enter);
        }

        public override void OpenTerminal()
        {
            OpenApp("cmd.exe");
        }

        public override string Copy()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.C });
            return Clipboard.GetText();
        }
    }
}
