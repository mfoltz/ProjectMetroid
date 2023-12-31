// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.PaintedTilesForBaking
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PaintedTilesForBaking
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFlags;
    [FieldOffset(0)]
    public MapCollisionFlags CollisionFlags;

    static PaintedTilesForBaking()
    {
      Il2CppClassPointerStore<PaintedTilesForBaking>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (PaintedTilesForBaking));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintedTilesForBaking>.NativeClassPtr);
      PaintedTilesForBaking.NativeFieldInfoPtr_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintedTilesForBaking>.NativeClassPtr, nameof (CollisionFlags));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaintedTilesForBaking>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
