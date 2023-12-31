// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastUpdatedDisabledTileTypes;
    [FieldOffset(0)]
    public ProjectM.TileType DisabledTileTypes;
    [FieldOffset(1)]
    public ProjectM.TileType LastUpdatedDisabledTileTypes;

    static TileModel()
    {
      Il2CppClassPointerStore<TileModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileModel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModel>.NativeClassPtr);
      TileModel.NativeFieldInfoPtr_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModel>.NativeClassPtr, nameof (DisabledTileTypes));
      TileModel.NativeFieldInfoPtr_LastUpdatedDisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModel>.NativeClassPtr, nameof (LastUpdatedDisabledTileTypes));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
