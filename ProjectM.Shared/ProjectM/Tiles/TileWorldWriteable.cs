// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileWorldWriteable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileWorldWriteable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldCells;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldCellCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsReadonlyTileWorld_Public_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeArray<TileCellData> WorldCells;
    [FieldOffset(16)]
    public int2 WorldCellCount;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 792786, RefRangeEnd = 792790, XrefRangeStart = 792786, XrefRangeEnd = 792786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorld AsReadonlyTileWorld()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldWriteable.NativeMethodInfoPtr_AsReadonlyTileWorld_Public_TileWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792790, XrefRangeEnd = 792796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldWriteable.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileWorldWriteable()
    {
      Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileWorldWriteable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr);
      TileWorldWriteable.NativeFieldInfoPtr_WorldCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr, nameof (WorldCells));
      TileWorldWriteable.NativeFieldInfoPtr_WorldCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr, nameof (WorldCellCount));
      TileWorldWriteable.NativeMethodInfoPtr_AsReadonlyTileWorld_Public_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr, 100669800);
      TileWorldWriteable.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr, 100669801);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileWorldWriteable>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
