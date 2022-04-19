using System;
using System.Collections.Generic;
using HarmonyLib;

namespace UmbrellaLock.Patches
{

    [HarmonyPatch(typeof(UmbrellaItem))]
    [HarmonyPatch("OnActivate", MethodType.Normal)]
    class OnActivatePatch
    {
        public static bool Prefix()
        {
            return Plugin.umbrellaLock;
        }
    }
}
