// Decompiled with JetBrains decompiler
// Type: ProjectM.DetectModificationLeaksSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class DetectModificationLeaksSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationReferences;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAndFixModificationLeaks_Private_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindModificationField_Private_Static_Boolean_Type_Int32_ptr_Byte_byref_ptr_TModifiable_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742783, XrefRangeEnd = 742786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DetectModificationLeaksSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742786, XrefRangeEnd = 742800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DetectModificationLeaksSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 742898, RefRangeEnd = 742899, XrefRangeStart = 742800, XrefRangeEnd = 742898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindAndFixModificationLeaks<TModBuffer, TModifiable, E>(
      EntityManager entityManager,
      Entity source,
      Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.MethodInfoStoreGeneric_FindAndFixModificationLeaks_Private_Static_Void_EntityManager_Entity_Entity_0<TModBuffer, TModifiable, E>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742899, XrefRangeEnd = 742908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindModificationField<TModifiable>(
      Il2CppSystem.Type type,
      int targetModifiableId,
      byte* dataPtr,
      out TModifiable* modificationFieldPtr,
      ref string fieldName)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetModifiableId;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) dataPtr;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TModifiable*& local1;
      if (!typeof (TModifiable).IsValueType)
      {
        zero = System.IntPtr.Zero;
        // ISSUE: explicit reference operation
        local1 = @(TModifiable*) zero;
      }
      else
        local1 = ref modificationFieldPtr;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      System.IntPtr* numPtr2 = &il2Cpp;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.MethodInfoStoreGeneric_TryFindModificationField_Private_Static_Boolean_Type_Int32_ptr_Byte_byref_ptr_TModifiable_byref_String_0<TModifiable>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TModifiable).IsValueType)
      {
        ref TModifiable* local2 = ref modificationFieldPtr;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TModifiable>(objectPointer, false, false);
        local2 = (TModifiable*) valueGeneric;
      }
      fieldName = IL2CPP.Il2CppStringToManaged(il2Cpp);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742908, XrefRangeEnd = 742911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DetectModificationLeaksSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DetectModificationLeaksSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742911, XrefRangeEnd = 742940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DetectModificationLeaksSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742940, XrefRangeEnd = 742956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DetectModificationLeaksSystem()
    {
      Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DetectModificationLeaksSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr);
      DetectModificationLeaksSystem.NativeFieldInfoPtr_ModificationReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, nameof (ModificationReferences));
      DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, "<>Destroy_entityQuery");
      DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, "<>Destroy_profilerMarker");
      DetectModificationLeaksSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665485);
      DetectModificationLeaksSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665486);
      DetectModificationLeaksSystem.NativeMethodInfoPtr_FindAndFixModificationLeaks_Private_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665487);
      DetectModificationLeaksSystem.NativeMethodInfoPtr_TryFindModificationField_Private_Static_Boolean_Type_Int32_ptr_Byte_byref_ptr_TModifiable_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665488);
      DetectModificationLeaksSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665489);
      DetectModificationLeaksSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665490);
      DetectModificationLeaksSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665491);
      DetectModificationLeaksSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, 100665492);
    }

    public DetectModificationLeaksSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeMultiHashMap<Entity, Entity> ModificationReferences
    {
      get
      {
        return *(NativeMultiHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr_ModificationReferences));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr_ModificationReferences), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<Entity, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __Destroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Destroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.NativeFieldInfoPtr___Destroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DetectModificationLeaksSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationSourceMappings;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr);
        DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationSourceMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationSourceMappings));
        DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665493);
        DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665494);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe NativeMultiHashMap<Entity, Entity> modificationSourceMappings
      {
        get
        {
          return *(NativeMultiHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationSourceMappings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationSourceMappings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<Entity, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DetectModificationLeaksSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DetectModificationLeaksSystem) null : new DetectModificationLeaksSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.DetectModificationLeaksSystem/ProjectM.<>c__DisplayClass_Destroy")]
    public sealed class __c__DisplayClass_Destroy : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationSourceMappings;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 742764, RefRangeEnd = 742765, XrefRangeStart = 742726, XrefRangeEnd = 742764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 742766, RefRangeEnd = 742768, XrefRangeStart = 742765, XrefRangeEnd = 742766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DetectModificationLeaksSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 735237, RefRangeEnd = 735248, XrefRangeStart = 735237, XrefRangeEnd = 735248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DetectModificationLeaksSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742768, XrefRangeEnd = 742770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 742773, RefRangeEnd = 742774, XrefRangeStart = 742770, XrefRangeEnd = 742773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 742776, RefRangeEnd = 742777, XrefRangeStart = 742774, XrefRangeEnd = 742776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DetectModificationLeaksSystem componentSystem,
        ref DetectModificationLeaksSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742777, XrefRangeEnd = 742783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Destroy()
      {
        Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr, "<>c__DisplayClass_Destroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_modificationSourceMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (modificationSourceMappings));
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, "<>4__this");
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_runtimes));
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665495);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665496);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665497);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665498);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665499);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665500);
        DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665501);
      }

      public __c__DisplayClass_Destroy(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_Destroy()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, data));
      }

      public unsafe NativeMultiHashMap<Entity, Entity> modificationSourceMappings
      {
        get
        {
          return *(NativeMultiHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_modificationSourceMappings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_modificationSourceMappings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<Entity, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DetectModificationLeaksSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DetectModificationLeaksSystem) null : new DetectModificationLeaksSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742674, XrefRangeEnd = 742675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DetectModificationLeaksSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742700, XrefRangeEnd = 742701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DetectModificationLeaksSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665502);
          DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665503);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectModificationLeaksSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_FindAndFixModificationLeaks_Private_Static_Void_EntityManager_Entity_Entity_0<TModBuffer, TModifiable, E>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(DetectModificationLeaksSystem.NativeMethodInfoPtr_FindAndFixModificationLeaks_Private_Static_Void_EntityManager_Entity_Entity_0, Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModBuffer>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModifiable>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryFindModificationField_Private_Static_Boolean_Type_Int32_ptr_Byte_byref_ptr_TModifiable_byref_String_0<TModifiable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(DetectModificationLeaksSystem.NativeMethodInfoPtr_TryFindModificationField_Private_Static_Boolean_Type_Int32_ptr_Byte_byref_ptr_TModifiable_byref_String_0, Il2CppClassPointerStore<DetectModificationLeaksSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModifiable>.NativeClassPtr))
      }))));
    }
  }
}
