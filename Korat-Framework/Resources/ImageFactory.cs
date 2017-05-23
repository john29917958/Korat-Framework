using System;
using Korat_Framework.Behaviors;
using Korat_Framework.Resources.Browser;

namespace Korat_Framework.Resources
{
    public static class ImageFactory
    {
        public static BrowserImages Make(AppVersions app)
        {
            BrowserImages images = new BrowserImages();

            switch (app)
            {
                case AppVersions.Chrome0_2_149:
                    images.PrevButton = "chrome-prev.png";
                    images.NextButton = "chrome-next.png";
                    return images;
                case AppVersions.Chrome60_0:
                    images.PrevButton = "chrome60-prev.png";
                    images.NextButton = "chrome60-next.png";
                    return images;
                case AppVersions.IE7:
                    images.PrevButton = "ie7-prev.png";
                    images.NextButton = "ie7-next.png";
                    return images;
                case AppVersions.IE8:
                    images.PrevButton = "ie8-prev.png";
                    images.NextButton = "ie8-next.png";
                    return images;
                default:
                    throw new ArgumentException("Version not allowed.");
            }
        }
    }
}
