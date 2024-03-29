﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.BuffAimPreviewSpawnSystem
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
namespace ProjectM.Gameplay.Systems
{
  public class BuffAimPreviewSpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434640, XrefRangeEnd = 1434651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434651, XrefRangeEnd = 1434667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffAimPreviewSpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434667, XrefRangeEnd = 1434699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434699, XrefRangeEnd = 1434718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BuffAimPreviewSpawnSystem()
    {
      Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (BuffAimPreviewSpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr);
      BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, 100671141);
      BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, 100671142);
      BuffAimPreviewSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, 100671143);
      BuffAimPreviewSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, 100671144);
      BuffAimPreviewSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, 100671145);
    }

    public BuffAimPreviewSpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.BuffAimPreviewSpawnSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffAimPreview_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ref BuffAimPreview aimPreview)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aimPreview;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffAimPreview_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr);
        BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (prefabLookupMap));
        BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, 100671146);
        BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_BuffAimPreview_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, 100671147);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe BuffAimPreviewSpawnSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuffAimPreviewSpawnSystem) null : new BuffAimPreviewSpawnSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.BuffAimPreviewSpawnSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpawnPrefabOnDestroy_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffAimPreview_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1434608, RefRangeEnd = 1434609, XrefRangeStart = 1434559, XrefRangeEnd = 1434608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref BuffAimPreview aimPreview)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aimPreview;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffAimPreview_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1434610, RefRangeEnd = 1434611, XrefRangeStart = 1434609, XrefRangeEnd = 1434610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuffAimPreviewSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1434612, RefRangeEnd = 1434613, XrefRangeStart = 1434611, XrefRangeEnd = 1434612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuffAimPreviewSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434613, XrefRangeEnd = 1434615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1434621, RefRangeEnd = 1434622, XrefRangeStart = 1434615, XrefRangeEnd = 1434621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1434633, RefRangeEnd = 1434634, XrefRangeStart = 1434622, XrefRangeEnd = 1434633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuffAimPreviewSpawnSystem componentSystem,
        ref BuffAimPreviewSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434634, XrefRangeEnd = 1434640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (prefabLookupMap));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (spawnCommandBuffer));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buff_0));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_1));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnPrefabOnDestroy_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpawnPrefabOnDestroy_2));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_BuffAimPreview_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671148);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671149);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671150);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671151);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671152);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671153);
        BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100671154);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe BuffAimPreviewSpawnSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuffAimPreviewSpawnSystem) null : new BuffAimPreviewSpawnSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Buff> _ComponentDataFromEntity_Buff_0
      {
        get
        {
          return *(ComponentDataFromEntity<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_1
      {
        get
        {
          return *(ComponentDataFromEntity<EntityOwner>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<EntityOwner>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<SpawnPrefabOnDestroy> _ComponentDataFromEntity_SpawnPrefabOnDestroy_2
      {
        get
        {
          return *(ComponentDataFromEntity<SpawnPrefabOnDestroy>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnPrefabOnDestroy_2));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnPrefabOnDestroy_2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<SpawnPrefabOnDestroy>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aimPreview;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<BuffAimPreview> forParameter_aimPreview;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1434553, RefRangeEnd = 1434554, XrefRangeStart = 1434549, XrefRangeEnd = 1434553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuffAimPreviewSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1434558, RefRangeEnd = 1434559, XrefRangeStart = 1434554, XrefRangeEnd = 1434558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aimPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aimPreview));
          BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffAimPreviewSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100671155);
          BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100671156);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aimPreview;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<BuffAimPreview>.Runtime runtime_aimPreview;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aimPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aimPreview));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffAimPreviewSpawnSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
