using System;
using Korat_Framework.Resources.Browser;

namespace Korat_Framework.Resources
{
    public static class ImageFactory
    {
        public static BrowserImages Make(string app)
        {
            BrowserImages images = new BrowserImages();

            if (app.Contains("chrome_0.2.149") && app.Contains("ubuntu_16.04"))
            {
                images.PrevButton = "chrome-early-prev-ubuntu.png";
                images.NextButton = "chrome-early-next-ubuntu.png";
            }
            else if (app.Contains("chrome_60.0") && app.Contains("ubuntu_16.04"))
            {
                images.PrevButton = "chrome-latest-prev-ubuntu.png";
                images.NextButton = "chrome-latest-next-ubuntu.png";
            }
            else if (app.Contains("chrome_0.2.149") && app.Contains("windows_7"))
            {
                images.PrevButton = "chrome-early-prev-win7.png";
                images.NextButton = "chrome-early-next-win7.png";
            }
            else if (app.Contains("chrome_60.0") && app.Contains("windows_7"))
            {
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
