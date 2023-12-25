// Decompiled with JetBrains decompiler
// Type: ProjectM.FindBlobAssetsInPrefabs
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FindBlobAssetsInPrefabs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SupportedBlobSourceFields;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExcludedComponentTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlobAssetPointersForEntity_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlobAssetPointers_Private_Void_byref_TypeInfo_ptr_EntityOffsetInfo_ptr_Byte_Int32_Entity_0;
    [FieldOffset(0)]
    public NativeHashSet<PersistenceV2Utility.SupportedBlobField> SupportedBlobSourceFields;
    [FieldOffset(16)]
    public NativeBitArray ExcludedComponentTypes;
    [FieldOffset(32)]
    public PrefabLookupMap PrefabLookupMap;
    [FieldOffset(80)]
    public EntityManager EntityManager;
    [FieldOffset(88)]
    public NativeList<PersistentBlobMetadata> Result;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058290, XrefRangeEnd = 1058310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FindBlobAssetsInPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1058325, RefRangeEnd = 1058327, XrefRangeStart = 1058310, XrefRangeEnd = 1058325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddBlobAssetPointersForEntity(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FindBlobAssetsInPrefabs.NativeMethodInfoPtr_AddBlobAssetPointersForEntity_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1058335, RefRangeEnd = 1058337, XrefRangeStart = 1058327, XrefRangeEnd = 1058335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddBlobAssetPointers(
      [In] ref TypeManager.TypeInfo typeInfo,
      TypeManager.EntityOffsetInfo* blobOffsets,
      byte* componentPointer,
      int elementIndex,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref typeInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) blobOffsets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) componentPointer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &elementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FindBlobAssetsInPrefabs.NativeMethodInfoPtr_AddBlobAssetPointers_Private_Void_byref_TypeInfo_ptr_EntityOffsetInfo_ptr_Byte_Int32_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FindBlobAssetsInPrefabs()
    {
      Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FindBlobAssetsInPrefabs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr);
      FindBlobAssetsInPrefabs.NativeFieldInfoPtr_SupportedBlobSourceFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, nameof (SupportedBlobSourceFields));
      FindBlobAssetsInPrefabs.NativeFieldInfoPtr_ExcludedComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, nameof (ExcludedComponentTypes));
      FindBlobAssetsInPrefabs.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, nameof (PrefabLookupMap));
      FindBlobAssetsInPrefabs.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, nameof (EntityManager));
      FindBlobAssetsInPrefabs.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, nameof (Result));
      FindBlobAssetsInPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, 100683084);
      FindBlobAssetsInPrefabs.NativeMethodInfoPtr_AddBlobAssetPointersForEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, 100683085);
      FindBlobAssetsInPrefabs.NativeMethodInfoPtr_AddBlobAssetPointers_Private_Void_byref_TypeInfo_ptr_EntityOffsetInfo_ptr_Byte_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, 100683086);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FindBlobAssetsInPrefabs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
