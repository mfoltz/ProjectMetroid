// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveSpeedBuffSystem
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
  public class MoveSpeedBuffSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380152, XrefRangeEnd = 1380178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveSpeedBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveSpeedBuffSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380178, XrefRangeEnd = 1380196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1380221, RefRangeEnd = 1380222, XrefRangeStart = 1380196, XrefRangeEnd = 1380221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdate_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1380226, RefRangeEnd = 1380227, XrefRangeStart = 1380222, XrefRangeEnd = 1380226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveSpeedBuffSystem()
    {
      Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (MoveSpeedBuffSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr);
      MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, "<>Update_entityQuery");
      MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, "<>Update_profilerMarker");
      MoveSpeedBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, 100665340);
      MoveSpeedBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, 100665341);
      MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, 100665342);
      MoveSpeedBuffSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, 100665343);
      MoveSpeedBuffSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, 100665344);
    }

    public MoveSpeedBuffSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Update_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Update_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveSpeedBuffSystem.NativeFieldInfoPtr___Update_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.MoveSpeedBuffSystem/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMovement;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSpeedModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveDataMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Movement> getMovement;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getSpeedModifications;
      [FieldOffset(72)]
      public CurveCollection curveDataMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref Age age,
        [In] ref LifeTime lifeTime,
        [In] ref ModifyMovementSpeedBuff moveSpeedBuff,
        [In] ref ModifyMovementSpeedBuffModification modification)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveSpeedBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modification;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr);
        MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getMovement));
        MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_getSpeedModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (getSpeedModifications));
        MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_curveDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (curveDataMap));
        MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, 100665345);
        MoveSpeedBuffSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, 100665346);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Update")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Update
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMovement;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSpeedModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveDataMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Movement> getMovement;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getSpeedModifications;
      [FieldOffset(72)]
      public CurveCollection curveDataMap;
      [FieldOffset(88)]
      public MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380106, XrefRangeEnd = 1380122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Age age,
        [In] ref LifeTime lifeTime,
        [In] ref ModifyMovementSpeedBuff moveSpeedBuff,
        [In] ref ModifyMovementSpeedBuffModification modification)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveSpeedBuff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref modification;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1050838, RefRangeEnd = 1050841, XrefRangeStart = 1050838, XrefRangeEnd = 1050841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MoveSpeedBuffSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1050841, RefRangeEnd = 1050844, XrefRangeStart = 1050841, XrefRangeEnd = 1050844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MoveSpeedBuffSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380122, XrefRangeEnd = 1380124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380138, RefRangeEnd = 1380139, XrefRangeStart = 1380124, XrefRangeEnd = 1380138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1380141, RefRangeEnd = 1380142, XrefRangeStart = 1380139, XrefRangeEnd = 1380141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MoveSpeedBuffSystem componentSystem,
        ref MoveSpeedBuffSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380142, XrefRangeEnd = 1380146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380146, XrefRangeEnd = 1380152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Update()
      {
        Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem>.NativeClassPtr, "<>c__DisplayClass_Update");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_getMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (getMovement));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_getSpeedModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (getSpeedModifications));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_curveDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (curveDataMap));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (_runtimes));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_byref_LifeTime_byref_ModifyMovementSpeedBuff_byref_ModifyMovementSpeedBuffModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665347);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665348);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665349);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665350);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665351);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665352);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665353);
        MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, 100665354);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_lifeTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveSpeedBuff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modification;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<LifeTime> forParameter_lifeTime;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuff> forParameter_moveSpeedBuff;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuffModification> forParameter_modification;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380017, RefRangeEnd = 1380018, XrefRangeStart = 1380005, XrefRangeEnd = 1380017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MoveSpeedBuffSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380030, RefRangeEnd = 1380031, XrefRangeStart = 1380018, XrefRangeEnd = 1380030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_lifeTime));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveSpeedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveSpeedBuff));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modification));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveSpeedBuffSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, 100665355);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, 100665356);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_lifeTime;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveSpeedBuff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modification;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LifeTime>.Runtime runtime_lifeTime;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuff>.Runtime runtime_moveSpeedBuff;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuffModification>.Runtime runtime_modification;

          static Runtimes()
          {
            Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
            MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_lifeTime));
            MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveSpeedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveSpeedBuff));
            MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modification));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Update/ProjectM.RunWithoutJobSystem_000004C0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, "RunWithoutJobSystem_000004C0$PostfixBurstDelegate");
          MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665357);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665358);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665359);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665360);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Update/ProjectM.RunWithoutJobSystem_000004C0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380031, XrefRangeEnd = 1380045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380045, XrefRangeEnd = 1380063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380063, XrefRangeEnd = 1380078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1380105, RefRangeEnd = 1380106, XrefRangeStart = 1380078, XrefRangeEnd = 1380105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update>.NativeClassPtr, "RunWithoutJobSystem_000004C0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665361);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665362);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665363);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665364);
          MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665366);
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
            IL2CPP.il2cpp_field_static_get_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MoveSpeedBuffSystem.__c__DisplayClass_Update.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
