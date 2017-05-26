using System.Collections.Generic;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Os.Ubuntu
{
    public class UbuntuBehaviors : OsBehaviors
    {
        public override string Version => "14.04";

        public UbuntuBehaviors(Korat korat) : base(korat)
        {

        }

        public override void OpenApp(string appName)
        {
            OpenTerminal();
            Korat.SendString(appName);
            Korat.SendKey(Keys.Enter);
        }

        public override void OpenTerminal()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> { Keys.Control, Keys.Alt, Keys.T });
        }

        public override string Copy()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> {Keys.Control, Keys.Shift, Keys.C});
            return Clipboard.GetText();
        }
    }
}
