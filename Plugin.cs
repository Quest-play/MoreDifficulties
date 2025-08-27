using BepInEx;
using BepInEx.Logging;
using Gatekeeper.PoolScripts;
using Gatekeeper.Utility;
using GKAPI;
using GKAPI.Difficulties;
using GKAPI.Enemies;
using UnityEngine;

namespace ExampleMod;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency(GKAPI.Plugin.PluginGuid)]
public class Plugin : GkPlugin
{
    public const string PluginGuid = "ua.quest_play.moredifficulties";
    public const string PluginName = "More Difficulties";
    private const string PluginVersion = "0.1.0";
    
    internal new static ManualLogSource Log;

    public override void Load()
    {
        base.Load();
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    public override void AddContent()
    {
        if (EventHandler.State != EventHandler.LoadingState.PreInit)
        {
            Log.LogError("Content has to be added during Pre-Init!");
            return;
        }

        GlobalSettings.Instance.buildCheating = true;
        GlobalSettings.Instance.buildDebugConsole = true;

        var diffAPI = DifficultiesAPI.Instance;
        var enemiesAPI = EnemiesAPI.Instance;

        var (gd, diff) = diffAPI.AddDifficulty(new GkDifficulty.Builder()
            .WithName("Insanity")
            .WithDifficultyValues("400%", 1.8f, 5f)
            .WithGameEventsData(0, 2, 1, diffAPI.CreateGameEventsProbabilities(0.25f))
            .WithSirenSpawnData(5, 10)
            .WithEliteSpawnData(0.17f, 0.06f, 0.35f, 0.09f, 5, 3, 2)
            .WithInstabilityCapsuleSpeed(3)
            .WithColors(new Color(0.4f, 0.1f, 0.8f), new Color(0.4f, 0.3f, 0.8f))
            .WithExpLoopPow(2f)
            .WithExpPoints(35, 210, 60)
            .WithArenaValues(1.6f, 10, 1.6f, 0.8f, -40, 150)
        );
        
         
    }
}
