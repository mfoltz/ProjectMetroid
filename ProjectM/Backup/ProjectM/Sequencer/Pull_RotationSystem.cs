// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Pull_RotationSystem
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
using Unity.Transforms;

#nullable disable
namespace ProjectM.Sequencer
{
  public class Pull_RotationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Pull_RotationJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Pull_RotationJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPull_RotationJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092818, XrefRangeEnd = 1092831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Pull_RotationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Pull_RotationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092831, XrefRangeEnd = 1092849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Pull_RotationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1092871, RefRangeEnd = 1092872, XrefRangeStart = 1092849, XrefRangeEnd = 1092871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPull_RotationJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.NativeMethodInfoPtr___GetEntityQuery_ForPull_RotationJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1092876, RefRangeEnd = 1092877, XrefRangeStart = 1092872, XrefRangeEnd = 1092876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Pull_RotationSystem()
    {
      Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Pull_RotationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr);
      Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, "<>Pull_RotationJob_entityQuery");
      Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, "<>Pull_RotationJob_profilerMarker");
      Pull_RotationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, 100686212);
      Pull_RotationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, 100686213);
      Pull_RotationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, 100686214);
      Pull_RotationSystem.NativeMethodInfoPtr___GetEntityQuery_ForPull_RotationJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, 100686215);
      Pull_RotationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, 100686216);
    }

    public Pull_RotationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Pull_RotationJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Pull_RotationJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pull_RotationSystem.NativeFieldInfoPtr___Pull_RotationJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.Pull_RotationSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_0(
        DynamicBuffer<BlackboardElement> blackboardData,
        [In] ref Pull_Rotation pullRotation,
        [In] ref Rotation rotation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &blackboardData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pullRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr);
        Pull_RotationSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr, "<>9");
        Pull_RotationSystem.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr, "<>9__0_0");
        Pull_RotationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr, 100686218);
        Pull_RotationSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c>.NativeClassPtr, 100686219);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Pull_RotationSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Pull_RotationSystem.__c) null : new Pull_RotationSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VII<DynamicBuffer<BlackboardElement>, Pull_Rotation, Rotation> __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VII<DynamicBuffer<BlackboardElement>, Pull_Rotation, Rotation>) null : new VII<DynamicBuffer<BlackboardElement>, Pull_Rotation, Rotation>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.Pull_RotationSystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_RotationJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Pull_RotationJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092789, XrefRangeEnd = 1092792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<BlackboardElement> blackboardData,
        [In] ref Pull_Rotation pullRotation,
        [In] ref Rotation rotation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &blackboardData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pullRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092792, XrefRangeEnd = 1092794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1092805, RefRangeEnd = 1092806, XrefRangeStart = 1092794, XrefRangeEnd = 1092805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1092807, RefRangeEnd = 1092808, XrefRangeStart = 1092806, XrefRangeEnd = 1092807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(Pull_RotationSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092808, XrefRangeEnd = 1092812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092812, XrefRangeEnd = 1092818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Pull_RotationJob()
      {
        Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem>.NativeClassPtr, "<>c__DisplayClass_Pull_RotationJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, nameof (_runtimes));
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_BlackboardElement_byref_Pull_Rotation_byref_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686220);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686221);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686222);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686223);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686224);
        Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, 100686225);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blackboardData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pullRotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement> forParameter_blackboardData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Pull_Rotation> forParameter_pullRotation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092703, RefRangeEnd = 1092704, XrefRangeStart = 1092694, XrefRangeEnd = 1092703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Pull_RotationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092713, RefRangeEnd = 1092714, XrefRangeStart = 1092704, XrefRangeEnd = 1092713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blackboardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blackboardData));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pullRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pullRotation));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Pull_RotationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, 100686226);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, 100686227);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blackboardData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pullRotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement>.Runtime runtime_blackboardData;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Pull_Rotation>.Runtime runtime_pullRotation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;

          static Runtimes()
          {
            Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blackboardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blackboardData));
            Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pullRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pullRotation));
            Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.Pull_RotationSystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_RotationJob/ProjectM.Sequencer.RunWithoutJobSystem_00005023$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, "RunWithoutJobSystem_00005023$PostfixBurstDelegate");
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686228);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686229);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686230);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100686231);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.Pull_RotationSystem/ProjectM.Sequencer.<>c__DisplayClass_Pull_RotationJob/ProjectM.Sequencer.RunWithoutJobSystem_00005023$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092714, XrefRangeEnd = 1092728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092728, XrefRangeEnd = 1092746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092746, XrefRangeEnd = 1092761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1092788, RefRangeEnd = 1092789, XrefRangeStart = 1092761, XrefRangeEnd = 1092788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob>.NativeClassPtr, "RunWithoutJobSystem_00005023$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686232);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686233);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686234);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686235);
          Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100686237);
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
            IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Pull_RotationSystem.__c__DisplayClass_Pull_RotationJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
