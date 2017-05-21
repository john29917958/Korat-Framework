using System.Windows.Forms;
using Korat_Framework.Resources;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser.Chrome
{
    public class LaunchUrlBehavior : LanuchUrlBehavior
    {
        public LaunchUrlBehavior(Korat korat, BrowserImages images, string url) : base(korat, images, url)
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
