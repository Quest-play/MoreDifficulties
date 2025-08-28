using System;
using BepInEx.Logging;
using Gatekeeper.General.Predictor;
using Gatekeeper.PoolScripts;
using GKAPI.Enemies;
using UnityEngine;

namespace MoreDifficulties.Utility;

public class Templates
{
    private readonly ManualLogSource _log;

    public Templates(ManualLogSource manualLogSource)
    {
        _log = manualLogSource;
    }
    public void registerInsanityPool(GameDifficulty difficulty, EnemiesAPI enemiesAPI)
    {
        // Aurora
        var probAurora1Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyGrouch, 0.05f)
            .AddItem(PoolItemID.EnemyVice, 0.1f)
            .AddItem(PoolItemID.EnemyLumer, 0.25f)
            .AddItem(PoolItemID.EnemySentry, 0.23f)
            .AddItem(PoolItemID.EnemyMount, 0.28f)
            .AddItem(PoolItemID.EnemyLucidEthel, 0.08f)
            .AddItem(PoolItemID.EnemyKeeperS1, 0.01f)
        .Build();

        var probAurora2Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyGrouch, 0.01f)
            .AddItem(PoolItemID.EnemyVice, 0.02f)
            .AddItem(PoolItemID.EnemyLumer, 0.2f)
            .AddItem(PoolItemID.EnemySentry, 0.32f)
            .AddItem(PoolItemID.EnemyMount, 0.34f)
            .AddItem(PoolItemID.EnemyLucidEthel, 0.10f)
            .AddItem(PoolItemID.EnemyKeeperS1, 0.01f)
        .Build();

        var probAurora3Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyGrouch, 0.01f)
            .AddItem(PoolItemID.EnemyVice, 0.01f)
            .AddItem(PoolItemID.EnemyLumer, 0.14f)
            .AddItem(PoolItemID.EnemySentry, 0.34f)
            .AddItem(PoolItemID.EnemyMount, 0.35f)
            .AddItem(PoolItemID.EnemyLucidEthel, 0.14f)
            .AddItem(PoolItemID.EnemyKeeperS1, 0.01f)
        .Build();

        // Celestium
        var probCelestium1Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyKinetic, 0.18f)
            .AddItem(PoolItemID.EnemyWindsHerald, 0.19f)
            .AddItem(PoolItemID.EnemyHeartless, 0.22f)
            .AddItem(PoolItemID.EnemyCrystalGuard, 0.18f)
            .AddItem(PoolItemID.EnemyMaluard, 0.19f)
            .AddItem(PoolItemID.EnemyInitiator, 0.04f)
        .Build();

        var probCelestium2Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyKinetic, 0.06f)
            .AddItem(PoolItemID.EnemyWindsHerald, 0.08f)
            .AddItem(PoolItemID.EnemyHeartless, 0.1f)
            .AddItem(PoolItemID.EnemyCrystalGuard, 0.35f)
            .AddItem(PoolItemID.EnemyMaluard, 0.30f)
            .AddItem(PoolItemID.EnemyInitiator, 0.10f)
            .AddItem(PoolItemID.EnemyIdol, 0.01f)
        .Build();

        var probCelestium3Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyKinetic, 0.04f)
            .AddItem(PoolItemID.EnemyWindsHerald, 0.06f)
            .AddItem(PoolItemID.EnemyHeartless, 0.06f)
            .AddItem(PoolItemID.EnemyCrystalGuard, 0.35f)
            .AddItem(PoolItemID.EnemyMaluard, 0.33f)
            .AddItem(PoolItemID.EnemyInitiator, 0.15f)
            .AddItem(PoolItemID.EnemyIdol, 0.01f)
        .Build();

        // Purgatory
        var probPurgatory1Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyDoomed, 0.17f)
            .AddItem(PoolItemID.EnemyDeadrunner, 0.12f)
            .AddItem(PoolItemID.EnemyEidolon, 0.12f)
            .AddItem(PoolItemID.EnemyHermit, 0.16f)
            .AddItem(PoolItemID.EnemyFiendSkull, 0.19f)
            .AddItem(PoolItemID.EnemyGrenadier, 0.20f)
            .AddItem(PoolItemID.EnemyDamnedSpellcaster, 0.04f)
        .Build();

        var probPurgatory2Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyDoomed, 0.03f)
            .AddItem(PoolItemID.EnemyDeadrunner, 0.08f)
            .AddItem(PoolItemID.EnemyEidolon, 0.09f)
            .AddItem(PoolItemID.EnemyHermit, 0.19f)
            .AddItem(PoolItemID.EnemyFiendSkull, 0.28f)
            .AddItem(PoolItemID.EnemyGrenadier, 0.16f)
            .AddItem(PoolItemID.EnemyDamnedSpellcaster, 0.17f)
        .Build();

        var probPurgatory3Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyDeadrunner, 0.08f)
            .AddItem(PoolItemID.EnemyEidolon, 0.09f)
            .AddItem(PoolItemID.EnemyHermit, 0.15f)
            .AddItem(PoolItemID.EnemyFiendSkull, 0.28f)
            .AddItem(PoolItemID.EnemyGrenadier, 0.20f)
            .AddItem(PoolItemID.EnemyDamnedSpellcaster, 0.20f)
        .Build();

        // Aridune
        var probAridune1Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyRattle, 0.16f)
            .AddItem(PoolItemID.EnemyToxic, 0.17f)
            .AddItem(PoolItemID.EnemyThorn, 0.12f)
            .AddItem(PoolItemID.EnemyDrought, 0.18f)
            .AddItem(PoolItemID.EnemyHowler, 0.08f)
            .AddItem(PoolItemID.EnemyWanderer, 0.25f)
            .AddItem(PoolItemID.EnemyQuake, 0.04f)
        .Build();

        var probAridune2Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyRattle, 0.04f)
            .AddItem(PoolItemID.EnemyToxic, 0.09f)
            .AddItem(PoolItemID.EnemyThorn, 0.09f)
            .AddItem(PoolItemID.EnemyDrought, 0.28f)
            .AddItem(PoolItemID.EnemyHowler, 0.10f)
            .AddItem(PoolItemID.EnemyWanderer, 0.30f)
            .AddItem(PoolItemID.EnemyQuake, 0.10f)
        .Build();

        var probAridune3Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyRattle, 0.03f)
            .AddItem(PoolItemID.EnemyToxic, 0.08f)
            .AddItem(PoolItemID.EnemyThorn, 0.09f)
            .AddItem(PoolItemID.EnemyDrought, 0.28f)
            .AddItem(PoolItemID.EnemyHowler, 0.09f)
            .AddItem(PoolItemID.EnemyWanderer, 0.28f)
            .AddItem(PoolItemID.EnemyQuake, 0.15f)
        .Build();

        // Palium
        var probPalium1Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyMourn, 0.18f)
            .AddItem(PoolItemID.EnemyCaveCreeper, 0.12f)
            .AddItem(PoolItemID.EnemyGnash, 0.09f)
            .AddItem(PoolItemID.EnemyAshling, 0.15f)
            .AddItem(PoolItemID.EnemyCaldeon, 0.12f)
            .AddItem(PoolItemID.EnemyHulk, 0.15f)
            .AddItem(PoolItemID.EnemyEmberling, 0.15f)
            .AddItem(PoolItemID.EnemyInferna, 0.04f)
        .Build();

        var probPalium2Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyMourn, 0.11f)
            .AddItem(PoolItemID.EnemyCaveCreeper, 0.12f)
            .AddItem(PoolItemID.EnemyGnash, 0.09f)
            .AddItem(PoolItemID.EnemyAshling, 0.20f)
            .AddItem(PoolItemID.EnemyCaldeon, 0.12f)
            .AddItem(PoolItemID.EnemyHulk, 0.13f)
            .AddItem(PoolItemID.EnemyEmberling, 0.13f)
            .AddItem(PoolItemID.EnemyInferna, 0.10f)
        .Build();

        var probPalium3Loop = new TemplateHelper.ProbListBuilder()
            .AddItem(PoolItemID.EnemyMourn, 0.03f)
            .AddItem(PoolItemID.EnemyCaveCreeper, 0.04f)
            .AddItem(PoolItemID.EnemyGnash, 0.08f)
            .AddItem(PoolItemID.EnemyAshling, 0.30f)
            .AddItem(PoolItemID.EnemyCaldeon, 0.12f)
            .AddItem(PoolItemID.EnemyHulk, 0.12f)
            .AddItem(PoolItemID.EnemyEmberling, 0.13f)
            .AddItem(PoolItemID.EnemyInferna, 0.18f)
        .Build();

        //Register Pools
        try
        {
            // Aurora
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AuroraScenes, new Vector2Int(1, 5), probAurora1Loop, "EST_1XX 1Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AuroraScenes, new Vector2Int(6, 11), probAurora2Loop, "EST_1XX 2Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AuroraScenes, new Vector2Int(12, -1), probAurora3Loop, "EST_1XX 3Loop_500");

            // Celestium
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.CelestiumScenes, new Vector2Int(1, 5), probCelestium1Loop, "EST_2XX 1Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.CelestiumScenes, new Vector2Int(6, 11), probCelestium2Loop, "EST_2XX 2Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.CelestiumScenes, new Vector2Int(12, -1), probCelestium3Loop, "EST_2XX 3Loop_500");

            // Purgatory
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PurgatoryScenes, new Vector2Int(1, 5), probPurgatory1Loop, "EST_3XX 1Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PurgatoryScenes, new Vector2Int(6, 11), probPurgatory2Loop, "EST_3XX 2Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PurgatoryScenes, new Vector2Int(12, -1), probPurgatory3Loop, "EST_3XX 3Loop_500");

            // Aridune
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AriduneScenes, new Vector2Int(1, 5), probAridune1Loop, "EST_4XX 1Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AriduneScenes, new Vector2Int(6, 11), probAridune2Loop, "EST_4XX 2Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.AriduneScenes, new Vector2Int(12, -1), probAridune3Loop, "EST_4XX 3Loop_500");
            // Palium
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PaliumScenes, new Vector2Int(1, 5), probPalium1Loop, "EST_5XX 1Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PaliumScenes, new Vector2Int(6, 11), probPalium2Loop, "EST_5XX 2Loop_500");
            enemiesAPI.AddKnowingTemplate(difficulty, true, TemplateHelper.PaliumScenes, new Vector2Int(12, -1), probPalium3Loop, "EST_5XX 3Loop_500");

            _log.LogInfo("Successfully registered enemy templates for Insanity difficulty.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _log.LogError($"Failed to register enemy templates for Insanity difficulty: {e}");
            throw;
        }
    }
}
