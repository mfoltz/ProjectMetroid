// Decompiled with JetBrains decompiler
// Type: ProjectM.Destroy_SetOwnerRotateTowardsMouseSystem
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
  public class Destroy_SetOwnerRotateTowardsMouseSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050866, XrefRangeEnd = 1050890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Destroy_SetOwnerRotateTowardsMouseSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050890, XrefRangeEnd = 1050926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050926, XrefRangeEnd = 1050945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1050949, RefRangeEnd = 1050950, XrefRangeStart = 1050945, XrefRangeEnd = 1050949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Destroy_SetOwnerRotateTowardsMouseSystem()
    {
      Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Destroy_SetOwnerRotateTowardsMouseSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr);
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>Destroy_entityQuery");
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>Destroy_profilerMarker");
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682518);
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682519);
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682520);
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682521);
      Destroy_SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682522);
    }

    public Destroy_SetOwnerRotateTowardsMouseSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Destroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Destroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Destroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Destroy_SetOwnerRotateTowardsMouseSystem/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Modification_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getModifications;
      [FieldOffset(72)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref SetOwnerRotateTowardsMouseSystem.Modification modification)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modification;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Modification_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getTargetDirection));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getModifications));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, 100682523);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Modification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, 100682524);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Destroy_SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Destroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Destroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Modification_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getModifications;
      [FieldOffset(72)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(88)]
      public Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050820, XrefRangeEnd = 1050838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SetOwnerRotateTowardsMouseSystem.Modification modification)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modification;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Modification_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1050838, RefRangeEnd = 1050841, XrefRangeStart = 1050838, XrefRangeEnd = 1050838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1050841, RefRangeEnd = 1050844, XrefRangeStart = 1050841, XrefRangeEnd = 1050841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050844, XrefRangeEnd = 1050846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1050852, RefRangeEnd = 1050853, XrefRangeStart = 1050846, XrefRangeEnd = 1050852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1050855, RefRangeEnd = 1050856, XrefRangeStart = 1050853, XrefRangeEnd = 1050855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_SetOwnerRotateTowardsMouseSystem componentSystem,
        ref Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050856, XrefRangeEnd = 1050860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050860, XrefRangeEnd = 1050866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Destroy()
      {
        Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>c__DisplayClass_Destroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (getTargetDirection));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (getModifications));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (commandBuffer));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_runtimes));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Modification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682525);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682526);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682527);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682528);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682529);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682530);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682531);
        Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100682532);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modification;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMouseSystem.Modification> forParameter_modification;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050739, RefRangeEnd = 1050740, XrefRangeStart = 1050735, XrefRangeEnd = 1050739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          Destroy_SetOwnerRotateTowardsMouseSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050744, RefRangeEnd = 1050745, XrefRangeStart = 1050740, XrefRangeEnd = 1050744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modification));
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_SetOwnerRotateTowardsMouseSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100682533);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100682534);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modification;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMouseSystem.Modification>.Runtime runtime_modification;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modification));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Destroy/ProjectM.RunWithoutJobSystem_000044DA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000044DA$PostfixBurstDelegate");
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682535);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682536);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682537);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682538);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Destroy/ProjectM.RunWithoutJobSystem_000044DA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050745, XrefRangeEnd = 1050759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050759, XrefRangeEnd = 1050777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050777, XrefRangeEnd = 1050792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050819, RefRangeEnd = 1050820, XrefRangeStart = 1050792, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000044DA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682539);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682540);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682541);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682542);
          Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682544);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
