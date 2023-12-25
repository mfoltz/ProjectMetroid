// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeKnockbackResistanceDuringCast_OnDestroy
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
namespace ProjectM
{
  public class ChangeKnockbackResistanceDuringCast_OnDestroy : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModificationOnDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModificationOnDestroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveModificationOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373759, XrefRangeEnd = 1373774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChangeKnockbackResistanceDuringCast_OnDestroy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373774, XrefRangeEnd = 1373792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1373814, RefRangeEnd = 1373815, XrefRangeStart = 1373792, XrefRangeEnd = 1373814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveModificationOnDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModificationOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1373819, RefRangeEnd = 1373820, XrefRangeStart = 1373815, XrefRangeEnd = 1373819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChangeKnockbackResistanceDuringCast_OnDestroy()
    {
      Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ChangeKnockbackResistanceDuringCast_OnDestroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr);
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, "<>RemoveModificationOnDestroy_entityQuery");
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, "<>RemoveModificationOnDestroy_profilerMarker");
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, 100664535);
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, 100664536);
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, 100664537);
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModificationOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, 100664538);
      ChangeKnockbackResistanceDuringCast_OnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, 100664539);
    }

    public ChangeKnockbackResistanceDuringCast_OnDestroy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __RemoveModificationOnDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveModificationOnDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_OnDestroy.NativeFieldInfoPtr___RemoveModificationOnDestroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_OnDestroy/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_0;
      [FieldOffset(0)]
      public EntityManager entityManager;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity abiltiyEntity, [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &abiltiyEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr, nameof (entityManager));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr, 100664540);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr, 100664541);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_OnDestroy/ProjectM.<>c__DisplayClass_RemoveModificationOnDestroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveModificationOnDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373736, RefRangeEnd = 1373737, XrefRangeStart = 1373726, XrefRangeEnd = 1373736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity abiltiyEntity, [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &abiltiyEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373737, XrefRangeEnd = 1373739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373745, RefRangeEnd = 1373746, XrefRangeStart = 1373739, XrefRangeEnd = 1373745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373748, RefRangeEnd = 1373749, XrefRangeStart = 1373746, XrefRangeEnd = 1373748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChangeKnockbackResistanceDuringCast_OnDestroy componentSystem,
        ref ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373749, XrefRangeEnd = 1373753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373753, XrefRangeEnd = 1373759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveModificationOnDestroy()
      {
        Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy>.NativeClassPtr, "<>c__DisplayClass_RemoveModificationOnDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (entityManager));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (_runtimes));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664542);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664543);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664544);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664545);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664546);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664547);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664548);
        ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, 100664549);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abiltiyEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_abiltiyEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373645, RefRangeEnd = 1373646, XrefRangeStart = 1373641, XrefRangeEnd = 1373645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ChangeKnockbackResistanceDuringCast_OnDestroy componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373650, RefRangeEnd = 1373651, XrefRangeStart = 1373646, XrefRangeEnd = 1373650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abiltiyEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abiltiyEntity));
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_OnDestroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100664550);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100664551);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abiltiyEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_abiltiyEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abiltiyEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abiltiyEntity));
            ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_OnDestroy/ProjectM.<>c__DisplayClass_RemoveModificationOnDestroy/ProjectM.RunWithoutJobSystem_000002EB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_000002EB$PostfixBurstDelegate");
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664552);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664553);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664554);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664555);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_OnDestroy/ProjectM.<>c__DisplayClass_RemoveModificationOnDestroy/ProjectM.RunWithoutJobSystem_000002EB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373651, XrefRangeEnd = 1373665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373665, XrefRangeEnd = 1373683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373683, XrefRangeEnd = 1373698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373725, RefRangeEnd = 1373726, XrefRangeStart = 1373698, XrefRangeEnd = 1373725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_000002EB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664556);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664557);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664558);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664559);
          ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664561);
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
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_OnDestroy.__c__DisplayClass_RemoveModificationOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
