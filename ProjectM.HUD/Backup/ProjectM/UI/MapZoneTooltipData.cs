// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapZoneTooltipData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneTooltipData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneBounds;
    [FieldOffset(0)]
    public Entity ZoneEntity;
    [FieldOffset(8)]
    public MapZoneData ZoneData;
    [FieldOffset(124)]
    public Bounds ZoneBounds;

    static MapZoneTooltipData()
    {
      Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapZoneTooltipData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr);
      MapZoneTooltipData.NativeFieldInfoPtr_ZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr, nameof (ZoneEntity));
      MapZoneTooltipData.NativeFieldInfoPtr_ZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr, nameof (ZoneData));
      MapZoneTooltipData.NativeFieldInfoPtr_ZoneBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr, nameof (ZoneBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneTooltipData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
