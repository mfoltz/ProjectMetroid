// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.PolygonRegionTriangle
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PolygonRegionTriangle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Indices;
    private static readonly System.IntPtr NativeFieldInfoPtr_Area;
    [FieldOffset(0)]
    public int3 Indices;
    [FieldOffset(12)]
    public float Area;

    static PolygonRegionTriangle()
    {
      Il2CppClassPointerStore<PolygonRegionTriangle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (PolygonRegionTriangle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonRegionTriangle>.NativeClassPtr);
      PolygonRegionTriangle.NativeFieldInfoPtr_Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionTriangle>.NativeClassPtr, nameof (Indices));
      PolygonRegionTriangle.NativeFieldInfoPtr_Area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionTriangle>.NativeClassPtr, nameof (Area));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonRegionTriangle>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
