// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainElementsChangedEventSystem
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

#nullable disable
namespace ProjectM
{
  public class SpawnChainElementsChangedEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroySpawnChainsWithNoElements_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070600, XrefRangeEnd = 1070623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainElementsChangedEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070623, XrefRangeEnd = 1070656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070656, XrefRangeEnd = 1070672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroySpawnChainsWithNoElements_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroySpawnChainsWithNoElements_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1070676, RefRangeEnd = 1070677, XrefRangeStart = 1070672, XrefRangeEnd = 1070676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainElementsChangedEventSystem()
    {
      Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnChainElementsChangedEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr);
      SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, nameof (_EventQuery));
      SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, "<>DestroySpawnChainsWithNoElements_entityQuery");
      SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, "<>DestroySpawnChainsWithNoElements_profilerMarker");
      SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, 100684318);
      SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, 100684319);
      SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, 100684320);
      SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroySpawnChainsWithNoElements_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, 100684321);
      SpawnChainElementsChangedEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, 100684322);
    }

    public SpawnChainElementsChangedEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery __DestroySpawnChainsWithNoElements_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DestroySpawnChainsWithNoElements_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainElementsChangedEventSystem.NativeFieldInfoPtr___DestroySpawnChainsWithNoElements_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainElementsChangedEventSystem/<>c__DisplayClass1_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass1_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getActiveChainElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_ActiveElementsChangedEvent_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<SpawnChainData.ActiveChildElement> getActiveChainElement;
      [FieldOffset(32)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref SpawnChainData.ActiveElementsChangedEvent eventData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref eventData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_ActiveElementsChangedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_getActiveChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (getActiveChainElement));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (commandBuffer));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr, 100684323);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_ActiveElementsChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr, 100684324);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainElementsChangedEventSystem/ProjectM.<>c__DisplayClass_DestroySpawnChainsWithNoElements")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DestroySpawnChainsWithNoElements
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getActiveChainElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ActiveElementsChangedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<SpawnChainData.ActiveChildElement> getActiveChainElement;
      [FieldOffset(32)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(48)]
      public SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070570, XrefRangeEnd = 1070579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref SpawnChainData.ActiveElementsChangedEvent eventData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref eventData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ActiveElementsChangedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 507623, RefRangeEnd = 507633, XrefRangeStart = 507623, XrefRangeEnd = 507633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1049298, RefRangeEnd = 1049308, XrefRangeStart = 1049298, XrefRangeEnd = 1049308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070579, XrefRangeEnd = 1070581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1070586, RefRangeEnd = 1070587, XrefRangeStart = 1070581, XrefRangeEnd = 1070586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1070589, RefRangeEnd = 1070590, XrefRangeStart = 1070587, XrefRangeEnd = 1070589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnChainElementsChangedEventSystem componentSystem,
        ref SpawnChainElementsChangedEventSystem.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070590, XrefRangeEnd = 1070594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070594, XrefRangeEnd = 1070600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DestroySpawnChainsWithNoElements()
      {
        Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem>.NativeClassPtr, "<>c__DisplayClass_DestroySpawnChainsWithNoElements");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_getActiveChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (getActiveChainElement));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (commandBuffer));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (_runtimes));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ActiveElementsChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684325);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684326);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684327);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684328);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684329);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684330);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684331);
        SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, 100684332);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveElementsChangedEvent> forParameter_eventData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070490, RefRangeEnd = 1070491, XrefRangeStart = 1070487, XrefRangeEnd = 1070490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          SpawnChainElementsChangedEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070494, RefRangeEnd = 1070495, XrefRangeStart = 1070491, XrefRangeEnd = 1070494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventData));
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainElementsChangedEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr, 100684333);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr, 100684334);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveElementsChangedEvent>.Runtime runtime_eventData;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainElementsChangedEventSystem/ProjectM.<>c__DisplayClass_DestroySpawnChainsWithNoElements/ProjectM.RunWithoutJobSystem_000049F6$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, "RunWithoutJobSystem_000049F6$PostfixBurstDelegate");
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684335);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684336);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684337);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684338);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainElementsChangedEventSystem/ProjectM.<>c__DisplayClass_DestroySpawnChainsWithNoElements/ProjectM.RunWithoutJobSystem_000049F6$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070495, XrefRangeEnd = 1070509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070509, XrefRangeEnd = 1070527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070527, XrefRangeEnd = 1070542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070569, RefRangeEnd = 1070570, XrefRangeStart = 1070542, XrefRangeEnd = 1070569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements>.NativeClassPtr, "RunWithoutJobSystem_000049F6$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684339);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684340);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684341);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684342);
          SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684344);
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
            IL2CPP.il2cpp_field_static_get_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainElementsChangedEventSystem.__c__DisplayClass_DestroySpawnChainsWithNoElements.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
