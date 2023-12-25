// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ActiveServantMission
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ActiveServantMission
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionLengthSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionStartTimeTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissiontDataId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant3;
    [FieldOffset(0)]
    public PrefabGUID MissionID;
    [FieldOffset(4)]
    public float MissionLengthSeconds;
    [FieldOffset(8)]
    public long MissionStartTimeTicks;
    [FieldOffset(16)]
    public int MissiontDataId;
    [FieldOffset(20)]
    public NetworkId Servant1;
    [FieldOffset(28)]
    public NetworkId Servant2;
    [FieldOffset(36)]
    public NetworkId Servant3;

    static Snapshot_ActiveServantMission()
    {
      Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ActiveServantMission));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr);
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_MissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (MissionID));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_MissionLengthSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (MissionLengthSeconds));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_MissionStartTimeTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (MissionStartTimeTicks));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_MissiontDataId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (MissiontDataId));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_Servant1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (Servant1));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_Servant2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (Servant2));
      Snapshot_ActiveServantMission.NativeFieldInfoPtr_Servant3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, nameof (Servant3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ActiveServantMission>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
