// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.ActiveServantMission
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ActiveServantMission
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionStartTimeTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionLengthSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissiontDataId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Servant3;
    [FieldOffset(0)]
    public PrefabGUID MissionID;
    [FieldOffset(8)]
    public long MissionStartTimeTicks;
    [FieldOffset(16)]
    public float MissionLengthSeconds;
    [FieldOffset(20)]
    public int MissiontDataId;
    [FieldOffset(24)]
    public NetworkedEntity Servant1;
    [FieldOffset(36)]
    public NetworkedEntity Servant2;
    [FieldOffset(48)]
    public NetworkedEntity Servant3;

    static ActiveServantMission()
    {
      Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (ActiveServantMission));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr);
      ActiveServantMission.NativeFieldInfoPtr_MissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (MissionID));
      ActiveServantMission.NativeFieldInfoPtr_MissionStartTimeTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (MissionStartTimeTicks));
      ActiveServantMission.NativeFieldInfoPtr_MissionLengthSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (MissionLengthSeconds));
      ActiveServantMission.NativeFieldInfoPtr_MissiontDataId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (MissiontDataId));
      ActiveServantMission.NativeFieldInfoPtr_Servant1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (Servant1));
      ActiveServantMission.NativeFieldInfoPtr_Servant2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (Servant2));
      ActiveServantMission.NativeFieldInfoPtr_Servant3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, nameof (Servant3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActiveServantMission>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
