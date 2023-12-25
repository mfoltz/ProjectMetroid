// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BakedBoundsBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BakedBoundsBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_LayersLocation;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerStartAndCountWithinBounds_Public_Void_TileModelLayerEnum_BoundsMinMax_byref_Int32_byref_Int32_0;
    [FieldOffset(0)]
    public BlobArray<BoundsMinMax> Bounds;
    [FieldOffset(8)]
    public TileModelLayerArrayInfo LayersLocation;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1086086, RefRangeEnd = 1086090, XrefRangeStart = 1086079, XrefRangeEnd = 1086086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetLayerStartAndCountWithinBounds(
      TileModelLayerEnum layer,
      BoundsMinMax boundsInChunkSpace,
      out int start,
      out int count)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boundsInChunkSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BakedBoundsBlob.NativeMethodInfoPtr_GetLayerStartAndCountWithinBounds_Public_Void_TileModelLayerEnum_BoundsMinMax_byref_Int32_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BakedBoundsBlob()
    {
      Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (BakedBoundsBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr);
      BakedBoundsBlob.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr, nameof (Bounds));
      BakedBoundsBlob.NativeFieldInfoPtr_LayersLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr, nameof (LayersLocation));
      BakedBoundsBlob.NativeMethodInfoPtr_GetLayerStartAndCountWithinBounds_Public_Void_TileModelLayerEnum_BoundsMinMax_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr, 100685554);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakedBoundsBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
