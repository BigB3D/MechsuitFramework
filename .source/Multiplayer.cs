using System;
using Multiplayer.API;
using Verse;


namespace Exosuit.MultiplayerCompatibility;


[StaticConstructorOnStartup]
public static class Multiplayer
{
    static Multiplayer()
    {
        try
        {
            if (!MP.enabled) return;
            MP.RegisterAll();
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to initialize Multiplayer support for Exosuit Framework in Multiplayer.cs: {ex.Message}");
        }
    }
}
