// Decompiled with JetBrains decompiler
// Type: ProjectM.SetOwnerRotateTowardsMovementSystem
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
  public class SetOwnerRotateTowardsMovementSystem : SystemBase
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
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051087, XrefRangeEnd = 1051093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051093, XrefRangeEnd = 1051119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetOwnerRotateTowardsMovementSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051119, XrefRangeEnd = 1051137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1051162, RefRangeEnd = 1051163, XrefRangeStart = 1051137, XrefRangeEnd = 1051162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1051167, RefRangeEnd = 1051168, XrefRangeStart = 1051163, XrefRangeEnd = 1051167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetOwnerRotateTowardsMovementSystem()
    {
      Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SetOwnerRotateTowardsMovementSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr);
      SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, nameof (_ModificationSystem));
      SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, "<>Spawn_entityQuery");
      SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, "<>Spawn_profilerMarker");
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682547);
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682548);
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682549);
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682550);
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682551);
      SetOwnerRotateTowardsMovementSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, 100682552);
    }

    public SetOwnerRotateTowardsMovementSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __Spawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Spawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMovementSystem.NativeFieldInfoPtr___Spawn_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Modification
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_Id;
      [FieldOffset(0)]
      public Entity Target;
      [FieldOffset(8)]
      public ModificationId Id;

      static Modification()
      {
        Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.Modification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, nameof (Modification));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.Modification>.NativeClassPtr);
        SetOwnerRotateTowardsMovementSystem.Modification.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.Modification>.NativeClassPtr, nameof (Target));
        SetOwnerRotateTowardsMovementSystem.Modification.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.Modification>.NativeClassPtr, nameof (Id));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.Modification>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMovementSystem/<>c__DisplayClass3_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass3_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetOwnerRotateTowardsMovement rotateTowardsMouse)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouse;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (getTargetDirection));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (getModifications));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (modificationStruct));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (commandBuffer));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, 100682553);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, 100682554);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMovementSystem/ProjectM.<>c__DisplayClass_Spawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Spawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<TargetDirection> getTargetDirection;
      [FieldOffset(32)]
      public BufferFromEntity<BoolModificationBuffer> getModifications;
      [FieldOffset(72)]
      public ModificationStructure modificationStruct;
      [FieldOffset(104)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(120)]
      public SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051044, XrefRangeEnd = 1051062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetOwnerRotateTowardsMovement rotateTowardsMouse)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouse;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001521, RefRangeEnd = 1001527, XrefRangeStart = 1001521, XrefRangeEnd = 1001527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001527, RefRangeEnd = 1001533, XrefRangeStart = 1001527, XrefRangeEnd = 1001533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051062, XrefRangeEnd = 1051064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051073, RefRangeEnd = 1051074, XrefRangeStart = 1051064, XrefRangeEnd = 1051073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051076, RefRangeEnd = 1051077, XrefRangeStart = 1051074, XrefRangeEnd = 1051076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetOwnerRotateTowardsMovementSystem componentSystem,
        ref SetOwnerRotateTowardsMovementSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051077, XrefRangeEnd = 1051081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051081, XrefRangeEnd = 1051087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Spawn()
      {
        Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem>.NativeClassPtr, "<>c__DisplayClass_Spawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getTargetDirection));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getModifications));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (modificationStruct));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (commandBuffer));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_runtimes));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682555);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682556);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682557);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682558);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682559);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682560);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682561);
        SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682562);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotateTowardsMouse;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMovement> forParameter_rotateTowardsMouse;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050960, RefRangeEnd = 1050961, XrefRangeStart = 1050953, XrefRangeEnd = 1050960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          SetOwnerRotateTowardsMovementSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050968, RefRangeEnd = 1050969, XrefRangeStart = 1050961, XrefRangeEnd = 1050968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotateTowardsMouse));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMovementSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100682563);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100682564);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotateTowardsMouse;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMovement>.Runtime runtime_rotateTowardsMouse;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotateTowardsMouse));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMovementSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000044EC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000044EC$PostfixBurstDelegate");
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682565);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682566);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682567);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682568);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMovementSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000044EC$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050969, XrefRangeEnd = 1050983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050983, XrefRangeEnd = 1051001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051001, XrefRangeEnd = 1051016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1051043, RefRangeEnd = 1051044, XrefRangeStart = 1051016, XrefRangeEnd = 1051043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000044EC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682569);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682570);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682571);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682572);
          SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682574);
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
            IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMovementSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
