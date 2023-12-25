// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.GetSpiderLegsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Hybrid
{
  public class GetSpiderLegsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___GetSpiderLegs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetSpiderLegs_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156536, XrefRangeEnd = 1156548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetSpiderLegsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156548, XrefRangeEnd = 1156562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156584, RefRangeEnd = 1156585, XrefRangeStart = 1156562, XrefRangeEnd = 1156584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetSpiderLegs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetSpiderLegsSystem()
    {
      Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (GetSpiderLegsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr);
      GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, "<>GetSpiderLegs_entityQuery");
      GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, "<>GetSpiderLegs_profilerMarker");
      GetSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, 100692050);
      GetSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, 100692051);
      GetSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, 100692052);
      GetSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, 100692053);
    }

    public GetSpiderLegsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __GetSpiderLegs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetSpiderLegs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.NativeFieldInfoPtr___GetSpiderLegs_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.GetSpiderLegsSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_0(
        HybridIKSpiderLegs spider,
        ref DynamicBuffer<SpiderLeg> legs,
        ref SpiderLegsDriver driver)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spider);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr);
        GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr, "<>9");
        GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr, "<>9__0_0");
        GetSpiderLegsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr, 100692055);
        GetSpiderLegsSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c>.NativeClassPtr, 100692056);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GetSpiderLegsSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GetSpiderLegsSystem.__c) null : new GetSpiderLegsSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VRR<HybridIKSpiderLegs, DynamicBuffer<SpiderLeg>, SpiderLegsDriver> __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VRR<HybridIKSpiderLegs, DynamicBuffer<SpiderLeg>, SpiderLegsDriver>) null : new VRR<HybridIKSpiderLegs, DynamicBuffer<SpiderLeg>, SpiderLegsDriver>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetSpiderLegsSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.GetSpiderLegsSystem/ProjectM.Hybrid.<>c__DisplayClass_GetSpiderLegs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetSpiderLegs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156513, RefRangeEnd = 1156514, XrefRangeStart = 1156487, XrefRangeEnd = 1156513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        HybridIKSpiderLegs spider,
        ref DynamicBuffer<SpiderLeg> legs,
        ref SpiderLegsDriver driver)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spider);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156514, XrefRangeEnd = 1156516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156527, RefRangeEnd = 1156528, XrefRangeStart = 1156516, XrefRangeEnd = 1156527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156529, RefRangeEnd = 1156530, XrefRangeStart = 1156528, XrefRangeEnd = 1156529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(GetSpiderLegsSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156530, XrefRangeEnd = 1156536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetSpiderLegs()
      {
        Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSpiderLegsSystem>.NativeClassPtr, "<>c__DisplayClass_GetSpiderLegs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr);
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, nameof (_runtimes));
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, 100692057);
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, 100692058);
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, 100692059);
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, 100692060);
        GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, 100692061);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spider;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_legs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_driver;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs> forParameter_spider;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<SpiderLeg> forParameter_legs;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<SpiderLegsDriver> forParameter_driver;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156475, RefRangeEnd = 1156476, XrefRangeStart = 1156466, XrefRangeEnd = 1156475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GetSpiderLegsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156486, RefRangeEnd = 1156487, XrefRangeStart = 1156476, XrefRangeEnd = 1156486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spider));
          GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_legs));
          GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_driver));
          GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetSpiderLegsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692062);
          GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692063);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_legs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_driver;

          static Runtimes()
          {
            Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spider));
            GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_legs));
            GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_driver));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime runtime_spider
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime runtime_legs
          {
            get
            {
              return *(LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime runtime_driver
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetSpiderLegsSystem.__c__DisplayClass_GetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
