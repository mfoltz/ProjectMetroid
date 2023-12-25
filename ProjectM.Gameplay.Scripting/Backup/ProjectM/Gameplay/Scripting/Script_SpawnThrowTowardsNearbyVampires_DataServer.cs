// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SpawnThrowTowardsNearbyVampires_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SpawnThrowTowardsNearbyVampires_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ThrowType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaximumCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountPerTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerId;
    [FieldOffset(0)]
    public PrefabGUID ThrowType;
    [FieldOffset(4)]
    public int MaximumCount;
    [FieldOffset(8)]
    public int CountPerTarget;
    [FieldOffset(12)]
    public float Radius;
    [FieldOffset(16)]
    public float OffsetMin;
    [FieldOffset(20)]
    public float OffsetMax;
    [FieldOffset(24)]
    public HitFilter HitFilter;
    [FieldOffset(28)]
    public TriggerId TriggerId;

    static Script_SpawnThrowTowardsNearbyVampires_DataServer()
    {
      Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SpawnThrowTowardsNearbyVampires_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr);
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_ThrowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (ThrowType));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_MaximumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (MaximumCount));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_CountPerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (CountPerTarget));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (Radius));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_OffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (OffsetMin));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_OffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (OffsetMax));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (HitFilter));
      Script_SpawnThrowTowardsNearbyVampires_DataServer.NativeFieldInfoPtr_TriggerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, nameof (TriggerId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SpawnThrowTowardsNearbyVampires_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
