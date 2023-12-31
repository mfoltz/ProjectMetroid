// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  public static class SpellModUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_PrefabGUID_byref_SpellMod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticSpellModComponent_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiableSpellModComponent_Public_Static_ModificationId_EntityManager_Entity_byref_SpellModArithmeticModifiable_byref_Single_byref_SpellModArithmeticModifiableOperationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiableSpellModComponent_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPrefabGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModPrefabGuid_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplySequenceGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModSequenceGuid_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 799451, RefRangeEnd = 799462, XrefRangeStart = 799446, XrefRangeEnd = 799451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetSpellMod(
      [In] ref EntityManager entityManager,
      Entity entity,
      PrefabGUID spellModId,
      out SpellMod spellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.NativeMethodInfoPtr_TryGetSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_PrefabGUID_byref_SpellMod_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799462, XrefRangeEnd = 799466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyArithmeticSpellModElement<T>(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellModArithmetic spellMod,
      [In] ref float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_ApplyArithmeticSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799466, XrefRangeEnd = 799469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyArithmeticSpellModComponent<T>(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellModArithmetic spellMod,
      [In] ref float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_ApplyArithmeticSpellModComponent_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799469, XrefRangeEnd = 799472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationId ApplyArithmeticModifiableSpellModComponent<T>(
      EntityManager entityManager,
      Entity entity,
      [In] ref SpellModArithmeticModifiable spellMod,
      [In] ref float value,
      [In] ref SpellModArithmeticModifiableOperationData operationData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref operationData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_ApplyArithmeticModifiableSpellModComponent_Public_Static_ModificationId_EntityManager_Entity_byref_SpellModArithmeticModifiable_byref_Single_byref_SpellModArithmeticModifiableOperationData_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799475, RefRangeEnd = 799476, XrefRangeStart = 799472, XrefRangeEnd = 799475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveArithmeticModifiableSpellModComponent<T>(
      [In] ref EntityManager entityManager,
      Entity entity,
      SpellModArithmeticModifiableTarget target,
      ModificationId modificationId,
      ref DynamicBuffer<FloatModificationBuffer> modificationBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_RemoveArithmeticModifiableSpellModComponent_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799476, XrefRangeEnd = 799480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyPrefabGuidSpellModElement<T>(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellModPrefabGuid spellMod,
      [In] ref PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_ApplyPrefabGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModPrefabGuid_byref_PrefabGUID_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799484, RefRangeEnd = 799485, XrefRangeStart = 799480, XrefRangeEnd = 799484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplySequenceGuidSpellModElement<T>(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellModSequenceGuid spellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModUtilities.MethodInfoStoreGeneric_ApplySequenceGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModSequenceGuid_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModUtilities()
    {
      Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr);
      SpellModUtilities.NativeMethodInfoPtr_TryGetSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_PrefabGUID_byref_SpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670550);
      SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670551);
      SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellModComponent_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670552);
      SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticModifiableSpellModComponent_Public_Static_ModificationId_EntityManager_Entity_byref_SpellModArithmeticModifiable_byref_Single_byref_SpellModArithmeticModifiableOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670553);
      SpellModUtilities.NativeMethodInfoPtr_RemoveArithmeticModifiableSpellModComponent_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670554);
      SpellModUtilities.NativeMethodInfoPtr_ApplyPrefabGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModPrefabGuid_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670555);
      SpellModUtilities.NativeMethodInfoPtr_ApplySequenceGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModSequenceGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr, 100670556);
    }

    public SpellModUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_ApplyArithmeticSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyArithmeticSpellModComponent_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellModComponent_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModArithmetic_byref_Single_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyArithmeticModifiableSpellModComponent_Public_Static_ModificationId_EntityManager_Entity_byref_SpellModArithmeticModifiable_byref_Single_byref_SpellModArithmeticModifiableOperationData_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_ApplyArithmeticModifiableSpellModComponent_Public_Static_ModificationId_EntityManager_Entity_byref_SpellModArithmeticModifiable_byref_Single_byref_SpellModArithmeticModifiableOperationData_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_RemoveArithmeticModifiableSpellModComponent_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_RemoveArithmeticModifiableSpellModComponent_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplyPrefabGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModPrefabGuid_byref_PrefabGUID_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_ApplyPrefabGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModPrefabGuid_byref_PrefabGUID_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ApplySequenceGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModSequenceGuid_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModUtilities.NativeMethodInfoPtr_ApplySequenceGuidSpellModElement_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellModSequenceGuid_0, Il2CppClassPointerStore<SpellModUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
