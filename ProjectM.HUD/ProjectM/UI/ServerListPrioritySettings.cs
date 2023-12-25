// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListPrioritySettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerListPrioritySettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviouslyPlayedWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlayingWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedDaysWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedPlayersWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_LatencyWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinLatency;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLatency;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumRecPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaximumRecPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumRecMaxPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaximumRecMaxPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedPlayersRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRecommendedDays;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowActivityWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MediumActivityWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardSettingsWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_WithinRecommendedMaxPlayersWeight;
    [FieldOffset(0)]
    public GameModeTypeFilter GameModeType;
    [FieldOffset(4)]
    public float PreviouslyPlayedWeight;
    [FieldOffset(8)]
    public float FriendsPlayingWeight;
    [FieldOffset(12)]
    public float RecommendedDaysWeight;
    [FieldOffset(16)]
    public float RecommendedPlayersWeight;
    [FieldOffset(20)]
    public float LatencyWeight;
    [FieldOffset(24)]
    public float MinLatency;
    [FieldOffset(28)]
    public float MaxLatency;
    [FieldOffset(32)]
    public int MinimumRecPlayers;
    [FieldOffset(36)]
    public int MaximumRecPlayers;
    [FieldOffset(40)]
    public int MinimumRecMaxPlayers;
    [FieldOffset(44)]
    public int MaximumRecMaxPlayers;
    [FieldOffset(48)]
    public float RecommendedPlayersRatio;
    [FieldOffset(52)]
    public int MaxRecommendedDays;
    [FieldOffset(56)]
    public float LowActivityWeight;
    [FieldOffset(60)]
    public float MediumActivityWeight;
    [FieldOffset(64)]
    public float StandardSettingsWeight;
    [FieldOffset(68)]
    public float WithinRecommendedMaxPlayersWeight;

    static ServerListPrioritySettings()
    {
      Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListPrioritySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr);
      ServerListPrioritySettings.NativeFieldInfoPtr_GameModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (GameModeType));
      ServerListPrioritySettings.NativeFieldInfoPtr_PreviouslyPlayedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (PreviouslyPlayedWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_FriendsPlayingWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (FriendsPlayingWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_RecommendedDaysWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (RecommendedDaysWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_RecommendedPlayersWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (RecommendedPlayersWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_LatencyWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (LatencyWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_MinLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MinLatency));
      ServerListPrioritySettings.NativeFieldInfoPtr_MaxLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MaxLatency));
      ServerListPrioritySettings.NativeFieldInfoPtr_MinimumRecPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MinimumRecPlayers));
      ServerListPrioritySettings.NativeFieldInfoPtr_MaximumRecPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MaximumRecPlayers));
      ServerListPrioritySettings.NativeFieldInfoPtr_MinimumRecMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MinimumRecMaxPlayers));
      ServerListPrioritySettings.NativeFieldInfoPtr_MaximumRecMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MaximumRecMaxPlayers));
      ServerListPrioritySettings.NativeFieldInfoPtr_RecommendedPlayersRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (RecommendedPlayersRatio));
      ServerListPrioritySettings.NativeFieldInfoPtr_MaxRecommendedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MaxRecommendedDays));
      ServerListPrioritySettings.NativeFieldInfoPtr_LowActivityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (LowActivityWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_MediumActivityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (MediumActivityWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_StandardSettingsWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (StandardSettingsWeight));
      ServerListPrioritySettings.NativeFieldInfoPtr_WithinRecommendedMaxPlayersWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, nameof (WithinRecommendedMaxPlayersWeight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListPrioritySettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
