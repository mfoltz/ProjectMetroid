// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.WorldTileFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldTileFlag
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldTile;
    private static readonly System.IntPtr NativeFieldInfoPtr_FlagIsSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
    [FieldOffset(0)]
    public int2 WorldTile;
    [FieldOffset(8)]
    public bool FlagIsSet;
    [FieldOffset(9)]
    public bool HasData;

    static WorldTileFlag()
    {
      Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (WorldTileFlag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr);
      WorldTileFlag.NativeFieldInfoPtr_WorldTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr, nameof (WorldTile));
      WorldTileFlag.NativeFieldInfoPtr_FlagIsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr, nameof (FlagIsSet));
      WorldTileFlag.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr, nameof (HasData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldTileFlag>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
