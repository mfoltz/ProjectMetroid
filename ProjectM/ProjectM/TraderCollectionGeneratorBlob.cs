// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderCollectionGeneratorBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TraderCollectionGeneratorBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCountRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_TraderEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_Static_BlobAssetReference_1_TraderCollectionGeneratorBlob_TraderItemCollectionAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Void_EntityManager_Entity_StructData_byref_Random_0;
    [FieldOffset(0)]
    public int2 ItemCountRange;
    [FieldOffset(8)]
    public BlobArray<TraderEntryGeneratorBlob> TraderEntries;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993339, XrefRangeEnd = 993357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlobAssetReference<TraderCollectionGeneratorBlob> BuildBlob(
      TraderItemCollectionAsset collection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderCollectionGeneratorBlob.NativeMethodInfoPtr_BuildBlob_Public_Static_BlobAssetReference_1_TraderCollectionGeneratorBlob_TraderItemCollectionAsset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<TraderCollectionGeneratorBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993419, RefRangeEnd = 993421, XrefRangeStart = 993357, XrefRangeEnd = 993419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Generate(
      EntityManager entityManager,
      Entity entity,
      TraderModifiers.StructData traderModifiers,
      ref Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &traderModifiers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderCollectionGeneratorBlob.NativeMethodInfoPtr_Generate_Public_Void_EntityManager_Entity_StructData_byref_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderCollectionGeneratorBlob()
    {
      Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderCollectionGeneratorBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr);
      TraderCollectionGeneratorBlob.NativeFieldInfoPtr_ItemCountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr, nameof (ItemCountRange));
      TraderCollectionGeneratorBlob.NativeFieldInfoPtr_TraderEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr, nameof (TraderEntries));
      TraderCollectionGeneratorBlob.NativeMethodInfoPtr_BuildBlob_Public_Static_BlobAssetReference_1_TraderCollectionGeneratorBlob_TraderItemCollectionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr, 100676702);
      TraderCollectionGeneratorBlob.NativeMethodInfoPtr_Generate_Public_Void_EntityManager_Entity_StructData_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr, 100676703);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderCollectionGeneratorBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
