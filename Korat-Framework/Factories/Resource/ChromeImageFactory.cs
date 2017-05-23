using System;
using KoratFramework.Resources.Browser;

namespace KoratFramework.Factories.Resource
{
    public class ChromeImageFactory : Factory<BrowserImages>
    {
        public override BrowserImages Make(string app)
        {
            BrowserImages images = new BrowserImages();

            if (app.Contains("0.2.149") && app.Contains("ubuntu_16.04"))
            {
                images.UrlBarIcon = "chrome-early-url-bar-ubuntu.png";
                images.PrevButton = "chrome-early-prev-ubuntu.png";
                images.NextButton = "chrome-early-next-ubuntu.png";
            }
            else if (app.Contains("60.0") && app.Contains("ubuntu_16.04"))
            {
                images.UrlBarIcon = "chrome-latest-url-bar-ubuntu.png";
                images.PrevButton = "chrome-latest-prev-ubuntu.png";
                images.NextButton = "chrome-latest-next-ubuntu.png";
            }
            else if (app.Contains("0.2.149") && app.Contains("windows_7"))
            {
                images.UrlBarIcon = "chrome-early-url-bar-win7.png";
                images.PrevButton = "chrome-early-prev-win7.png";
                images.NextButton = "chrome-early-next-win7.png";
            }
            else if (app.Contains("60.0") && app.Contains("windows_7"))
            {
                images.UrlBarIcon = "chrome-early-url-bar-win7.png";
                images.PrevButton = "chrome-latest-prev-win7.png";
                images.NextButton = "chrome-latest-next-win7.png";
            }
            else
            {
                throw new ArgumentOutOfRangeException("Given version combination not valid.");
            }

            return images;
        }
    }
}
