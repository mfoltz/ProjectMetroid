// Decompiled with JetBrains decompiler
// Type: VRising.GameData.GameData
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Diagnostics;
using Unity.Entities;
using UnityEngine;
using VRising.GameData.Patch;

#nullable disable
namespace VRising.GameData
{
  public static class GameData
  {
    private static bool _initialized;
    private static bool _worldDataInitialized;
    private const string NotInitializedError = "GameData is not initialized";
    public static bool IsServer = Application.productName == "VRisingServer";
    public static bool IsClient = Application.productName == "VRising";
    private static World _world;
    private static Harmony _harmonyInstance;
    internal static ManualLogSource Logger = BepInEx.Logging.Logger.CreateLogSource("VRising.GameData");

    static GameData() => VRising.GameData.GameData.Create();

    public static GameVersionData GameVersion => GameVersionUtils.GetVersionData();

    [field: DebuggerBrowsable]
    public static event OnGameDataInitializedEventHandler OnInitialize;

    [field: DebuggerBrowsable]
    public static event OnGameDataDestroyedEventHandler OnDestroy;

    public static World World
    {
      get => VRising.GameData.GameData._world ?? throw new InvalidOperationException("GameData is not initialized");
    }

    public static Systems Systems
    {
      get
      {
        if (!VRising.GameData.GameData._worldDataInitialized)
          throw new InvalidOperationException("GameData is not initialized");
        return Systems.Instance;
      }
    }

    public static Users Users
    {
      get
      {
        if (!VRising.GameData.GameData._worldDataInitialized)
          throw new InvalidOperationException("GameData is not initialized");
        return Users.Instance;
      }
    }

    public static Items Items
    {
      get
      {
        if (!VRising.GameData.GameData._worldDataInitialized)
          throw new InvalidOperationException("GameData is not initialized");
        return Items.Instance;
      }
    }

    public static Npcs Npcs
    {
      get
      {
        if (!VRising.GameData.GameData._worldDataInitialized)
          throw new InvalidOperationException("GameData is not initialized");
        return Npcs.Instance;
      }
    }

    public static bool Initialized => VRising.GameData.GameData._worldDataInitialized;

    internal static void Create()
    {
      if (VRising.GameData.GameData._initialized)
        return;
      VRising.GameData.GameData._initialized = true;
      VRising.GameData.GameData._harmonyInstance = new Harmony("VRising.GameData");
      if (VRising.GameData.GameData.IsClient)
      {
        VRising.GameData.GameData._harmonyInstance.PatchAll(typeof (ClientEvents));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ClientEvents.OnGameDataInitialized += VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized ?? (VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized = new OnGameDataInitializedEventHandler(VRising.GameData.GameData.OnGameDataInitialized));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ClientEvents.OnGameDataDestroyed += VRising.GameData.GameData.\u003C\u003EO.\u003C1\u003E__OnGameDataDestroyed ?? (VRising.GameData.GameData.\u003C\u003EO.\u003C1\u003E__OnGameDataDestroyed = new OnGameDataDestroyedEventHandler(VRising.GameData.GameData.OnGameDataDestroyed));
      }
      if (!VRising.GameData.GameData.IsServer)
        return;
      VRising.GameData.GameData._harmonyInstance.PatchAll(typeof (ServerEvents));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      ServerEvents.OnGameDataInitialized += VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized ?? (VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized = new OnGameDataInitializedEventHandler(VRising.GameData.GameData.OnGameDataInitialized));
    }

    internal static void Destroy()
    {
      VRising.GameData.GameData.OnInitialize = (OnGameDataInitializedEventHandler) null;
      if (VRising.GameData.GameData.IsClient)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ClientEvents.OnGameDataInitialized -= VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized ?? (VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized = new OnGameDataInitializedEventHandler(VRising.GameData.GameData.OnGameDataInitialized));
      }
      if (VRising.GameData.GameData.IsServer)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ServerEvents.OnGameDataInitialized -= VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized ?? (VRising.GameData.GameData.\u003C\u003EO.\u003C0\u003E__OnGameDataInitialized = new OnGameDataInitializedEventHandler(VRising.GameData.GameData.OnGameDataInitialized));
      }
      VRising.GameData.GameData._harmonyInstance.UnpatchSelf();
      VRising.GameData.GameData._harmonyInstance = (Harmony) null;
    }

    private static void OnGameDataDestroyed()
    {
      VRising.GameData.GameData._world = (World) null;
      VRising.GameData.GameData._worldDataInitialized = false;
      OnGameDataDestroyedEventHandler onDestroy = VRising.GameData.GameData.OnDestroy;
      if (onDestroy != null)
        onDestroy();
      if (VRising.GameData.GameData.OnDestroy == null)
        return;
      foreach (Delegate invocation in VRising.GameData.GameData.OnDestroy.GetInvocationList())
      {
        try
        {
          invocation.DynamicInvoke();
        }
        catch (Exception ex)
        {
          VRising.GameData.GameData.Logger.LogError((object) ex);
        }
      }
    }

    private static void OnGameDataInitialized(World world)
    {
      VRising.GameData.GameData._world = world;
      VRising.GameData.GameData._worldDataInitialized = true;
      if (VRising.GameData.GameData.OnInitialize == null)
        return;
      foreach (Delegate invocation in VRising.GameData.GameData.OnInitialize.GetInvocationList())
      {
        try
        {
          invocation.DynamicInvoke((object) world);
        }
        catch (Exception ex)
        {
          VRising.GameData.GameData.Logger.LogError((object) ex);
        }
      }
      VRising.GameData.GameData.Logger.LogInfo((object) "GameData initialized");
    }
  }
}
