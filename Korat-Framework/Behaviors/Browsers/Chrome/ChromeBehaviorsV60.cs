using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace KoratFramework.Behaviors.Browsers.Chrome
{
    public class ChromeBehaviorsV60 : ChromeBehaviors
    {
        public override string Version => "60.0";

        public ChromeBehaviorsV60(Korat korat, BehaviorPool pool) : base(korat, pool)
        {

        }

        public override void FocusUrlBar()
        {
            Korat.SendKey(Keys.F6);
        }
    }
}
