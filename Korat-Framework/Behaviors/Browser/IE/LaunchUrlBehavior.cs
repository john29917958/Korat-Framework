using System;
using System.Windows.Forms;
using Korat_Framework.Resources;
using Korat_Framework.Resources.Browser;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser.IE
{
    public sealed class LaunchUrlBehavior : LanuchUrlBehavior
    {
        private readonly string _urlBar;

        public LaunchUrlBehavior(Korat korat, BrowserImages images, string url, string urlBar) : base(korat, images, url)
        {
            if (string.IsNullOrWhiteSpace(urlBar))
            {
                throw new ArgumentException("URL bar image should be given.");
            }

            _urlBar = urlBar;
        }

        public override void Execute()
        {
            Korat.Click(_urlBar);
            Korat.SendString(Url);
            Korat.SendKey(Keys.Enter);
        }
    }
}
