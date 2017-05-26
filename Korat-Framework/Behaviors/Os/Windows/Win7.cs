using System.Collections.Generic;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Os.Windows
{
    public class Win7 : OsBehaviors
    {
        public override string Version => "7";

        public Win7(Korat korat) : base(korat)
        {

        }
        
        public override void OpenApp(string appName)
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.R });
            Korat.SendString(appName);
        }

        public override void OpenTerminal()
        {
            OpenApp("cmd.exe");
        }
    }
}
