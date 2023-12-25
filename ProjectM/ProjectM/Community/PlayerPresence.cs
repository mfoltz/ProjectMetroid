// Decompiled with JetBrains decompiler
// Type: ProjectM.Community.PlayerPresence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Community
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerPresence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastUpdateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Activity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Region;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveClanMemberCount;
    [FieldOffset(0)]
    public double LastUpdateTime;
    [FieldOffset(8)]
    public PlayerActivities Activity;
    [FieldOffset(12)]
    public WorldRegionType Region;
    [FieldOffset(16)]
    public Il2CppSystem.Guid ClanId;
    [FieldOffset(32)]
    public int ActiveClanMemberCount;

    static PlayerPresence()
    {
      Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Community", nameof (PlayerPresence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr);
      PlayerPresence.NativeFieldInfoPtr_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, nameof (LastUpdateTime));
      PlayerPresence.NativeFieldInfoPtr_Activity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, nameof (Activity));
      PlayerPresence.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, nameof (Region));
      PlayerPresence.NativeFieldInfoPtr_ClanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, nameof (ClanId));
      PlayerPresence.NativeFieldInfoPtr_ActiveClanMemberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, nameof (ActiveClanMemberCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerPresence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
