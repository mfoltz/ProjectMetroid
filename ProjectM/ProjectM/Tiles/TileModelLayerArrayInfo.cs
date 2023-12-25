// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelLayerArrayInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelLayerArrayInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LAYER_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbyssStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbyssCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_PropStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_PropCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeStartIndexes_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAndReturnIndex_Public_Int32_TileModelLayerEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCount_Public_Void_TileModelLayerEnum_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStartIndex_Public_Void_TileModelLayerEnum_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerStartAndCount_Public_Void_TileModelLayerEnum_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public int AbyssStart;
    [FieldOffset(4)]
    public int AbyssCount;
    [FieldOffset(8)]
    public int TerrainStart;
    [FieldOffset(12)]
    public int TerrainCount;
    [FieldOffset(16)]
    public int FloorStart;
    [FieldOffset(20)]
    public int FloorCount;
    [FieldOffset(24)]
    public int PropStart;
    [FieldOffset(28)]
    public int PropCount;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086038, RefRangeEnd = 1086039, XrefRangeStart = 1086038, XrefRangeEnd = 1086038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeStartIndexes(int entityCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_InitializeStartIndexes_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086039, RefRangeEnd = 1086040, XrefRangeStart = 1086039, XrefRangeEnd = 1086039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int AddAndReturnIndex(TileModelLayerEnum layer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &layer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_AddAndReturnIndex_Public_Int32_TileModelLayerEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void SetCount(TileModelLayerEnum layer, int count)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_SetCount_Public_Void_TileModelLayerEnum_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetStartIndex(TileModelLayerEnum layer, int startIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_SetStartIndex_Public_Void_TileModelLayerEnum_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1086040, RefRangeEnd = 1086044, XrefRangeStart = 1086040, XrefRangeEnd = 1086040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetLayerStartAndCount(
      TileModelLayerEnum layer,
      out int start,
      out int count)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &layer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_GetLayerStartAndCount_Public_Void_TileModelLayerEnum_byref_Int32_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086044, XrefRangeEnd = 1086079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileModelLayerArrayInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileModelLayerArrayInfo()
    {
      Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelLayerArrayInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr);
      TileModelLayerArrayInfo.NativeFieldInfoPtr_LAYER_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (LAYER_COUNT));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_AbyssStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (AbyssStart));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_AbyssCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (AbyssCount));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_TerrainStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (TerrainStart));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_TerrainCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (TerrainCount));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_FloorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (FloorStart));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_FloorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (FloorCount));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_PropStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (PropStart));
      TileModelLayerArrayInfo.NativeFieldInfoPtr_PropCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, nameof (PropCount));
      TileModelLayerArrayInfo.NativeMethodInfoPtr_InitializeStartIndexes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685548);
      TileModelLayerArrayInfo.NativeMethodInfoPtr_AddAndReturnIndex_Public_Int32_TileModelLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685549);
      TileModelLayerArrayInfo.NativeMethodInfoPtr_SetCount_Public_Void_TileModelLayerEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685550);
      TileModelLayerArrayInfo.NativeMethodInfoPtr_SetStartIndex_Public_Void_TileModelLayerEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685551);
      TileModelLayerArrayInfo.NativeMethodInfoPtr_GetLayerStartAndCount_Public_Void_TileModelLayerEnum_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685552);
      TileModelLayerArrayInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, 100685553);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelLayerArrayInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int LAYER_COUNT
    {
      get
      {
        int layerCount;
        IL2CPP.il2cpp_field_static_get_value(TileModelLayerArrayInfo.NativeFieldInfoPtr_LAYER_COUNT, (void*) &layerCount);
        return layerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileModelLayerArrayInfo.NativeFieldInfoPtr_LAYER_COUNT, (void*) &value);
      }
    }
  }
}
