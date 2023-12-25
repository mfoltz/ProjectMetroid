// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.TransitionWhenInventoryEmptySystem
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
  public class TransitionWhenInventoryEmptySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___TransitionWhenInventoryEmpty_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TransitionWhenInventoryEmpty_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTransitionWhenInventoryEmpty_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466883, XrefRangeEnd = 1466908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TransitionWhenInventoryEmptySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466908, XrefRangeEnd = 1466944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466944, XrefRangeEnd = 1466963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTransitionWhenInventoryEmpty_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr___GetEntityQuery_ForTransitionWhenInventoryEmpty_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1466967, RefRangeEnd = 1466968, XrefRangeStart = 1466963, XrefRangeEnd = 1466967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TransitionWhenInventoryEmptySystem()
    {
      Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (TransitionWhenInventoryEmptySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr);
      TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, "<>TransitionWhenInventoryEmpty_entityQuery");
      TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, "<>TransitionWhenInventoryEmpty_profilerMarker");
      TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, 100674196);
      TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, 100674197);
      TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, 100674198);
      TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr___GetEntityQuery_ForTransitionWhenInventoryEmpty_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, 100674199);
      TransitionWhenInventoryEmptySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, 100674200);
    }

    public TransitionWhenInventoryEmptySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __TransitionWhenInventoryEmpty_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TransitionWhenInventoryEmpty_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionWhenInventoryEmptySystem.NativeFieldInfoPtr___TransitionWhenInventoryEmpty_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.TransitionWhenInventoryEmptySystem/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventoryInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0;
      [FieldOffset(0)]
      public BufferFromEntity<InventoryBuffer> getInventory;
      [FieldOffset(40)]
      public BufferFromEntity<InventoryInstanceElement> getInventoryInstances;
      [FieldOffset(80)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref TransitionWhenInventoryIsEmpty transitionWhenEmpty,
        [In] ref SpawnChainChild spawnChainChild)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionWhenEmpty;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnChainChild;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getInventory));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getInventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getInventoryInstances));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, 100674201);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, 100674202);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.TransitionWhenInventoryEmptySystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_TransitionWhenInventoryEmpty")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TransitionWhenInventoryEmpty
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventoryInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<InventoryBuffer> getInventory;
      [FieldOffset(40)]
      public BufferFromEntity<InventoryInstanceElement> getInventoryInstances;
      [FieldOffset(80)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(96)]
      public TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(168)]
      public unsafe TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466852, XrefRangeEnd = 1466858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref TransitionWhenInventoryIsEmpty transitionWhenEmpty,
        [In] ref SpawnChainChild spawnChainChild)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionWhenEmpty;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnChainChild;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1437959, RefRangeEnd = 1437961, XrefRangeStart = 1437959, XrefRangeEnd = 1437961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1437961, RefRangeEnd = 1437963, XrefRangeStart = 1437961, XrefRangeEnd = 1437963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466858, XrefRangeEnd = 1466860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1466869, RefRangeEnd = 1466870, XrefRangeStart = 1466860, XrefRangeEnd = 1466869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1466872, RefRangeEnd = 1466873, XrefRangeStart = 1466870, XrefRangeEnd = 1466872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TransitionWhenInventoryEmptySystem componentSystem,
        ref TransitionWhenInventoryEmptySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466873, XrefRangeEnd = 1466877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466877, XrefRangeEnd = 1466883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TransitionWhenInventoryEmpty()
      {
        Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem>.NativeClassPtr, "<>c__DisplayClass_TransitionWhenInventoryEmpty");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (getInventory));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_getInventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (getInventoryInstances));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (commandBuffer));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (_runtimes));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TransitionWhenInventoryIsEmpty_byref_SpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674203);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674204);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674205);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674206);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674207);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674208);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674209);
        TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, 100674210);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_transitionWhenEmpty;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnChainChild;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<TransitionWhenInventoryIsEmpty> forParameter_transitionWhenEmpty;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainChild> forParameter_spawnChainChild;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1466768, RefRangeEnd = 1466769, XrefRangeStart = 1466761, XrefRangeEnd = 1466768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TransitionWhenInventoryEmptySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1466776, RefRangeEnd = 1466777, XrefRangeStart = 1466769, XrefRangeEnd = 1466776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_transitionWhenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_transitionWhenEmpty));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnChainChild));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TransitionWhenInventoryEmptySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, 100674211);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, 100674212);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_transitionWhenEmpty;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnChainChild;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TransitionWhenInventoryIsEmpty>.Runtime runtime_transitionWhenEmpty;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainChild>.Runtime runtime_spawnChainChild;

          static Runtimes()
          {
            Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transitionWhenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_transitionWhenEmpty));
            TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnChainChild));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.TransitionWhenInventoryEmptySystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_TransitionWhenInventoryEmpty/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000019ED$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, "RunWithoutJobSystem_000019ED$PostfixBurstDelegate");
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674213);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674214);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674215);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674216);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.TransitionWhenInventoryEmptySystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_TransitionWhenInventoryEmpty/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000019ED$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466777, XrefRangeEnd = 1466791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466791, XrefRangeEnd = 1466809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1466809, XrefRangeEnd = 1466824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1466851, RefRangeEnd = 1466852, XrefRangeStart = 1466824, XrefRangeEnd = 1466851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty>.NativeClassPtr, "RunWithoutJobSystem_000019ED$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674217);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674218);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674219);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674220);
          TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674222);
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
            IL2CPP.il2cpp_field_static_get_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TransitionWhenInventoryEmptySystem.__c__DisplayClass_TransitionWhenInventoryEmpty.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
