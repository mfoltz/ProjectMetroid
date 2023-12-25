// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.SetupEntityMetadataOnLoadSystem
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
  public class SetupEntityMetadataOnLoadSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetupEntityMetadataOnPersistenceLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429128, XrefRangeEnd = 1429150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupEntityMetadataOnLoadSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429150, XrefRangeEnd = 1429168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1429196, RefRangeEnd = 1429197, XrefRangeStart = 1429168, XrefRangeEnd = 1429196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetupEntityMetadataOnPersistenceLoad_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupEntityMetadataOnPersistenceLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1429201, RefRangeEnd = 1429202, XrefRangeStart = 1429197, XrefRangeEnd = 1429201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupEntityMetadataOnLoadSystem()
    {
      Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay", nameof (SetupEntityMetadataOnLoadSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr);
      SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr__LoadedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, nameof (_LoadedQuery));
      SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, "<>SetupEntityMetadataOnPersistenceLoad_entityQuery");
      SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, "<>SetupEntityMetadataOnPersistenceLoad_profilerMarker");
      SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, 100670528);
      SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, 100670529);
      SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, 100670530);
      SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupEntityMetadataOnPersistenceLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, 100670531);
      SetupEntityMetadataOnLoadSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, 100670532);
    }

    public SetupEntityMetadataOnLoadSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _LoadedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr__LoadedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr__LoadedQuery)) = value;
      }
    }

    public unsafe EntityQuery __SetupEntityMetadataOnPersistenceLoad_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetupEntityMetadataOnPersistenceLoad_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupEntityMetadataOnLoadSystem.NativeFieldInfoPtr___SetupEntityMetadataOnPersistenceLoad_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.SetupEntityMetadataOnLoadSystem/<>c__DisplayClass1_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass1_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_activeMetadatas;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PrefabGUID_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, EntityMetadataSystem.Metadata> activeMetadatas;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref PrefabGUID prefabGuid)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_activeMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (activeMetadatas));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr, 100670533);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr, 100670534);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.SetupEntityMetadataOnLoadSystem/ProjectM.Gameplay.<>c__DisplayClass_SetupEntityMetadataOnPersistenceLoad")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetupEntityMetadataOnPersistenceLoad
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_activeMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<Entity, EntityMetadataSystem.Metadata> activeMetadatas;
      [FieldOffset(16)]
      public SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429103, XrefRangeEnd = 1429106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref PrefabGUID prefabGuid)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429106, XrefRangeEnd = 1429108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1429114, RefRangeEnd = 1429115, XrefRangeStart = 1429108, XrefRangeEnd = 1429114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1429117, RefRangeEnd = 1429118, XrefRangeStart = 1429115, XrefRangeEnd = 1429117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupEntityMetadataOnLoadSystem componentSystem,
        ref SetupEntityMetadataOnLoadSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429118, XrefRangeEnd = 1429122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429122, XrefRangeEnd = 1429128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetupEntityMetadataOnPersistenceLoad()
      {
        Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem>.NativeClassPtr, "<>c__DisplayClass_SetupEntityMetadataOnPersistenceLoad");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_activeMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (activeMetadatas));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (_runtimes));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670535);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670536);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670537);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670538);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670539);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670540);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670541);
        SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, 100670542);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1429022, RefRangeEnd = 1429023, XrefRangeStart = 1429018, XrefRangeEnd = 1429022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupEntityMetadataOnLoadSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1429027, RefRangeEnd = 1429028, XrefRangeStart = 1429023, XrefRangeEnd = 1429027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupEntityMetadataOnLoadSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, 100670543);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, 100670544);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.SetupEntityMetadataOnLoadSystem/ProjectM.Gameplay.<>c__DisplayClass_SetupEntityMetadataOnPersistenceLoad/ProjectM.Gameplay.RunWithoutJobSystem_00001139$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, "RunWithoutJobSystem_00001139$PostfixBurstDelegate");
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670545);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670546);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670547);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670548);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.SetupEntityMetadataOnLoadSystem/ProjectM.Gameplay.<>c__DisplayClass_SetupEntityMetadataOnPersistenceLoad/ProjectM.Gameplay.RunWithoutJobSystem_00001139$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429028, XrefRangeEnd = 1429042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429042, XrefRangeEnd = 1429060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429060, XrefRangeEnd = 1429075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1429102, RefRangeEnd = 1429103, XrefRangeStart = 1429075, XrefRangeEnd = 1429102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad>.NativeClassPtr, "RunWithoutJobSystem_00001139$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670549);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670550);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670551);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670552);
          SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670554);
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
            IL2CPP.il2cpp_field_static_get_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupEntityMetadataOnLoadSystem.__c__DisplayClass_SetupEntityMetadataOnPersistenceLoad.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
