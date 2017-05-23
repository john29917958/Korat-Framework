using System;
using KoratFramework.Resources.Browser;

namespace KoratFramework.Factories.Resource
{
    public class IeFactory : Factory<BrowserImages>
    {
        public override BrowserImages Make(string app)
        {
            BrowserImages images = new BrowserImages();

            if (app.Contains("7") && app.Contains("win7"))
            {
                images.UrlBarIcon = "ie-7-url-bar-win7.png";
                images.PrevButton = "ie-7-prev-win7.png";
                images.NextButton = "ie-7-next-win7.png";
            }
            else if (app.Contains("7") && app.Contains("win10"))
            {
                images.UrlBarIcon = "ie-7-url-bar-win10.png";
                images.PrevButton = "ie-7-prev-win10.png";
                images.NextButton = "ie-7-next-win10.png";
            }
            else if (app.Contains("Edge") && app.Contains("win10"))
            {
                images.UrlBarIcon = "edge-url-bar-win10.png";
                images.PrevButton = "edge-prev-win10.png";
                images.NextButton = "edge-next-win10.png";
            }
            else
            {
                throw new ArgumentOutOfRangeException("Given version combination not valid.");
            }

            return images;
        }
    }
}
