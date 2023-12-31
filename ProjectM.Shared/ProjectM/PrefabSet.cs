// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabSet
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PrefabSet : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeFieldInfoPtr_Prefabs;
    private static readonly IntPtr NativeFieldInfoPtr_OtherSets;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGuid_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddPrefabsRecursive_Private_Static_Void_PrefabSet_Entity_EntityManager_HashSet_1_PrefabSet_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsInPrefabsSet_Public_Static_PrefabSetResult_BufferFromEntity_1_PrefabSetBuffer_PrefabLookupMap_PrefabGUID_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727933, RefRangeEnd = 727935, XrefRangeStart = 727933, XrefRangeEnd = 727935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGuid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabSet.NativeMethodInfoPtr_GetPrefabGuid_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747481, XrefRangeEnd = 747509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabSet.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 747529, RefRangeEnd = 747531, XrefRangeStart = 747509, XrefRangeEnd = 747529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddPrefabsRecursive(
      PrefabSet prefabSet,
      Entity targetEntity,
      EntityManager dstManager,
      HashSet<PrefabSet> checkedSets)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabSet);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &targetEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedSets);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabSet.NativeMethodInfoPtr_AddPrefabsRecursive_Private_Static_Void_PrefabSet_Entity_EntityManager_HashSet_1_PrefabSet_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 747552, RefRangeEnd = 747553, XrefRangeStart = 747531, XrefRangeEnd = 747552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabSet.PrefabSetResult IsInPrefabsSet(
      BufferFromEntity<PrefabSetBuffer> getPrefabSetBuffer,
      PrefabLookupMap prefabLookupMap,
      PrefabGUID prefabSetGUID,
      PrefabGUID prefabToCheck)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &getPrefabSetBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &prefabSetGUID;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &prefabToCheck;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabSet.NativeMethodInfoPtr_IsInPrefabsSet_Public_Static_PrefabSetResult_BufferFromEntity_1_PrefabSetBuffer_PrefabLookupMap_PrefabGUID_PrefabGUID_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabSet.PrefabSetResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747553, XrefRangeEnd = 747562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabSet()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabSet()
    {
      Il2CppClassPointerStore<PrefabSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr);
      PrefabSet.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, nameof (_Guid));
      PrefabSet.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, nameof (Prefabs));
      PrefabSet.NativeFieldInfoPtr_OtherSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, nameof (OtherSets));
      PrefabSet.NativeMethodInfoPtr_GetPrefabGuid_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, 100665823);
      PrefabSet.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, 100665824);
      PrefabSet.NativeMethodInfoPtr_AddPrefabsRecursive_Private_Static_Void_PrefabSet_Entity_EntityManager_HashSet_1_PrefabSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, 100665825);
      PrefabSet.NativeMethodInfoPtr_IsInPrefabsSet_Public_Static_PrefabSetResult_BufferFromEntity_1_PrefabSetBuffer_PrefabLookupMap_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, 100665826);
      PrefabSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabSet>.NativeClassPtr, 100665827);
    }

    public PrefabSet(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>> Prefabs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr_Prefabs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<PrefabSet> OtherSets
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr_OtherSets));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<PrefabSet>) null : new Il2CppReferenceArray<PrefabSet>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabSet.NativeFieldInfoPtr_OtherSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum PrefabSetResult
    {
      SetNotDefined,
      SetInvalid,
      NotInSet,
      InSet,
    }
  }
}
