// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.CellIntersection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CellIntersection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CellCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalCellBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntersectedWorldBounds;
    [FieldOffset(0)]
    public TileCellCoordinate CellCoordinate;
    [FieldOffset(8)]
    public BoundsMinMax LocalCellBounds;
    [FieldOffset(24)]
    public BoundsMinMax IntersectedWorldBounds;

    static CellIntersection()
    {
      Il2CppClassPointerStore<CellIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (CellIntersection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellIntersection>.NativeClassPtr);
      CellIntersection.NativeFieldInfoPtr_CellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIntersection>.NativeClassPtr, nameof (CellCoordinate));
      CellIntersection.NativeFieldInfoPtr_LocalCellBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIntersection>.NativeClassPtr, nameof (LocalCellBounds));
      CellIntersection.NativeFieldInfoPtr_IntersectedWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIntersection>.NativeClassPtr, nameof (IntersectedWorldBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellIntersection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
