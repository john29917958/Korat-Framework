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

        BrowserBehaviors behaviors = new BrowserBehaviorFactory(korat).Make("Chrome 60.0 ubuntu_16.04");
        behaviors.FocusUrlBar();
        behaviors.LaunchUrl("https://www.google.com.tw/");
        //...and so on...

        BrowserBehaviors easyReplaceableBehaviors = new BrowserBehaviorFactory(korat).Make("IE edge win10");
        easyReplaceableBehaviors.FocusUrlBar();
        easyReplaceableBehaviors.LaunchUrl("https://www.google.com.tw/");
        easyReplaceableBehaviors.ToPrevPage();
        //...and so on...
    }
}
```
