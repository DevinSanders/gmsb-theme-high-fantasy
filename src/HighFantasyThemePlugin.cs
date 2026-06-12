using System.Collections.Generic;
using SoundBoard.PluginApi;

namespace HighFantasyThemePlugin;

/// <summary>
/// High Fantasy theme pack — two selectable palettes for fantasy RPG
/// sessions. Each palette appears as its own entry in the host's theme
/// dropdown, prefixed with the pack name ("High Fantasy: Tavern Hearth",
/// "High Fantasy: Deep Dungeon").
///
/// <list type="bullet">
///   <item><b>Tavern Hearth</b> (parchment &amp; ink) — reading an
///   ancient map by candlelight. Warm aged parchment cream and soft
///   sepia gray surfaces, vintage ruby red primary accent (the
///   ink-stamp colour), deep forest green for success states.</item>
///   <item><b>Deep Dungeon</b> (iron &amp; ember) — navigating a stone
///   crypt with a single torch. Cast-iron charcoal and deep slate gray
///   surfaces, glowing torchlight amber primary, magical sapphire blue
///   secondary.</item>
/// </list>
///
/// <para>Each palette is a flat set of colours; the host has no Dark/Light toggle.</para>
/// </summary>
public sealed class HighFantasyThemePlugin : IThemePlugin
{
    public string Id => "theme.high-fantasy";
    public string Name => "High Fantasy";
    public string Version => PluginVersion.OfAssembly(typeof(HighFantasyThemePlugin));
    public string Author => "Devin Sanders";
    public string Description => "Two High Fantasy palettes: Tavern Hearth (parchment & ink) and Deep Dungeon (iron & ember).";

    public void Initialize(IPluginContext context) { }
    public void Shutdown() { }

    public IEnumerable<ThemePalette> GetPalettes() => new[]
    {
        new ThemePalette("tavern-hearth", "Tavern Hearth",
            new[] { "avares://HighFantasyThemePlugin/Themes/TavernHearth.axaml" }),
        new ThemePalette("deep-dungeon",  "Deep Dungeon",
            new[] { "avares://HighFantasyThemePlugin/Themes/DeepDungeon.axaml" }),
    };
}
