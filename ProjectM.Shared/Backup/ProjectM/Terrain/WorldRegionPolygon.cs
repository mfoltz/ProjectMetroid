// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldRegionPolygon
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Physics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldRegionPolygon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldRegion;
    private static readonly System.IntPtr NativeFieldInfoPtr_PolygonBounds;
    [FieldOffset(0)]
    public WorldRegionType WorldRegion;
    [FieldOffset(4)]
    public Aabb PolygonBounds;

    static WorldRegionPolygon()
    {
      Il2CppClassPointerStore<WorldRegionPolygon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldRegionPolygon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRegionPolygon>.NativeClassPtr);
      WorldRegionPolygon.NativeFieldInfoPtr_WorldRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRegionPolygon>.NativeClassPtr, nameof (WorldRegion));
      WorldRegionPolygon.NativeFieldInfoPtr_PolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRegionPolygon>.NativeClassPtr, nameof (PolygonBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRegionPolygon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
