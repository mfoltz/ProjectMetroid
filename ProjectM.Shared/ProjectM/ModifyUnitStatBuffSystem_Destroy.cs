// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyUnitStatBuffSystem_Destroy
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class ModifyUnitStatBuffSystem_Destroy : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740615, XrefRangeEnd = 740634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyUnitStatBuffSystem_Destroy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740634, XrefRangeEnd = 740652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 740674, RefRangeEnd = 740675, XrefRangeStart = 740652, XrefRangeEnd = 740674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 740679, RefRangeEnd = 740680, XrefRangeStart = 740675, XrefRangeEnd = 740679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyUnitStatBuffSystem_Destroy()
    {
      Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyUnitStatBuffSystem_Destroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr);
      ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, 100665315);
      ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, 100665316);
      ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, 100665317);
      ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, 100665318);
      ModifyUnitStatBuffSystem_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, 100665319);
    }

    public ModifyUnitStatBuffSystem_Destroy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffSystem_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ModifyUnitStatBuffSystem_Destroy/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantPowers;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyUnitStats;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<ServantPower> servantPowers;
      [FieldOffset(32)]
      public ModifyUnitStats modifyUnitStats;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<ModifyUnitStatBuff_DOTS> statModifications,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref statModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeFieldInfoPtr_servantPowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr, nameof (servantPowers));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeFieldInfoPtr_modifyUnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr, nameof (modifyUnitStats));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr, 100665320);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr, 100665321);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ModifyUnitStatBuffSystem_Destroy/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantPowers;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyUnitStats;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<ServantPower> servantPowers;
      [FieldOffset(32)]
      public ModifyUnitStats modifyUnitStats;
      [FieldOffset(528)]
      public ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(608)]
      public unsafe ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740573, XrefRangeEnd = 740588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<ModifyUnitStatBuff_DOTS> statModifications,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref statModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 740588, RefRangeEnd = 740589, XrefRangeStart = 740588, XrefRangeEnd = 740588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 740589, RefRangeEnd = 740590, XrefRangeStart = 740589, XrefRangeEnd = 740589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740590, XrefRangeEnd = 740592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 740601, RefRangeEnd = 740602, XrefRangeStart = 740592, XrefRangeEnd = 740601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 740604, RefRangeEnd = 740605, XrefRangeStart = 740602, XrefRangeEnd = 740604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ModifyUnitStatBuffSystem_Destroy componentSystem,
        ref ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740605, XrefRangeEnd = 740609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740609, XrefRangeEnd = 740615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_servantPowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (servantPowers));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_modifyUnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (modifyUnitStats));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ModifyUnitStatBuff_DOTS_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665322);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665323);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665324);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665325);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665326);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665327);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665328);
        ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665329);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statModifications;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ModifyUnitStatBuff_DOTS> forParameter_statModifications;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 740489, RefRangeEnd = 740490, XrefRangeStart = 740482, XrefRangeEnd = 740489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ModifyUnitStatBuffSystem_Destroy componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 740497, RefRangeEnd = 740498, XrefRangeStart = 740490, XrefRangeEnd = 740497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statModifications));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ModifyUnitStatBuffSystem_Destroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665330);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665331);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statModifications;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ModifyUnitStatBuff_DOTS>.Runtime runtime_statModifications;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statModifications));
            ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ModifyUnitStatBuffSystem_Destroy/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000007A7$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000007A7$PostfixBurstDelegate");
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665332);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665333);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665334);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665335);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ModifyUnitStatBuffSystem_Destroy/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000007A7$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740498, XrefRangeEnd = 740512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740512, XrefRangeEnd = 740530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740530, XrefRangeEnd = 740545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 740572, RefRangeEnd = 740573, XrefRangeStart = 740545, XrefRangeEnd = 740572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000007A7$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665336);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665337);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665338);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665339);
          ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665341);
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
            IL2CPP.il2cpp_field_static_get_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ModifyUnitStatBuffSystem_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
