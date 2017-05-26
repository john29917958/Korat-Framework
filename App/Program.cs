using System;
using KoratFramework;
using KoratFramework.Behaviors.Browsers.Chrome;
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
            BehaviorPool pool = new BehaviorPool();
            pool.Add(new WinBehaviorsPicker(korat, pool).Pick("7"));
            pool.Add(new ChromeBehaviorsPicker(korat, pool).Pick("60.0"));
            ChromeBehaviors chrome = pool.Request<ChromeBehaviors>();
            if (chrome == null)
            {
                Console.WriteLine("No such behaviors.");
            }
            else
            {
                chrome.FocusUrlBar();
            }
            Console.Read();
        }
    }
}
