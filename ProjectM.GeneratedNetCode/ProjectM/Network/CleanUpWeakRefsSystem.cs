// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CleanUpWeakRefsSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Network
{
  public class CleanUpWeakRefsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceivePacketSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanUpWeakRefs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanUpWeakRefs_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCleanUpWeakRefs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483836, XrefRangeEnd = 1483842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483842, XrefRangeEnd = 1483857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CleanUpWeakRefsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483857, XrefRangeEnd = 1483875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483897, RefRangeEnd = 1483898, XrefRangeStart = 1483875, XrefRangeEnd = 1483897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCleanUpWeakRefs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCleanUpWeakRefs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483898, XrefRangeEnd = 1483902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CleanUpWeakRefsSystem()
    {
      Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (CleanUpWeakRefsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr);
      CleanUpWeakRefsSystem.NativeFieldInfoPtr__ReceivePacketSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, nameof (_ReceivePacketSystem));
      CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, "<>CleanUpWeakRefs_entityQuery");
      CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, "<>CleanUpWeakRefs_profilerMarker");
      CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663726);
      CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663727);
      CleanUpWeakRefsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663728);
      CleanUpWeakRefsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663729);
      CleanUpWeakRefsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCleanUpWeakRefs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663730);
      CleanUpWeakRefsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, 100663731);
    }

    public CleanUpWeakRefsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ReceivePacketSystem _ReceivePacketSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr__ReceivePacketSystem));
        return pointer == System.IntPtr.Zero ? (ReceivePacketSystem) null : new ReceivePacketSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr__ReceivePacketSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CleanUpWeakRefs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CleanUpWeakRefs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CleanUpWeakRefsSystem.NativeFieldInfoPtr___CleanUpWeakRefs_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Network.CleanUpWeakRefsSystem/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_weakRefTracker;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0;
      [FieldOffset(0)]
      public WeakRefTracker_EntityManagement weakRefTracker;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref NetworkId networkId,
        [In] ref NetworkSnapshot networkSnapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkSnapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr);
        CleanUpWeakRefsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_weakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (weakRefTracker));
        CleanUpWeakRefsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100663732);
        CleanUpWeakRefsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100663733);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Network.CleanUpWeakRefsSystem/ProjectM.Network.<>c__DisplayClass_CleanUpWeakRefs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CleanUpWeakRefs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_weakRefTracker;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public WeakRefTracker_EntityManagement weakRefTracker;
      [FieldOffset(56)]
      public CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483808, RefRangeEnd = 1483809, XrefRangeStart = 1483801, XrefRangeEnd = 1483808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref NetworkId networkId,
        [In] ref NetworkSnapshot networkSnapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkSnapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483809, RefRangeEnd = 1483810, XrefRangeStart = 1483809, XrefRangeEnd = 1483809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CleanUpWeakRefsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483810, RefRangeEnd = 1483811, XrefRangeStart = 1483810, XrefRangeEnd = 1483810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CleanUpWeakRefsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483811, XrefRangeEnd = 1483813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483822, RefRangeEnd = 1483823, XrefRangeStart = 1483813, XrefRangeEnd = 1483822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1483825, RefRangeEnd = 1483826, XrefRangeStart = 1483823, XrefRangeEnd = 1483825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CleanUpWeakRefsSystem componentSystem,
        ref CleanUpWeakRefsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483826, XrefRangeEnd = 1483830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483830, XrefRangeEnd = 1483836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CleanUpWeakRefs()
      {
        Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem>.NativeClassPtr, "<>c__DisplayClass_CleanUpWeakRefs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_weakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (weakRefTracker));
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (_runtimes));
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkId_byref_NetworkSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663734);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663735);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663736);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663737);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663738);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663739);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663740);
        CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, 100663741);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkId;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkSnapshotType;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<NetworkId> forParameter_networkId;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<NetworkSnapshot> forParameter_networkSnapshotType;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1483717, RefRangeEnd = 1483718, XrefRangeStart = 1483710, XrefRangeEnd = 1483717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CleanUpWeakRefsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1483725, RefRangeEnd = 1483726, XrefRangeStart = 1483718, XrefRangeEnd = 1483725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkId));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkSnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkSnapshotType));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CleanUpWeakRefsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, 100663742);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, 100663743);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkId;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkSnapshotType;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<NetworkId>.Runtime runtime_networkId;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<NetworkSnapshot>.Runtime runtime_networkSnapshotType;

          static Runtimes()
          {
            Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkId));
            CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkSnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkSnapshotType));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.CleanUpWeakRefsSystem/ProjectM.Network.<>c__DisplayClass_CleanUpWeakRefs/ProjectM.Network.RunWithoutJobSystem_000001BB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, "RunWithoutJobSystem_000001BB$PostfixBurstDelegate");
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663744);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663745);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663746);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663747);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Network.CleanUpWeakRefsSystem/ProjectM.Network.<>c__DisplayClass_CleanUpWeakRefs/ProjectM.Network.RunWithoutJobSystem_000001BB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483726, XrefRangeEnd = 1483740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483740, XrefRangeEnd = 1483758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483758, XrefRangeEnd = 1483773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1483800, RefRangeEnd = 1483801, XrefRangeStart = 1483773, XrefRangeEnd = 1483800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs>.NativeClassPtr, "RunWithoutJobSystem_000001BB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663748);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663749);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663750);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663751);
          CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663753);
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
            IL2CPP.il2cpp_field_static_get_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CleanUpWeakRefsSystem.__c__DisplayClass_CleanUpWeakRefs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
