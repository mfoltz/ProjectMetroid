// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Patch.ClientEvents
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using HarmonyLib;
using ProjectM;
using ProjectM.Auth;
using System;
using System.Diagnostics;

#nullable disable
namespace VRising.GameData.Patch
{
  internal class ClientEvents
  {
    private static bool _onGameDataInitializedTriggered;

    [field: DebuggerBrowsable]
    internal static event OnGameDataInitializedEventHandler OnGameDataInitialized;

    [field: DebuggerBrowsable]
    internal static event OnGameDataDestroyedEventHandler OnGameDataDestroyed;

    [HarmonyPatch(typeof (GameDataManager), "OnUpdate")]
    [HarmonyPostfix]
    private static void GameDataManagerOnUpdatePostfix(GameDataManager __instance)
    {
      if (ClientEvents._onGameDataInitializedTriggered)
        return;
      try
      {
        if (!__instance.GameDataInitialized)
          return;
        ClientEvents._onGameDataInitializedTriggered = true;
        Debug.WriteLine("GameDataManagerOnUpdatePostfix Trigger");
        OnGameDataInitializedEventHandler gameDataInitialized = ClientEvents.OnGameDataInitialized;
        if (gameDataInitialized == null)
          return;
        gameDataInitialized(__instance.World);
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
    }

    [HarmonyPatch(typeof (ClientBootstrapSystem), "OnDestroy")]
    [HarmonyPostfix]
    private static void ClientBootstrapSystemOnDestroyPostfix(ClientBootstrapSystem __instance)
    {
      ClientEvents._onGameDataInitializedTriggered = false;
      try
      {
        OnGameDataDestroyedEventHandler gameDataDestroyed = ClientEvents.OnGameDataDestroyed;
        if (gameDataDestroyed == null)
          return;
        gameDataDestroyed();
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
    }

    [HarmonyPatch(typeof (SteamPlatformSystem), "TryInitClient")]
    [HarmonyPostfix]
    private static void SteamPlatformSystemOnTryInitClientPostfix(SteamPlatformSystem __instance)
    {
      try
      {
        VRising.GameData.Users.CurrentUserSteamId = __instance.UserID;
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
    }
  }
}
