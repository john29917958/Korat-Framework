using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser.Chrome
{
    public class LaunchUrlBehavior : LanuchUrlBehavior
    {
        public LaunchUrlBehavior(Korat korat, string url) : base(korat, url)
        {

        }

        public override void Execute()
        {
            Korat.SendKey(Keys.F6);
            Korat.SendString(Url);
            Korat.SendKey(Keys.Enter);
        }
    }
}
