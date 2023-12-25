// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderEntryGeneratorBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TraderEntryGeneratorBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Costs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Outputs;
    private static readonly System.IntPtr NativeFieldInfoPtr_StockData;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_Static_Void_byref_BlobBuilder_byref_TraderEntryGeneratorBlob_TraderEntry_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CountCosts_Private_Static_Int32_List_1_ItemCost_List_1_SharedItemRequirementAsset_0;
    [FieldOffset(0)]
    public int Weight;
    [FieldOffset(4)]
    public BlobArray<TradeCost> Costs;
    [FieldOffset(12)]
    public BlobArray<TradeOutput> Outputs;
    [FieldOffset(20)]
    public StockData StockData;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993464, RefRangeEnd = 993466, XrefRangeStart = 993421, XrefRangeEnd = 993464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BuildBlob(
      ref BlobBuilder builder,
      ref TraderEntryGeneratorBlob item,
      TraderEntry_Editor entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref builder;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderEntryGeneratorBlob.NativeMethodInfoPtr_BuildBlob_Public_Static_Void_byref_BlobBuilder_byref_TraderEntryGeneratorBlob_TraderEntry_Editor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 993482, RefRangeEnd = 993483, XrefRangeStart = 993466, XrefRangeEnd = 993482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CountCosts(
      List<ItemCost> cost,
      List<SharedItemRequirementAsset> sharedCost)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cost);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sharedCost);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderEntryGeneratorBlob.NativeMethodInfoPtr_CountCosts_Private_Static_Int32_List_1_ItemCost_List_1_SharedItemRequirementAsset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TraderEntryGeneratorBlob()
    {
      Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderEntryGeneratorBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr);
      TraderEntryGeneratorBlob.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, nameof (Weight));
      TraderEntryGeneratorBlob.NativeFieldInfoPtr_Costs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, nameof (Costs));
      TraderEntryGeneratorBlob.NativeFieldInfoPtr_Outputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, nameof (Outputs));
      TraderEntryGeneratorBlob.NativeFieldInfoPtr_StockData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, nameof (StockData));
      TraderEntryGeneratorBlob.NativeMethodInfoPtr_BuildBlob_Public_Static_Void_byref_BlobBuilder_byref_TraderEntryGeneratorBlob_TraderEntry_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, 100676704);
      TraderEntryGeneratorBlob.NativeMethodInfoPtr_CountCosts_Private_Static_Int32_List_1_ItemCost_List_1_SharedItemRequirementAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, 100676705);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderEntryGeneratorBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
