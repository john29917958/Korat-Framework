using System;
using System.Windows.Forms;
using Ncu.Oolab.Korat.Library;

namespace Korat_Framework.Behaviors.Browser.IE
{
    public sealed class LaunchUrlBehavior : LanuchUrlBehavior
    {
        private readonly string _urlBar;

        public LaunchUrlBehavior(Korat korat, string url, string urlBar) : base(korat, url)
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
