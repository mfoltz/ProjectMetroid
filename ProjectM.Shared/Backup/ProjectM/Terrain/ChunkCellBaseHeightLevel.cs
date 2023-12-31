// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkCellBaseHeightLevel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkCellBaseHeightLevel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightLevel;
    [FieldOffset(0)]
    public byte BaseHeightLevel;
    [FieldOffset(1)]
    public byte MaxHeightLevel;

    static ChunkCellBaseHeightLevel()
    {
      Il2CppClassPointerStore<ChunkCellBaseHeightLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkCellBaseHeightLevel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkCellBaseHeightLevel>.NativeClassPtr);
      ChunkCellBaseHeightLevel.NativeFieldInfoPtr_BaseHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellBaseHeightLevel>.NativeClassPtr, nameof (BaseHeightLevel));
      ChunkCellBaseHeightLevel.NativeFieldInfoPtr_MaxHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellBaseHeightLevel>.NativeClassPtr, nameof (MaxHeightLevel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkCellBaseHeightLevel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
