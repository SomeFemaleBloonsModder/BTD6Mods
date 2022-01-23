using Assets.Scripts.Unity;
using Assets.Scripts.Unity.UI_New.InGame;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace RaceMedalManager
{
    public class Main : MelonMod
    {
        public bool medalSwitch;
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            medalSwitch = true;
            LoggerInstance.Msg("Race Medal Manager by SomeFemaleBloonsModder\n\nHot Keys:\nF1 - Grant 1st Place Medal\nF2 - Grant 2nd Place Medal\nF3 - Grant 3rd Place Medal\nF4 - Grant Top 50 Medal\nF5 - Grant Top 1% Medal\nF6 - Grant Top 10% Medal\nF7 - Grant Top 25% Medal\nF8 - Grant Top 50% Medal\nF9 - Grant Top 75% Medal\n\nWARNING: MEDALS CANNOT BE REMOVED WITHOUT SAVE EDITS. USE AT YOUR OWN RISK.\n");
        }

        [HarmonyPostfix]
        public static void Postfix()
        {
            
        }

        public override void OnUpdate()
        {

            // Race Event - 1st
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.BlackDiamond, 1);
                LoggerInstance.Msg("Awarded Race Event - 1st");
            }

            // Race Event - 2nd
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.RedDiamond, 1);
                LoggerInstance.Msg("Awarded Race Event - 2nd");
            }

            // Race Event - 3rd
            if (Input.GetKeyDown(KeyCode.F3))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.BlueDiamond, 1);
                LoggerInstance.Msg("Awarded Race Event - 3rd");
            }

            // Race Event - Top 50
            if (Input.GetKeyDown(KeyCode.F4))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.GoldDiamond, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 50");
            }

            // Race Event - Top 1%
            if (Input.GetKeyDown(KeyCode.F5))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.DoubleGold, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 1%");
            }

            // Race Event - Top 10%
            if (Input.GetKeyDown(KeyCode.F6))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.GoldSilver, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 10%");
            }

            // Race Event - Top 25%
            if (Input.GetKeyDown(KeyCode.F7))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.DoubleSilver, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 25%");
            }

            // Race Event - Top 50%
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.Silver, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 50%");
            }

            // Race Event - Top 75%
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Game.instance.playerService.Player.AddRaceBadges(Assets.Scripts.Models.Store.Loot.LeaderboardBadgeType.Bronze, 1);
                LoggerInstance.Msg("Awarded Race Event - Top 75%");
            }

            base.OnUpdate();
        }

    }
}
