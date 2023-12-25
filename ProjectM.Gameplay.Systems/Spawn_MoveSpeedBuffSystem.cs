// Decompiled with JetBrains decompiler
// Type: ProjectM.Spawn_MoveSpeedBuffSystem
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
  public class Spawn_MoveSpeedBuffSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___Spawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Spawn_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379921, XrefRangeEnd = 1379927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379927, XrefRangeEnd = 1379953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Spawn_MoveSpeedBuffSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379953, XrefRangeEnd = 1379971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1379999, RefRangeEnd = 1380000, XrefRangeStart = 1379971, XrefRangeEnd = 1379999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1380004, RefRangeEnd = 1380005, XrefRangeStart = 1380000, XrefRangeEnd = 1380004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Spawn_MoveSpeedBuffSystem()
    {
      Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (Spawn_MoveSpeedBuffSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr);
      Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, nameof (_ModificationSystem));
      Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, "<>Spawn_entityQuery");
      Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, "<>Spawn_profilerMarker");
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665312);
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665313);
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665314);
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665315);
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665316);
      Spawn_MoveSpeedBuffSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, 100665317);
    }

    public Spawn_MoveSpeedBuffSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __Spawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Spawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spawn_MoveSpeedBuffSystem.NativeFieldInfoPtr___Spawn_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Spawn_MoveSpeedBuffSystem/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMovement;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSpeedModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Movement> getMovement;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getSpeedModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyMovementSpeedBuff moveSpeedBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveSpeedBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (getMovement));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getSpeedModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (getSpeedModifications));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationStruct));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665318);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, 100665319);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Spawn_MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Spawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Spawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMovement;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSpeedModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Movement> getMovement;
      [FieldOffset(32)]
      public BufferFromEntity<FloatModificationBuffer> getSpeedModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379878, XrefRangeEnd = 1379896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref ModifyMovementSpeedBuff moveSpeedBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveSpeedBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001521, RefRangeEnd = 1001527, XrefRangeStart = 1001521, XrefRangeEnd = 1001527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001527, RefRangeEnd = 1001533, XrefRangeStart = 1001527, XrefRangeEnd = 1001533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379896, XrefRangeEnd = 1379898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1379907, RefRangeEnd = 1379908, XrefRangeStart = 1379898, XrefRangeEnd = 1379907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1379910, RefRangeEnd = 1379911, XrefRangeStart = 1379908, XrefRangeEnd = 1379910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Spawn_MoveSpeedBuffSystem componentSystem,
        ref Spawn_MoveSpeedBuffSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379911, XrefRangeEnd = 1379915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379915, XrefRangeEnd = 1379921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Spawn()
      {
        Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem>.NativeClassPtr, "<>c__DisplayClass_Spawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getMovement));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getSpeedModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getSpeedModifications));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (modificationStruct));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (commandBuffer));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_runtimes));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_ModifyMovementSpeedBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665320);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665321);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665322);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665323);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665324);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665325);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665326);
        Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100665327);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveSpeedBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuff> forParameter_moveSpeedBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1379794, RefRangeEnd = 1379795, XrefRangeStart = 1379787, XrefRangeEnd = 1379794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Spawn_MoveSpeedBuffSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1379802, RefRangeEnd = 1379803, XrefRangeStart = 1379795, XrefRangeEnd = 1379802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveSpeedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveSpeedBuff));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Spawn_MoveSpeedBuffSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100665328);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100665329);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveSpeedBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ModifyMovementSpeedBuff>.Runtime runtime_moveSpeedBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveSpeedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveSpeedBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Spawn_MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000004B1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000004B1$PostfixBurstDelegate");
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665330);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665331);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665332);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665333);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Spawn_MoveSpeedBuffSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000004B1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379803, XrefRangeEnd = 1379817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379817, XrefRangeEnd = 1379835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379835, XrefRangeEnd = 1379850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1379877, RefRangeEnd = 1379878, XrefRangeStart = 1379850, XrefRangeEnd = 1379877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000004B1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665334);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665335);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665336);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665337);
          Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665339);
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
            IL2CPP.il2cpp_field_static_get_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Spawn_MoveSpeedBuffSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
