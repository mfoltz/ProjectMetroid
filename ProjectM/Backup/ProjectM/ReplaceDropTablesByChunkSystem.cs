// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceDropTablesByChunkSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ReplaceDropTablesByChunkSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkDataRemappingManager;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceDropTablesByChunk_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceDropTablesByChunk_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForReplaceDropTablesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021870, XrefRangeEnd = 1021876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021876, XrefRangeEnd = 1021891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceDropTablesByChunkSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021891, XrefRangeEnd = 1021909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1021931, RefRangeEnd = 1021932, XrefRangeStart = 1021909, XrefRangeEnd = 1021931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForReplaceDropTablesByChunk_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceDropTablesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1021936, RefRangeEnd = 1021937, XrefRangeStart = 1021932, XrefRangeEnd = 1021936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceDropTablesByChunkSystem()
    {
      Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceDropTablesByChunkSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr);
      ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, nameof (_ChunkDataRemappingManager));
      ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, "<>ReplaceDropTablesByChunk_entityQuery");
      ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, "<>ReplaceDropTablesByChunk_profilerMarker");
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679767);
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679768);
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679769);
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679770);
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceDropTablesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679771);
      ReplaceDropTablesByChunkSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, 100679772);
    }

    public ReplaceDropTablesByChunkSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChunkDataRemappingManager _ChunkDataRemappingManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager));
        return pointer == System.IntPtr.Zero ? (ChunkDataRemappingManager) null : new ChunkDataRemappingManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ReplaceDropTablesByChunk_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ReplaceDropTablesByChunk_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceDropTablesByChunkSystem.NativeFieldInfoPtr___ReplaceDropTablesByChunk_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ReplaceDropTablesByChunkSystem/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableByChunkLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      [FieldOffset(0)]
      public ChunkRemappingLookup<PrefabGUID> dropTableByChunkLookup;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<DropTableBuffer> dropTableBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTableBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_dropTableByChunkLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (dropTableByChunkLookup));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679773);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679774);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ReplaceDropTablesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceDropTablesByChunk")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ReplaceDropTablesByChunk
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableByChunkLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ChunkRemappingLookup<PrefabGUID> dropTableByChunkLookup;
      [FieldOffset(16)]
      public ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021830, XrefRangeEnd = 1021845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<DropTableBuffer> dropTableBuffer,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTableBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021845, XrefRangeEnd = 1021847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1021856, RefRangeEnd = 1021857, XrefRangeStart = 1021847, XrefRangeEnd = 1021856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1021859, RefRangeEnd = 1021860, XrefRangeStart = 1021857, XrefRangeEnd = 1021859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReplaceDropTablesByChunkSystem componentSystem,
        ref ReplaceDropTablesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021860, XrefRangeEnd = 1021864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021864, XrefRangeEnd = 1021870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ReplaceDropTablesByChunk()
      {
        Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem>.NativeClassPtr, "<>c__DisplayClass_ReplaceDropTablesByChunk");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_dropTableByChunkLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (dropTableByChunkLookup));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (_runtimes));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_DropTableBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679775);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679776);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679777);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679778);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679779);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679780);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679781);
        ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, 100679782);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropTableBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer> forParameter_dropTableBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1021746, RefRangeEnd = 1021747, XrefRangeStart = 1021739, XrefRangeEnd = 1021746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ReplaceDropTablesByChunkSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1021754, RefRangeEnd = 1021755, XrefRangeStart = 1021747, XrefRangeEnd = 1021754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropTableBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropTableBuffer));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceDropTablesByChunkSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, 100679783);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, 100679784);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropTableBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<DropTableBuffer>.Runtime runtime_dropTableBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropTableBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropTableBuffer));
            ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ReplaceDropTablesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceDropTablesByChunk/ProjectM.RunWithoutJobSystem_00003CBC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, "RunWithoutJobSystem_00003CBC$PostfixBurstDelegate");
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679785);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679786);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679787);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679788);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ReplaceDropTablesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceDropTablesByChunk/ProjectM.RunWithoutJobSystem_00003CBC$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021755, XrefRangeEnd = 1021769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021769, XrefRangeEnd = 1021787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021787, XrefRangeEnd = 1021802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1021829, RefRangeEnd = 1021830, XrefRangeStart = 1021802, XrefRangeEnd = 1021829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk>.NativeClassPtr, "RunWithoutJobSystem_00003CBC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679789);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679790);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679791);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679792);
          ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679794);
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
            IL2CPP.il2cpp_field_static_get_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceDropTablesByChunkSystem.__c__DisplayClass_ReplaceDropTablesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
