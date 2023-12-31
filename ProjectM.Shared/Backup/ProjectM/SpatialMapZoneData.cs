// Decompiled with JetBrains decompiler
// Type: ProjectM.SpatialMapZoneData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpatialMapZoneData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneEntity;
    [FieldOffset(0)]
    public BoundsMinMax WorldBounds;
    [FieldOffset(16)]
    public MapZoneFlags ZoneFlags;
    [FieldOffset(20)]
    public MapZoneId ZoneId;
    [FieldOffset(32)]
    public Entity ZoneEntity;

    static SpatialMapZoneData()
    {
      Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpatialMapZoneData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr);
      SpatialMapZoneData.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr, nameof (WorldBounds));
      SpatialMapZoneData.NativeFieldInfoPtr_ZoneFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr, nameof (ZoneFlags));
      SpatialMapZoneData.NativeFieldInfoPtr_ZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr, nameof (ZoneId));
      SpatialMapZoneData.NativeFieldInfoPtr_ZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr, nameof (ZoneEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpatialMapZoneData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
