using BepInEx;
using System;
using System.ComponentModel;
using UnityEngine;
using Utilla;

namespace UmbrellaLock
{
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.3")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [Description("HauntedModMenu")]
    public class Plugin : BaseUnityPlugin
    {
        public static bool inRoom;
        public static bool umbrellaLock;

        void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            umbrellaLock = false;
        }

        void OnDisable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            umbrellaLock = true;
        }

        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            inRoom = true;
        }

        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            inRoom = false;
        }
    }
}
