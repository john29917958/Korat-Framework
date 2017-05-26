using System.Collections.Generic;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Chrome
{
    public class ChromeBehaviors : BrowserBehaviors
    {
        public override string Version => "0.2.149";

        public ChromeBehaviors(Korat korat) : base(korat)
        {
            
        }

        public override void FocusUrlBar()
        {
            Korat.SendCompositeKeys(new HashSet<Keys> {Keys.Alt, Keys.D});
        }
    }
}
