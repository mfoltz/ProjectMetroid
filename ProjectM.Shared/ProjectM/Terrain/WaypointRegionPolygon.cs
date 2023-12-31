// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WaypointRegionPolygon
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WaypointRegionPolygon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_PolygonBounds;
    [FieldOffset(0)]
    public float3 WaypointPosition;
    [FieldOffset(12)]
    public Aabb PolygonBounds;

    static WaypointRegionPolygon()
    {
      Il2CppClassPointerStore<WaypointRegionPolygon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WaypointRegionPolygon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointRegionPolygon>.NativeClassPtr);
      WaypointRegionPolygon.NativeFieldInfoPtr_WaypointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointRegionPolygon>.NativeClassPtr, nameof (WaypointPosition));
      WaypointRegionPolygon.NativeFieldInfoPtr_PolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointRegionPolygon>.NativeClassPtr, nameof (PolygonBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WaypointRegionPolygon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
