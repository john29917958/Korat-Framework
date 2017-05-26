# Korat-Framework
For designing the Korat framework.

## Analysis
The potential changes in every Korat automation project are listed [here](https://hackmd.io/s/HkMt6GogW#possible-changes).

## Demonstration
About how to easily replace behaviors and images, please look at "App/Program.cs":
```csharp
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
```

The console output should be:
```
Korat sends keys: Control, R
Korat sends string: "chrome".
Korat sends key: Return.
Korat sends key: F6.
Korat sends keys: Control, C
```
