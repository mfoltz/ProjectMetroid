// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModApplyUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class SpellModApplyUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateIterator_Public_Static_SpellModIterator_1_TSpellMod_byref_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticSpellMod_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmetic_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmeticModifiableSpellMod_Public_Static_ModificationId_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmeticModifiable_byref_DynamicBuffer_1_FloatModificationBuffer_byref_ModificationStructure_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveArithmeticModifiableSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPrefabGuidSpellMod_Public_Static_Void_byref_EntityManager_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_Entity_byref_SpellModPrefabGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplySequenceGuidSpellMod_Public_Static_Void_byref_EntityManager_Entity_byref_SpellModSequenceGuid_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1038608, RefRangeEnd = 1038616, XrefRangeStart = 1038607, XrefRangeEnd = 1038608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SpellModApplyUtilities.SpellModIterator<TSpellMod> CreateIterator<TSpellMod>(
      [In] ref DynamicBuffer<TSpellMod> spellMods,
      [In] ref EntityManager entityManager,
      Entity entity,
      bool isClientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref spellMods;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isClientWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.MethodInfoStoreGeneric_CreateIterator_Public_Static_SpellModIterator_1_TSpellMod_byref_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0<TSpellMod>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModApplyUtilities.SpellModIterator<TSpellMod>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038650, RefRangeEnd = 1038651, XrefRangeStart = 1038616, XrefRangeEnd = 1038650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyArithmeticSpellMod(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellMod spellMod,
      [In] ref SpellModCollection<BlobAssetReference<SpellModBlob>> spellModCollection,
      [In] ref CurveCollection curveCollection,
      [In] ref SpellModArithmetic arithmeticSpellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref arithmeticSpellMod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellMod_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmetic_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038668, RefRangeEnd = 1038669, XrefRangeStart = 1038651, XrefRangeEnd = 1038668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationId ApplyArithmeticModifiableSpellMod(
      [In] ref EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref SpellMod spellMod,
      [In] ref SpellModCollection<BlobAssetReference<SpellModBlob>> spellModCollection,
      [In] ref CurveCollection curveCollection,
      [In] ref SpellModArithmeticModifiable arithmeticModifiableSpellMod,
      ref DynamicBuffer<FloatModificationBuffer> modificationBuffer,
      [In] ref ModificationStructure modificationStructure)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref arithmeticModifiableSpellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationStructure;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.NativeMethodInfoPtr_ApplyArithmeticModifiableSpellMod_Public_Static_ModificationId_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmeticModifiable_byref_DynamicBuffer_1_FloatModificationBuffer_byref_ModificationStructure_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038680, RefRangeEnd = 1038681, XrefRangeStart = 1038669, XrefRangeEnd = 1038680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RemoveArithmeticModifiableSpellMod(
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.NativeMethodInfoPtr_RemoveArithmeticModifiableSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038699, RefRangeEnd = 1038700, XrefRangeStart = 1038681, XrefRangeEnd = 1038699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyPrefabGuidSpellMod(
      [In] ref EntityManager entityManager,
      [In] ref SpellModCollection<BlobAssetReference<SpellModBlob>> spellModCollection,
      Entity entity,
      [In] ref SpellModPrefabGuid prefabSpellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabSpellMod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.NativeMethodInfoPtr_ApplyPrefabGuidSpellMod_Public_Static_Void_byref_EntityManager_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_Entity_byref_SpellModPrefabGuid_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038703, RefRangeEnd = 1038704, XrefRangeStart = 1038700, XrefRangeEnd = 1038703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplySequenceGuidSpellMod(
      [In] ref EntityManager entityManager,
      Entity entity,
      [In] ref SpellModSequenceGuid sequenceSpellMod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceSpellMod;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.NativeMethodInfoPtr_ApplySequenceGuidSpellMod_Public_Static_Void_byref_EntityManager_Entity_byref_SpellModSequenceGuid_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModApplyUtilities()
    {
      Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpellModApplyUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr);
      SpellModApplyUtilities.NativeMethodInfoPtr_CreateIterator_Public_Static_SpellModIterator_1_TSpellMod_byref_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681295);
      SpellModApplyUtilities.NativeMethodInfoPtr_ApplyArithmeticSpellMod_Public_Static_Void_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmetic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681296);
      SpellModApplyUtilities.NativeMethodInfoPtr_ApplyArithmeticModifiableSpellMod_Public_Static_ModificationId_byref_EntityManager_byref_Entity_byref_SpellMod_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_byref_CurveCollection_byref_SpellModArithmeticModifiable_byref_DynamicBuffer_1_FloatModificationBuffer_byref_ModificationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681297);
      SpellModApplyUtilities.NativeMethodInfoPtr_RemoveArithmeticModifiableSpellMod_Public_Static_Boolean_byref_EntityManager_Entity_SpellModArithmeticModifiableTarget_ModificationId_byref_DynamicBuffer_1_FloatModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681298);
      SpellModApplyUtilities.NativeMethodInfoPtr_ApplyPrefabGuidSpellMod_Public_Static_Void_byref_EntityManager_byref_SpellModCollection_1_BlobAssetReference_1_SpellModBlob_Entity_byref_SpellModPrefabGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681299);
      SpellModApplyUtilities.NativeMethodInfoPtr_ApplySequenceGuidSpellMod_Public_Static_Void_byref_EntityManager_Entity_byref_SpellModSequenceGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, 100681300);
    }

    public SpellModApplyUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public struct SpellModIterator<TSpellMod>
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreConditionalSpellMods;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModEnumerator;
      private static readonly System.IntPtr NativeFieldInfoPtr__SpellMod;
      private static readonly System.IntPtr NativeFieldInfoPtr__IsClientWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_SpellModIterator_1_TSpellMod_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ValueTuple_2_TSpellMod_SpellMod_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      public readonly EntityManager EntityManager;
      public readonly Entity Entity;
      public NativeArray<TSpellMod>.Enumerator SpellModEnumerator;
      public SpellMod _SpellMod;
      public bool _IsClientWorld;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1038550, RefRangeEnd = 1038551, XrefRangeStart = 1038548, XrefRangeEnd = 1038550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpellModIterator(
        DynamicBuffer<TSpellMod> spellMods,
        [In] ref EntityManager entityManager,
        Entity entity,
        bool isClientWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &spellMods;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isClientWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 968849, RefRangeEnd = 968859, XrefRangeStart = 968849, XrefRangeEnd = 968859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpellModApplyUtilities.SpellModIterator<TSpellMod> GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_GetEnumerator_Public_SpellModIterator_1_TSpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SpellModApplyUtilities.SpellModIterator<TSpellMod>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1038559, RefRangeEnd = 1038564, XrefRangeStart = 1038551, XrefRangeEnd = 1038559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038564, XrefRangeEnd = 1038566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.ValueTuple<TSpellMod, SpellMod> Current
      {
        [CallerCount(7), CachedScanResults(RefRangeStart = 1038570, RefRangeEnd = 1038577, XrefRangeStart = 1038566, XrefRangeEnd = 1038570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ValueTuple_2_TSpellMod_SpellMod_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new Il2CppSystem.ValueTuple<TSpellMod, SpellMod>(pointer);
        }
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038577, XrefRangeEnd = 1038582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 1038592, RefRangeEnd = 1038607, XrefRangeStart = 1038582, XrefRangeEnd = 1038592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpellModIterator()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr, "SpellModIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSpellMod>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_IgnoreConditionalSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (IgnoreConditionalSpellMods));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (EntityManager));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (Entity));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_SpellModEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (SpellModEnumerator));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr__SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (_SpellMod));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr__IsClientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, nameof (_IsClientWorld));
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr__ctor_Public_Void_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681301);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_GetEnumerator_Public_SpellModIterator_1_TSpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681302);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681303);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681304);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ValueTuple_2_TSpellMod_SpellMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681305);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681306);
        SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, 100681307);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModApplyUtilities.SpellModIterator<TSpellMod>>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe bool IgnoreConditionalSpellMods
      {
        get
        {
          bool conditionalSpellMods;
          IL2CPP.il2cpp_field_static_get_value(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_IgnoreConditionalSpellMods, (void*) &conditionalSpellMods);
          return conditionalSpellMods;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellModApplyUtilities.SpellModIterator<TSpellMod>.NativeFieldInfoPtr_IgnoreConditionalSpellMods, (void*) &value);
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CreateIterator_Public_Static_SpellModIterator_1_TSpellMod_byref_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0<TSpellMod>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SpellModApplyUtilities.NativeMethodInfoPtr_CreateIterator_Public_Static_SpellModIterator_1_TSpellMod_byref_DynamicBuffer_1_TSpellMod_byref_EntityManager_Entity_Boolean_0, Il2CppClassPointerStore<SpellModApplyUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSpellMod>.NativeClassPtr))
      }))));
    }
  }
}
