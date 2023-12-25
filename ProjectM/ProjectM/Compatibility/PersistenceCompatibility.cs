// Decompiled with JetBrains decompiler
// Type: ProjectM.Compatibility.PersistenceCompatibility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Compatibility
{
  public static class PersistenceCompatibility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateHeader_Public_Static_Boolean_World_ApplicationType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_Il2CppStructArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadHeader_Private_Static_PersistenceCompatibilityData_Stream_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateGameDataCollection_Private_Static_GameDataCollection_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabInformations_Private_Static_Dictionary_2_PrefabGUID_PrefabInformation_World_PrefabLookupMap_NativeHashMap_2_PrefabGUID_ConvertedAssetData_NativeBitArray_HashSet_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateComponentInformation_Private_Static_ComponentInformation_Boolean_byref_TypeInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeIdentifier_Private_Static_String_byref_TypeInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntityArchetype_Private_Static_PersistentEntityArchetype_World_Entity_NativeBitArray_HashSet_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateWorldData_Private_Static_WorldData_World_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1110528, RefRangeEnd = 1110529, XrefRangeStart = 1110496, XrefRangeEnd = 1110528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryCreateHeader(
      World world,
      ApplicationType applicationType,
      string targetPath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &applicationType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_TryCreateHeader_Public_Static_Boolean_World_ApplicationType_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110529, XrefRangeEnd = 1110534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData LoadHeader(Il2CppStructArray<byte> data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityData) null : new PersistenceCompatibilityData(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1110536, RefRangeEnd = 1110538, XrefRangeStart = 1110534, XrefRangeEnd = 1110536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData LoadHeader(string targetPath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityData) null : new PersistenceCompatibilityData(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1110553, RefRangeEnd = 1110555, XrefRangeStart = 1110538, XrefRangeEnd = 1110553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData LoadHeader(Stream streamReader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) streamReader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Private_Static_PersistenceCompatibilityData_Stream_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityData) null : new PersistenceCompatibilityData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1110614, RefRangeEnd = 1110615, XrefRangeStart = 1110555, XrefRangeEnd = 1110614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.GameDataCollection TryCreateGameDataCollection(
      World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_TryCreateGameDataCollection_Private_Static_GameDataCollection_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.GameDataCollection(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1110673, RefRangeEnd = 1110674, XrefRangeStart = 1110615, XrefRangeEnd = 1110673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation> GetPrefabInformations(
      World world,
      PrefabLookupMap prefabLookupMap,
      NativeHashMap<PrefabGUID, ConvertedAssetData> prefabDataLookup,
      NativeBitArray excludeComponentTypes,
      HashSet<int> nonPersistentRequiredComponents)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabDataLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponentTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nonPersistentRequiredComponents);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_GetPrefabInformations_Private_Static_Dictionary_2_PrefabGUID_PrefabInformation_World_PrefabLookupMap_NativeHashMap_2_PrefabGUID_ConvertedAssetData_NativeBitArray_HashSet_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation>) null : new Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1110680, RefRangeEnd = 1110682, XrefRangeStart = 1110674, XrefRangeEnd = 1110680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.ComponentInformation CreateComponentInformation(
      bool persistent,
      [In] ref TypeManager.TypeInfo typeInfo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &persistent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref typeInfo;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_CreateComponentInformation_Private_Static_ComponentInformation_Boolean_byref_TypeInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.ComponentInformation(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1110687, RefRangeEnd = 1110689, XrefRangeStart = 1110682, XrefRangeEnd = 1110687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetTypeIdentifier([In] ref TypeManager.TypeInfo typeInfo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref typeInfo;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_GetTypeIdentifier_Private_Static_String_byref_TypeInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1110736, RefRangeEnd = 1110738, XrefRangeStart = 1110689, XrefRangeEnd = 1110736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.PersistentEntityArchetype CreateEntityArchetype(
      World world,
      Entity entity,
      NativeBitArray excludeComponentTypes,
      HashSet<int> nonPersistentRequiredComponents)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponentTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nonPersistentRequiredComponents);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_CreateEntityArchetype_Private_Static_PersistentEntityArchetype_World_Entity_NativeBitArray_HashSet_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.PersistentEntityArchetype(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1110816, RefRangeEnd = 1110817, XrefRangeStart = 1110738, XrefRangeEnd = 1110816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.WorldData TryCreateWorldData(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibility.NativeMethodInfoPtr_TryCreateWorldData_Private_Static_WorldData_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.WorldData(pointer);
    }

    static PersistenceCompatibility()
    {
      Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Compatibility", nameof (PersistenceCompatibility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr);
      PersistenceCompatibility.NativeMethodInfoPtr_TryCreateHeader_Public_Static_Boolean_World_ApplicationType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687925);
      PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687926);
      PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Public_Static_PersistenceCompatibilityData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687927);
      PersistenceCompatibility.NativeMethodInfoPtr_LoadHeader_Private_Static_PersistenceCompatibilityData_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687928);
      PersistenceCompatibility.NativeMethodInfoPtr_TryCreateGameDataCollection_Private_Static_GameDataCollection_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687929);
      PersistenceCompatibility.NativeMethodInfoPtr_GetPrefabInformations_Private_Static_Dictionary_2_PrefabGUID_PrefabInformation_World_PrefabLookupMap_NativeHashMap_2_PrefabGUID_ConvertedAssetData_NativeBitArray_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687930);
      PersistenceCompatibility.NativeMethodInfoPtr_CreateComponentInformation_Private_Static_ComponentInformation_Boolean_byref_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687931);
      PersistenceCompatibility.NativeMethodInfoPtr_GetTypeIdentifier_Private_Static_String_byref_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687932);
      PersistenceCompatibility.NativeMethodInfoPtr_CreateEntityArchetype_Private_Static_PersistentEntityArchetype_World_Entity_NativeBitArray_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687933);
      PersistenceCompatibility.NativeMethodInfoPtr_TryCreateWorldData_Private_Static_WorldData_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibility>.NativeClassPtr, 100687934);
    }

    public PersistenceCompatibility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
