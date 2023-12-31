// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.PersistenceV2Utility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  public static class PersistenceV2Utility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CustomHandledTypeData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExcludedAssemblies;
    private static readonly System.IntPtr NativeFieldInfoPtr__CustomExcludedManagedTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExcludedComponentTypes_Public_Static_NativeBitArray_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExcludedFieldsByComponent_Public_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFieldsWithAttributeByComponent_Private_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsToRemoveFromArchetype_Public_Static_NativeBitArray_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentTypesThatExcludeArchetypes_Public_Static_NativeBitArray_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTypesToLogErrorFor_Public_Static_NativeBitArray_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTypeFlag_Private_Static_Void_Type_NativeBitArray_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportedBlobTypesForRemapping_Public_Static_HashSet_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindTypeFieldsWithBlobAssetRemappingSupport_Public_Static_Void_NativeBitArray_Allocator_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindRecursiveSupportedBlobFields_Private_Static_Void_ComponentType_Type_Int32_HashSet_1_Type_NativeHashSet_1_SupportedBlobField_NativeHashSet_1_SupportedBlobField_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFromExcludedAssembly_Public_Static_Boolean_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCustomExcluded_Public_Static_Boolean_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_Type_ExcludePersistenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_String_ExcludePersistenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_Type_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_Type_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetType_Private_Static_Boolean_String_byref_Type_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeAssembly_Private_Static_Void_String_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 797318, RefRangeEnd = 797322, XrefRangeStart = 797227, XrefRangeEnd = 797318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeBitArray GetExcludedComponentTypes(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetExcludedComponentTypes_Public_Static_NativeBitArray_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeBitArray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797328, RefRangeEnd = 797329, XrefRangeStart = 797322, XrefRangeEnd = 797328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute>>> GetExcludedFieldsByComponent()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetExcludedFieldsByComponent_Public_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute>>>) null : new Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<PersistenceV2.ExcludeFieldAttribute>>>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797357, RefRangeEnd = 797358, XrefRangeStart = 797329, XrefRangeEnd = 797357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<T>>> GetFieldsWithAttributeByComponent<T>() where T : Il2CppSystem.Attribute
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.MethodInfoStoreGeneric_GetFieldsWithAttributeByComponent_Private_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<T>>>) null : new Dictionary<int, List<PersistenceV2Utility.FieldWithAttribute<T>>>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797437, RefRangeEnd = 797439, XrefRangeStart = 797358, XrefRangeEnd = 797437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeBitArray GetComponentsToRemoveFromArchetype(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetComponentsToRemoveFromArchetype_Public_Static_NativeBitArray_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeBitArray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797494, RefRangeEnd = 797496, XrefRangeStart = 797439, XrefRangeEnd = 797494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeBitArray GetComponentTypesThatExcludeArchetypes(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetComponentTypesThatExcludeArchetypes_Public_Static_NativeBitArray_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeBitArray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797596, RefRangeEnd = 797598, XrefRangeStart = 797496, XrefRangeEnd = 797596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeBitArray GetTypesToLogErrorFor(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetTypesToLogErrorFor_Public_Static_NativeBitArray_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeBitArray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 797605, RefRangeEnd = 797614, XrefRangeStart = 797598, XrefRangeEnd = 797605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTypeFlag(Il2CppSystem.Type type, NativeBitArray excludedTypes, bool exclude)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludedTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &exclude;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetTypeFlag_Private_Static_Void_Type_NativeBitArray_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797614, XrefRangeEnd = 797639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe HashSet<Il2CppSystem.Type> GetSupportedBlobTypesForRemapping()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_GetSupportedBlobTypesForRemapping_Public_Static_HashSet_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797694, RefRangeEnd = 797696, XrefRangeStart = 797639, XrefRangeEnd = 797694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindTypeFieldsWithBlobAssetRemappingSupport(
      NativeBitArray excludeComponentTypes,
      Allocator allocator,
      out NativeHashSet<PersistenceV2Utility.SupportedBlobField> out_supportedBlobSourceFields,
      out NativeHashSet<PersistenceV2Utility.SupportedBlobField> out_supportedRemappableBlobFields)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &excludeComponentTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref out_supportedBlobSourceFields;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref out_supportedRemappableBlobFields;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_FindTypeFieldsWithBlobAssetRemappingSupport_Public_Static_Void_NativeBitArray_Allocator_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 797723, RefRangeEnd = 797725, XrefRangeStart = 797696, XrefRangeEnd = 797723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindRecursiveSupportedBlobFields(
      ComponentType parentType,
      Il2CppSystem.Type type,
      int fieldOffset,
      HashSet<Il2CppSystem.Type> supportedBlobTypes,
      NativeHashSet<PersistenceV2Utility.SupportedBlobField> out_supportedBlobSourceFields,
      NativeHashSet<PersistenceV2Utility.SupportedBlobField> out_supportedRemappableBlobFields)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &parentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) supportedBlobTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &out_supportedBlobSourceFields;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &out_supportedRemappableBlobFields;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_FindRecursiveSupportedBlobFields_Private_Static_Void_ComponentType_Type_Int32_HashSet_1_Type_NativeHashSet_1_SupportedBlobField_NativeHashSet_1_SupportedBlobField_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 797735, RefRangeEnd = 797738, XrefRangeStart = 797725, XrefRangeEnd = 797735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFromExcludedAssembly(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_IsFromExcludedAssembly_Public_Static_Boolean_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797738, XrefRangeEnd = 797746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsCustomExcluded(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_IsCustomExcluded_Public_Static_Boolean_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 797764, RefRangeEnd = 797769, XrefRangeStart = 797746, XrefRangeEnd = 797764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomExcludeComponent(
      Il2CppSystem.Type type,
      ExcludePersistenceOptions excludeComponent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_Type_ExcludePersistenceOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 797778, RefRangeEnd = 797782, XrefRangeStart = 797769, XrefRangeEnd = 797778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomExcludeComponent(
      string typeStr,
      ExcludePersistenceOptions excludeComponent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeComponent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_String_ExcludePersistenceOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 797803, RefRangeEnd = 797813, XrefRangeStart = 797782, XrefRangeEnd = 797803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomComponentExcludesArchetype(Il2CppSystem.Type type, bool excludeArchetype = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeArchetype;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_Type_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 797822, RefRangeEnd = 797825, XrefRangeStart = 797813, XrefRangeEnd = 797822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomComponentExcludesArchetype(
      string typeStr,
      bool excludeArchetype = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeArchetype;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(52)]
    [CachedScanResults(RefRangeStart = 797843, RefRangeEnd = 797895, XrefRangeStart = 797825, XrefRangeEnd = 797843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomExcludeAndLogErrorIfTypeSaved(Il2CppSystem.Type type, bool logError)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logError;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_Type_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 797904, RefRangeEnd = 797908, XrefRangeStart = 797895, XrefRangeEnd = 797904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCustomExcludeAndLogErrorIfTypeSaved(string typeStr, bool logError)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logError;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 798295, RefRangeEnd = 798298, XrefRangeStart = 797908, XrefRangeEnd = 798295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetType(
      string typeStr,
      out Il2CppSystem.Type type,
      string errorHeader = "PersistenceV2Utility",
      bool logError = true)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(errorHeader);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &logError;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_TryGetType_Private_Static_Boolean_String_byref_Type_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Type local = ref type;
      System.IntPtr pointer = zero;
      Il2CppSystem.Type type1 = pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      local = type1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 798310, RefRangeEnd = 798327, XrefRangeStart = 798298, XrefRangeEnd = 798310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ExcludeAssembly(string assemblyName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.NativeMethodInfoPtr_ExcludeAssembly_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceV2Utility()
    {
      Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (PersistenceV2Utility));
      PersistenceV2Utility.NativeFieldInfoPtr__CustomHandledTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, nameof (_CustomHandledTypeData));
      PersistenceV2Utility.NativeFieldInfoPtr__ExcludedAssemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, nameof (_ExcludedAssemblies));
      PersistenceV2Utility.NativeFieldInfoPtr__CustomExcludedManagedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, nameof (_CustomExcludedManagedTypes));
      PersistenceV2Utility.NativeMethodInfoPtr_GetExcludedComponentTypes_Public_Static_NativeBitArray_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670354);
      PersistenceV2Utility.NativeMethodInfoPtr_GetExcludedFieldsByComponent_Public_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_ExcludeFieldAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670355);
      PersistenceV2Utility.NativeMethodInfoPtr_GetFieldsWithAttributeByComponent_Private_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670356);
      PersistenceV2Utility.NativeMethodInfoPtr_GetComponentsToRemoveFromArchetype_Public_Static_NativeBitArray_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670357);
      PersistenceV2Utility.NativeMethodInfoPtr_GetComponentTypesThatExcludeArchetypes_Public_Static_NativeBitArray_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670358);
      PersistenceV2Utility.NativeMethodInfoPtr_GetTypesToLogErrorFor_Public_Static_NativeBitArray_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670359);
      PersistenceV2Utility.NativeMethodInfoPtr_SetTypeFlag_Private_Static_Void_Type_NativeBitArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670360);
      PersistenceV2Utility.NativeMethodInfoPtr_GetSupportedBlobTypesForRemapping_Public_Static_HashSet_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670361);
      PersistenceV2Utility.NativeMethodInfoPtr_FindTypeFieldsWithBlobAssetRemappingSupport_Public_Static_Void_NativeBitArray_Allocator_byref_NativeHashSet_1_SupportedBlobField_byref_NativeHashSet_1_SupportedBlobField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670362);
      PersistenceV2Utility.NativeMethodInfoPtr_FindRecursiveSupportedBlobFields_Private_Static_Void_ComponentType_Type_Int32_HashSet_1_Type_NativeHashSet_1_SupportedBlobField_NativeHashSet_1_SupportedBlobField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670363);
      PersistenceV2Utility.NativeMethodInfoPtr_IsFromExcludedAssembly_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670365);
      PersistenceV2Utility.NativeMethodInfoPtr_IsCustomExcluded_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670366);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_Type_ExcludePersistenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670367);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeComponent_Private_Static_Void_String_ExcludePersistenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670368);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670369);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomComponentExcludesArchetype_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670370);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670371);
      PersistenceV2Utility.NativeMethodInfoPtr_SetCustomExcludeAndLogErrorIfTypeSaved_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670372);
      PersistenceV2Utility.NativeMethodInfoPtr_TryGetType_Private_Static_Boolean_String_byref_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670373);
      PersistenceV2Utility.NativeMethodInfoPtr_ExcludeAssembly_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, 100670374);
    }

    public PersistenceV2Utility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<Il2CppSystem.Type, PersistenceV2Utility.CustomTypeData> _CustomHandledTypeData
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PersistenceV2Utility.NativeFieldInfoPtr__CustomHandledTypeData, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, PersistenceV2Utility.CustomTypeData>) null : new Dictionary<Il2CppSystem.Type, PersistenceV2Utility.CustomTypeData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PersistenceV2Utility.NativeFieldInfoPtr__CustomHandledTypeData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe HashSet<string> _ExcludedAssemblies
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PersistenceV2Utility.NativeFieldInfoPtr__ExcludedAssemblies, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PersistenceV2Utility.NativeFieldInfoPtr__ExcludedAssemblies, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe HashSet<string> _CustomExcludedManagedTypes
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PersistenceV2Utility.NativeFieldInfoPtr__CustomExcludedManagedTypes, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PersistenceV2Utility.NativeFieldInfoPtr__CustomExcludedManagedTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class FieldWithAttribute<T> : Il2CppSystem.ValueType where T : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Field;
      private static readonly System.IntPtr NativeFieldInfoPtr_Attribute;
      private static readonly System.IntPtr NativeFieldInfoPtr_FieldOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_FieldSize;

      static FieldWithAttribute()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, "FieldWithAttribute`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr);
        PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, nameof (Field));
        PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, nameof (Attribute));
        PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, nameof (FieldOffset));
        PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, nameof (FieldSize));
      }

      public FieldWithAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FieldWithAttribute()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2Utility.FieldWithAttribute<T>>.NativeClassPtr, data));
      }

      public unsafe FieldInfo Field
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Field));
          return pointer == System.IntPtr.Zero ? (FieldInfo) null : new FieldInfo(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Field), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe T Attribute
      {
        get
        {
          return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Attribute), true, false);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_Attribute);
          System.Type type = typeof (T);
          if (!type.IsValueType)
          {
            if (!string.Equals(type.FullName, "System.String"))
            {
              System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
              if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
              {
                System.IntPtr num1 = ptr;
                System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
                int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
                __memcpy(targetAddress, num2, num3);
              }
              else
                IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
            }
            else
            {
              System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
            }
          }
          else
          {
            T obj = value;
            *(T*) targetAddress = obj;
          }
        }
      }

      public unsafe int FieldOffset
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldOffset));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldOffset)) = value;
        }
      }

      public unsafe int FieldSize
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldSize));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2Utility.FieldWithAttribute<T>.NativeFieldInfoPtr_FieldSize)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SupportedBlobField
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_FieldOffset;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SupportedBlobField_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public ComponentType ComponentType;
      [FieldOffset(8)]
      public int FieldOffset;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797221, XrefRangeEnd = 797222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(PersistenceV2Utility.SupportedBlobField other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SupportedBlobField_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797222, XrefRangeEnd = 797226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797226, XrefRangeEnd = 797227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SupportedBlobField()
      {
        Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, nameof (SupportedBlobField));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr);
        PersistenceV2Utility.SupportedBlobField.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, nameof (ComponentType));
        PersistenceV2Utility.SupportedBlobField.NativeFieldInfoPtr_FieldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, nameof (FieldOffset));
        PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SupportedBlobField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, 100670375);
        PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, 100670376);
        PersistenceV2Utility.SupportedBlobField.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, 100670377);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2Utility.SupportedBlobField>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CustomTypeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ShouldExcludeComponent;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShouldExcludeArchetypesWithComponent;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExcludeAndLogErrorIfTypeSaved;
      [FieldOffset(0)]
      public Nullable_Unboxed<ExcludePersistenceOptions> ShouldExcludeComponent;
      [FieldOffset(8)]
      public bool ShouldExcludeArchetypesWithComponent;
      [FieldOffset(9)]
      public bool ExcludeAndLogErrorIfTypeSaved;

      static CustomTypeData()
      {
        Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr, nameof (CustomTypeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr);
        PersistenceV2Utility.CustomTypeData.NativeFieldInfoPtr_ShouldExcludeComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr, nameof (ShouldExcludeComponent));
        PersistenceV2Utility.CustomTypeData.NativeFieldInfoPtr_ShouldExcludeArchetypesWithComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr, nameof (ShouldExcludeArchetypesWithComponent));
        PersistenceV2Utility.CustomTypeData.NativeFieldInfoPtr_ExcludeAndLogErrorIfTypeSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr, nameof (ExcludeAndLogErrorIfTypeSaved));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2Utility.CustomTypeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_GetFieldsWithAttributeByComponent_Private_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceV2Utility.NativeMethodInfoPtr_GetFieldsWithAttributeByComponent_Private_Static_Dictionary_2_Int32_List_1_FieldWithAttribute_1_T_0, Il2CppClassPointerStore<PersistenceV2Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
