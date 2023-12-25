// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Pull_EntitySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Pull_EntitySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Pull_EntityJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Pull_EntityJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPull_EntityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092242, XrefRangeEnd = 1092255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Pull_EntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Pull_EntitySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092255, XrefRangeEnd = 1092273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Pull_EntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1092295, RefRangeEnd = 1092296, XrefRangeStart = 1092273, XrefRangeEnd = 1092295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPull_EntityJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForPull_EntityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1092300, RefRangeEnd = 1092301, XrefRangeStart = 1092296, XrefRangeEnd = 1092300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Pull_EntitySystem()
    {
      Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Pull_EntitySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr);
      Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, "<>Pull_EntityJob_entityQuery");
      Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, "<>Pull_EntityJob_profilerMarker");
      Pull_EntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, 100686136);
      Pull_EntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, 100686137);
      Pull_EntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, 100686138);
      Pull_EntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForPull_EntityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, 100686139);
      Pull_EntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, 100686140);
    }

    public Pull_EntitySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Pull_EntityJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Pull_EntityJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_EntitySystem.NativeFieldInfoPtr___Pull_EntityJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.Pull_EntitySystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_0(
        ref DynamicBuffer<BlackboardElement> blackboardData,
        [In] ref Pull_Entity pull,
        [In] ref SequenceInstance sequenceInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref blackboardData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pull;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr);
        Pull_EntitySystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr, "<>9");
        Pull_EntitySystem.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr, "<>9__0_0");
        Pull_EntitySystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr, 100686142);
        Pull_EntitySystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c>.NativeClassPtr, 100686143);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Pull_EntitySystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Pull_EntitySystem.__c) null : new Pull_EntitySystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RII<DynamicBuffer<BlackboardElement>, Pull_Entity, SequenceInstance> __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RII<DynamicBuffer<BlackboardElement>, Pull_Entity, SequenceInstance>) null : new RII<DynamicBuffer<BlackboardElement>, Pull_Entity, SequenceInstance>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.Pull_EntitySystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_EntityJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Pull_EntityJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092213, XrefRangeEnd = 1092216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<BlackboardElement> blackboardData,
        [In] ref Pull_Entity pull,
        [In] ref SequenceInstance sequenceInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref blackboardData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pull;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092216, XrefRangeEnd = 1092218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1092229, RefRangeEnd = 1092230, XrefRangeStart = 1092218, XrefRangeEnd = 1092229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1092231, RefRangeEnd = 1092232, XrefRangeStart = 1092230, XrefRangeEnd = 1092231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(Pull_EntitySystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092232, XrefRangeEnd = 1092236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092236, XrefRangeEnd = 1092242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Pull_EntityJob()
      {
        Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem>.NativeClassPtr, "<>c__DisplayClass_Pull_EntityJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, nameof (_runtimes));
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_BlackboardElement_byref_Pull_Entity_byref_SequenceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686144);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686145);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686146);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686147);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686148);
        Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, 100686149);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blackboardData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pull;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement> forParameter_blackboardData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Pull_Entity> forParameter_pull;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092127, RefRangeEnd = 1092128, XrefRangeStart = 1092118, XrefRangeEnd = 1092127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Pull_EntitySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092137, RefRangeEnd = 1092138, XrefRangeStart = 1092128, XrefRangeEnd = 1092137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blackboardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blackboardData));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pull));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_EntitySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, 100686150);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, 100686151);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blackboardData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pull;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement>.Runtime runtime_blackboardData;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Pull_Entity>.Runtime runtime_pull;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blackboardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blackboardData));
            Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pull));
            Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.Pull_EntitySystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_EntityJob/ProjectM.Sequencer.RunWithoutJobSystem_00004FFB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, "RunWithoutJobSystem_00004FFB$PostfixBurstDelegate");
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686152);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686153);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686154);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686155);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.Pull_EntitySystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_EntityJob/ProjectM.Sequencer.RunWithoutJobSystem_00004FFB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092138, XrefRangeEnd = 1092152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092152, XrefRangeEnd = 1092170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092170, XrefRangeEnd = 1092185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092212, RefRangeEnd = 1092213, XrefRangeStart = 1092185, XrefRangeEnd = 1092212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob>.NativeClassPtr, "RunWithoutJobSystem_00004FFB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686156);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686157);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686158);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686159);
          Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686161);
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
            IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Pull_EntitySystem.__c__DisplayClass_Pull_EntityJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
