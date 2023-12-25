// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.SetSpiderLegsSystem
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
namespace ProjectM.Hybrid
{
  public class SetSpiderLegsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___SetSpiderLegs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetSpiderLegs_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157016, XrefRangeEnd = 1157032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetSpiderLegsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157032, XrefRangeEnd = 1157046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1157071, RefRangeEnd = 1157072, XrefRangeStart = 1157046, XrefRangeEnd = 1157071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetSpiderLegs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SetSpiderLegsSystem()
    {
      Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (SetSpiderLegsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr);
      SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, "<>SetSpiderLegs_entityQuery");
      SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, "<>SetSpiderLegs_profilerMarker");
      SetSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, 100692092);
      SetSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, 100692093);
      SetSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, 100692094);
      SetSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, 100692095);
    }

    public SetSpiderLegsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __SetSpiderLegs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetSpiderLegs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.NativeFieldInfoPtr___SetSpiderLegs_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.SetSpiderLegsSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        HybridIKSpiderLegs spider,
        ref SpiderLegsDriver driver,
        [In] ref DynamicBuffer<SpiderLeg> legs,
        [In] ref HybridModel hybridModel)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spider);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref hybridModel;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr);
        SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (deltaTime));
        SetSpiderLegsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, 100692096);
        SetSpiderLegsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, 100692097);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe SetSpiderLegsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetSpiderLegsSystem) null : new SetSpiderLegsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.SetSpiderLegsSystem/ProjectM.Hybrid.<>c__DisplayClass_SetSpiderLegs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetSpiderLegs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_1;
      [FieldOffset(72)]
      public SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156983, RefRangeEnd = 1156984, XrefRangeStart = 1156931, XrefRangeEnd = 1156983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        HybridIKSpiderLegs spider,
        ref SpiderLegsDriver driver,
        [In] ref DynamicBuffer<SpiderLeg> legs,
        [In] ref HybridModel hybridModel)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spider);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref hybridModel;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 1149759, RefRangeEnd = 1149767, XrefRangeStart = 1149759, XrefRangeEnd = 1149767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetSpiderLegsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1149767, RefRangeEnd = 1149774, XrefRangeStart = 1149767, XrefRangeEnd = 1149774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetSpiderLegsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156984, XrefRangeEnd = 1156986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157000, RefRangeEnd = 1157001, XrefRangeStart = 1156986, XrefRangeEnd = 1157000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157009, RefRangeEnd = 1157010, XrefRangeStart = 1157001, XrefRangeEnd = 1157009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetSpiderLegsSystem componentSystem,
        ref SetSpiderLegsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157010, XrefRangeEnd = 1157016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetSpiderLegs()
      {
        Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSpiderLegsSystem>.NativeClassPtr, "<>c__DisplayClass_SetSpiderLegs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (deltaTime));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_0));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_1));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (_runtimes));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridIKSpiderLegs_byref_SpiderLegsDriver_byref_DynamicBuffer_1_SpiderLeg_byref_HybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692098);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692099);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692100);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692101);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692102);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692103);
        SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, 100692104);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spider;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_driver;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_legs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hybridModel;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs> forParameter_spider;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpiderLegsDriver> forParameter_driver;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<SpiderLeg> forParameter_legs;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<HybridModel> forParameter_hybridModel;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156916, RefRangeEnd = 1156917, XrefRangeStart = 1156904, XrefRangeEnd = 1156916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetSpiderLegsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156930, RefRangeEnd = 1156931, XrefRangeStart = 1156917, XrefRangeEnd = 1156930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spider));
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_driver));
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_legs));
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hybridModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hybridModel));
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetSpiderLegsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692105);
          SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692106);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_driver;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_legs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hybridModel;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spider));
            SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_driver));
            SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_legs));
            SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hybridModel));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime runtime_spider
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spider), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridIKSpiderLegs>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime runtime_driver
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime runtime_legs
          {
            get
            {
              return *(LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime runtime_hybridModel
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridModel));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSpiderLegsSystem.__c__DisplayClass_SetSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridModel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
