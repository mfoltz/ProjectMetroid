// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Patch.ServerEvents
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using HarmonyLib;
using ProjectM;
using System;
using System.Diagnostics;

#nullable disable
namespace VRising.GameData.Patch
{
  internal static class ServerEvents
  {
    [field: DebuggerBrowsable]
    internal static event OnGameDataInitializedEventHandler OnGameDataInitialized;

    [HarmonyPatch(typeof (LoadPersistenceSystemV2), "SetLoadState")]
    [HarmonyPostfix]
    private static void ServerStartupStateChange_Postfix(
      ServerStartupState.State loadState,
      LoadPersistenceSystemV2 __instance)
    {
      try
      {
        if (loadState != ServerStartupState.State.SuccessfulStartup)
          return;
        OnGameDataInitializedEventHandler gameDataInitialized = ServerEvents.OnGameDataInitialized;
        if (gameDataInitialized != null)
          gameDataInitialized(__instance.World);
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
    }
  }
}
