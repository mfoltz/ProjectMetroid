﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.RemoveMetadataEntitySystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay
{
  public class RemoveMetadataEntitySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityMetadataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveMetadataJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveMetadataJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveMetadataJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429296, XrefRangeEnd = 1429302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429302, XrefRangeEnd = 1429320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveMetadataEntitySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429320, XrefRangeEnd = 1429356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429356, XrefRangeEnd = 1429375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveMetadataJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForRemoveMetadataJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1429379, RefRangeEnd = 1429380, XrefRangeStart = 1429375, XrefRangeEnd = 1429379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveMetadataEntitySystem()
    {
      Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay", nameof (RemoveMetadataEntitySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr);
      RemoveMetadataEntitySystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, nameof (_Query));
      RemoveMetadataEntitySystem.NativeFieldInfoPtr__EntityMetadataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, nameof (_EntityMetadataSystem));
      RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, "<>RemoveMetadataJob_entityQuery");
      RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, "<>RemoveMetadataJob_profilerMarker");
      RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670555);
      RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670556);
      RemoveMetadataEntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670557);
      RemoveMetadataEntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670558);
      RemoveMetadataEntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForRemoveMetadataJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670559);
      RemoveMetadataEntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, 100670560);
    }

    public RemoveMetadataEntitySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityMetadataSystem _EntityMetadataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr__EntityMetadataSystem));
        return pointer == System.IntPtr.Zero ? (EntityMetadataSystem) null : new EntityMetadataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr__EntityMetadataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __RemoveMetadataJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveMetadataJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveMetadataEntitySystem.NativeFieldInfoPtr___RemoveMetadataJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.RemoveMetadataEntitySystem/<>c__DisplayClass3_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass3_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_activeMetadatas;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, EntityMetadataSystem.Metadata> activeMetadatas;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr);
        RemoveMetadataEntitySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_activeMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (activeMetadatas));
        RemoveMetadataEntitySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr, 100670561);
        RemoveMetadataEntitySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr, 100670562);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass3_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.RemoveMetadataEntitySystem/ProjectM.Gameplay.<>c__DisplayClass_RemoveMetadataJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveMetadataJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_activeMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, EntityMetadataSystem.Metadata> activeMetadatas;
      [FieldOffset(16)]
      public RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429277, XrefRangeEnd = 1429280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RemoveMetadataEntitySystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RemoveMetadataEntitySystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429280, XrefRangeEnd = 1429282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1429285, RefRangeEnd = 1429286, XrefRangeStart = 1429282, XrefRangeEnd = 1429285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RemoveMetadataEntitySystem componentSystem,
        ref RemoveMetadataEntitySystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429286, XrefRangeEnd = 1429290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429290, XrefRangeEnd = 1429296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveMetadataJob()
      {
        Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem>.NativeClassPtr, "<>c__DisplayClass_RemoveMetadataJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_activeMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (activeMetadatas));
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (_runtimes));
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670563);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670564);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670565);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670566);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670567);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670568);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670569);
        RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, 100670570);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RemoveMetadataEntitySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveMetadataEntitySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr, 100670571);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr, 100670572);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.RemoveMetadataEntitySystem/ProjectM.Gameplay.<>c__DisplayClass_RemoveMetadataJob/ProjectM.Gameplay.RunWithoutJobSystem_00001149$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, "RunWithoutJobSystem_00001149$PostfixBurstDelegate");
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670573);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670574);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670575);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670576);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.RemoveMetadataEntitySystem/ProjectM.Gameplay.<>c__DisplayClass_RemoveMetadataJob/ProjectM.Gameplay.RunWithoutJobSystem_00001149$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429202, XrefRangeEnd = 1429216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429216, XrefRangeEnd = 1429234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429234, XrefRangeEnd = 1429249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1429276, RefRangeEnd = 1429277, XrefRangeStart = 1429249, XrefRangeEnd = 1429276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob>.NativeClassPtr, "RunWithoutJobSystem_00001149$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670577);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670578);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670579);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670580);
          RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670582);
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
            IL2CPP.il2cpp_field_static_get_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveMetadataEntitySystem.__c__DisplayClass_RemoveMetadataJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}