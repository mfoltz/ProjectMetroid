// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ReplaceAbilityOnSlotSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationEntityPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr___Spawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Spawn_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380962, XrefRangeEnd = 1380973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380973, XrefRangeEnd = 1380993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceAbilityOnSlotSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380993, XrefRangeEnd = 1381011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1381039, RefRangeEnd = 1381040, XrefRangeStart = 1381011, XrefRangeEnd = 1381039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1381044, RefRangeEnd = 1381045, XrefRangeStart = 1381040, XrefRangeEnd = 1381044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceAbilityOnSlotSystem()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ReplaceAbilityOnSlotSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr);
      ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationEntityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_ModificationEntityPrefab));
      ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Spawn_entityQuery");
      ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Spawn_profilerMarker");
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665423);
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665424);
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665425);
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665426);
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665427);
      ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665428);
    }

    public ReplaceAbilityOnSlotSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity _ModificationEntityPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationEntityPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationEntityPrefab)) = value;
      }
    }

    public unsafe EntityQuery __Spawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Spawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Spawn_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotSystem/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationEntityPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Entity modificationEntityPrefab;
      [FieldOffset(24)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref EntityOwner entityOwner,
        [In] ref Buff buff,
        [In] ref ReplaceAbilityOnSlotData replaceData,
        [In] ref DynamicBuffer<ReplaceAbilityOnSlotBuff> replacements)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref replacements;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationEntityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationEntityPrefab));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665429);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665430);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Spawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Spawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationEntityPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Entity modificationEntityPrefab;
      [FieldOffset(24)]
      public EntityManager entityManager;
      [FieldOffset(32)]
      public ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(176)]
      public unsafe ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380818, XrefRangeEnd = 1380929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref EntityOwner entityOwner,
        [In] ref Buff buff,
        [In] ref ReplaceAbilityOnSlotData replaceData,
        [In] ref DynamicBuffer<ReplaceAbilityOnSlotBuff> replacements)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref replacements;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380929, RefRangeEnd = 1380930, XrefRangeStart = 1380929, XrefRangeEnd = 1380929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380930, RefRangeEnd = 1380931, XrefRangeStart = 1380930, XrefRangeEnd = 1380930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380931, XrefRangeEnd = 1380933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380948, RefRangeEnd = 1380949, XrefRangeStart = 1380933, XrefRangeEnd = 1380948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380951, RefRangeEnd = 1380952, XrefRangeStart = 1380949, XrefRangeEnd = 1380951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReplaceAbilityOnSlotSystem componentSystem,
        ref ReplaceAbilityOnSlotSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380952, XrefRangeEnd = 1380956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380956, XrefRangeEnd = 1380962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Spawn()
      {
        Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Spawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (commandBuffer));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_modificationEntityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (modificationEntityPrefab));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (entityManager));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_runtimes));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_byref_Buff_byref_ReplaceAbilityOnSlotData_byref_DynamicBuffer_1_ReplaceAbilityOnSlotBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665431);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665432);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665433);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665434);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665435);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665436);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665437);
        ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665438);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replaceData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replacements;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<ReplaceAbilityOnSlotData> forParameter_replaceData;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotBuff> forParameter_replacements;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380728, RefRangeEnd = 1380729, XrefRangeStart = 1380715, XrefRangeEnd = 1380728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380742, RefRangeEnd = 1380743, XrefRangeStart = 1380729, XrefRangeEnd = 1380742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replaceData));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replacements));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100665439);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100665440);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replaceData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replacements;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ReplaceAbilityOnSlotData>.Runtime runtime_replaceData;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotBuff>.Runtime runtime_replacements;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
            ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replaceData));
            ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replacements));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000004F0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000004F0$PostfixBurstDelegate");
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665441);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665442);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665443);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665444);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000004F0$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380743, XrefRangeEnd = 1380757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380757, XrefRangeEnd = 1380775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380775, XrefRangeEnd = 1380790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380817, RefRangeEnd = 1380818, XrefRangeStart = 1380790, XrefRangeEnd = 1380817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000004F0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665445);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665446);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665447);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665448);
          ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665450);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
