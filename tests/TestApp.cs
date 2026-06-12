using Avalonia;
using Avalonia.Headless;
using HighFantasyThemePlugin.Tests;

// Registers the headless Avalonia application the [AvaloniaFact]/[AvaloniaTheory]
// attributes spin up before any test that touches a palette dictionary.
[assembly: AvaloniaTestApplication(typeof(TestApp))]

namespace HighFantasyThemePlugin.Tests;

public sealed class TestApp : Application
{
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<TestApp>().UseHeadless(new AvaloniaHeadlessPlatformOptions());
}
