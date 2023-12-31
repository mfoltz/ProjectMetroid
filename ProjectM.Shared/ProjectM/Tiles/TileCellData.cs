// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCellData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCellData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LayerMasks;
    private static readonly System.IntPtr NativeFieldInfoPtr_UniqueGameplayHeights;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileLayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticMaxLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CellBasedFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_CellBasedFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskIndexInCell;
    private static readonly System.IntPtr NativeFieldInfoPtr_CellInitialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public UnsafeList<BitMask2D_16x16> LayerMasks;
    [FieldOffset(24)]
    public UnsafeList<TileCellGameplayHeights> UniqueGameplayHeights;
    [FieldOffset(48)]
    public UnsafeList<TileLayerData> TileLayers;
    [FieldOffset(72)]
    public byte BaseHeightLevel;
    [FieldOffset(73)]
    public byte StaticMaxLevel;
    [FieldOffset(74)]
    public CellBasedFlags CellBasedFlags;
    [FieldOffset(75)]
    public byte CellBasedFlagCount;
    [FieldOffset(76)]
    public FixedList32<byte> MaskIndexInCell;
    [FieldOffset(108)]
    public bool CellInitialized;

    public unsafe bool Exists
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 792073, RefRangeEnd = 792076, XrefRangeStart = 792070, XrefRangeEnd = 792073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellData.NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int LayerCount
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 792077, RefRangeEnd = 792079, XrefRangeStart = 792076, XrefRangeEnd = 792077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCellData.NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792079, XrefRangeEnd = 792097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileCellData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileCellData()
    {
      Il2CppClassPointerStore<TileCellData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCellData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCellData>.NativeClassPtr);
      TileCellData.NativeFieldInfoPtr_LayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (LayerMasks));
      TileCellData.NativeFieldInfoPtr_UniqueGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (UniqueGameplayHeights));
      TileCellData.NativeFieldInfoPtr_TileLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (TileLayers));
      TileCellData.NativeFieldInfoPtr_BaseHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (BaseHeightLevel));
      TileCellData.NativeFieldInfoPtr_StaticMaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (StaticMaxLevel));
      TileCellData.NativeFieldInfoPtr_CellBasedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (CellBasedFlags));
      TileCellData.NativeFieldInfoPtr_CellBasedFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (CellBasedFlagCount));
      TileCellData.NativeFieldInfoPtr_MaskIndexInCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (MaskIndexInCell));
      TileCellData.NativeFieldInfoPtr_CellInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, nameof (CellInitialized));
      TileCellData.NativeMethodInfoPtr_get_Exists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, 100669697);
      TileCellData.NativeMethodInfoPtr_get_LayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, 100669698);
      TileCellData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, 100669699);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCellData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
