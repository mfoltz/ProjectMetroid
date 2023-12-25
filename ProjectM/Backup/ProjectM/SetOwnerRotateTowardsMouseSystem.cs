// Decompiled with JetBrains decompiler
// Type: ProjectM.SetOwnerRotateTowardsMouseSystem
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
  public class SetOwnerRotateTowardsMouseSystem : SystemBase
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
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050654, XrefRangeEnd = 1050660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050660, XrefRangeEnd = 1050686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetOwnerRotateTowardsMouseSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050686, XrefRangeEnd = 1050704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1050729, RefRangeEnd = 1050730, XrefRangeStart = 1050704, XrefRangeEnd = 1050729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1050734, RefRangeEnd = 1050735, XrefRangeStart = 1050730, XrefRangeEnd = 1050734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetOwnerRotateTowardsMouseSystem()
    {
      Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SetOwnerRotateTowardsMouseSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr);
      SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, nameof (_ModificationSystem));
      SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>Spawn_entityQuery");
      SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>Spawn_profilerMarker");
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682490);
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682491);
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682492);
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682493);
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682494);
      SetOwnerRotateTowardsMouseSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, 100682495);
    }

    public SetOwnerRotateTowardsMouseSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __Spawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Spawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetOwnerRotateTowardsMouseSystem.NativeFieldInfoPtr___Spawn_profilerMarker)) = value;
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
        Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.Modification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, nameof (Modification));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.Modification>.NativeClassPtr);
        SetOwnerRotateTowardsMouseSystem.Modification.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.Modification>.NativeClassPtr, nameof (Target));
        SetOwnerRotateTowardsMouseSystem.Modification.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.Modification>.NativeClassPtr, nameof (Id));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.Modification>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMouseSystem/<>c__DisplayClass3_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass3_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTargetDirection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0;
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
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetOwnerRotateTowardsMouse rotateTowardsMouse)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouse;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (getTargetDirection));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (getModifications));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (modificationStruct));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (commandBuffer));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, 100682496);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, 100682497);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Spawn")]
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
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass3_0_0;
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
      public SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(192)]
      public unsafe SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050611, XrefRangeEnd = 1050629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SetOwnerRotateTowardsMouse rotateTowardsMouse)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouse;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001521, RefRangeEnd = 1001527, XrefRangeStart = 1001521, XrefRangeEnd = 1001527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1001527, RefRangeEnd = 1001533, XrefRangeStart = 1001527, XrefRangeEnd = 1001533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050629, XrefRangeEnd = 1050631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1050640, RefRangeEnd = 1050641, XrefRangeStart = 1050631, XrefRangeEnd = 1050640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1050643, RefRangeEnd = 1050644, XrefRangeStart = 1050641, XrefRangeEnd = 1050643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetOwnerRotateTowardsMouseSystem componentSystem,
        ref SetOwnerRotateTowardsMouseSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050644, XrefRangeEnd = 1050648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050648, XrefRangeEnd = 1050654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Spawn()
      {
        Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem>.NativeClassPtr, "<>c__DisplayClass_Spawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getTargetDirection));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_getModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (getModifications));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (modificationStruct));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (commandBuffer));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (_runtimes));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_SetOwnerRotateTowardsMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682498);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682499);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682500);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682501);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682502);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682503);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682504);
        SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, 100682505);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotateTowardsMouse;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMouse> forParameter_rotateTowardsMouse;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050527, RefRangeEnd = 1050528, XrefRangeStart = 1050520, XrefRangeEnd = 1050527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetOwnerRotateTowardsMouseSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050535, RefRangeEnd = 1050536, XrefRangeStart = 1050528, XrefRangeEnd = 1050535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotateTowardsMouse));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetOwnerRotateTowardsMouseSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100682506);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, 100682507);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
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
          public LambdaParameterValueProvider_IComponentData<SetOwnerRotateTowardsMouse>.Runtime runtime_rotateTowardsMouse;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotateTowardsMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotateTowardsMouse));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000044CB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000044CB$PostfixBurstDelegate");
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682508);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682509);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682510);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682511);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetOwnerRotateTowardsMouseSystem/ProjectM.<>c__DisplayClass_Spawn/ProjectM.RunWithoutJobSystem_000044CB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050536, XrefRangeEnd = 1050550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050550, XrefRangeEnd = 1050568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050568, XrefRangeEnd = 1050583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1050610, RefRangeEnd = 1050611, XrefRangeStart = 1050583, XrefRangeEnd = 1050610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn>.NativeClassPtr, "RunWithoutJobSystem_000044CB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682512);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682513);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682514);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682515);
          SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682517);
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
            IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetOwnerRotateTowardsMouseSystem.__c__DisplayClass_Spawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
