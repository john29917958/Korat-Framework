using System;
using KoratFramework;
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
                os.OpenApp("chrome");
                chrome.GetUrlText();
            }

            Console.Read();
        }
    }
}
