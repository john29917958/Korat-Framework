using System;
using KoratFramework;
using KoratFramework.Behaviors.Browsers;
using KoratFramework.Behaviors.Browsers.Chrome;
using KoratFramework.Behaviors.Os;
using KoratFramework.Pickers.Behaviors.Browser;
using KoratFramework.Pickers.Behaviors.Os;
using Ncu.Oolab.Korat.Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Korat korat = new Korat();

            // Constructs behavior pool by "BehaviorPool pool = Parser.Parse(args)" in the future.
            BehaviorPool pool = new BehaviorPool();
            pool.Add(new WinBehaviorsPicker(korat, pool).Pick("7"));
            pool.Add(new ChromeBehaviorsPicker(korat, pool).Pick("60.0"));
            
            ChromeBehaviors chrome = pool.Request<ChromeBehaviors>();
            OsBehaviors os = pool.Request<OsBehaviors>();

            if (chrome == null || os == null)
            {
                Console.WriteLine("No such behaviors.");
            }
            else
            {
                Console.WriteLine("Before replacing behaviors:");
                RunScript(os, chrome);
            }

            pool.Remove(os);
            pool.Remove(chrome);
            pool.Add(new IeBehaviorsPicker(korat, pool).Pick("ie7"));
            pool.Add(new UbuntuBehaviorsPicker(korat, pool).Pick("16.10"));
            BrowserBehaviors browser = pool.Request<BrowserBehaviors>();
            os = pool.Request<OsBehaviors>();
            
            if (browser == null || os == null)
            {
                Console.WriteLine("No such behaviors.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("After replacing behaviors:");
                RunScript(os, browser);
            }

            Console.Read();
        }

        /// <summary>
        /// Script never changed.
        /// </summary>
        /// <param name="os"></param>
        /// <param name="browser"></param>
        private static void RunScript(OsBehaviors os, BrowserBehaviors browser)
        {
            os.OpenApp("chrome");
            string url = browser.GetUrlText();
        }
    }
}
