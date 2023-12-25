// Decompiled with JetBrains decompiler
// Type: ProjectM.DisableWhenNoPlayersInRangeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class DisableWhenNoPlayersInRangeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartSimulationGroupBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserActivityGridSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableEntitiesChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableEntitiesChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableEntityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableEntityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpreadOutEnableJob;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableFeatureRequested;
    private static readonly System.IntPtr NativeFieldInfoPtr__FeatureIsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDebugLogDisabledEntitiesJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053496, XrefRangeEnd = 1053604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053604, XrefRangeEnd = 1053607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053607, XrefRangeEnd = 1053708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053740, RefRangeEnd = 1053741, XrefRangeStart = 1053708, XrefRangeEnd = 1053740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Disable(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      ref DisableWhenNoPlayersInRangeSystem.Input input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_Disable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1053757, RefRangeEnd = 1053760, XrefRangeStart = 1053741, XrefRangeEnd = 1053757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableEntity(
      EntityCommandBuffer commandBuffer,
      ref DisableWhenNoPlayersInRangeSystem.Input input,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_DisableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053792, RefRangeEnd = 1053793, XrefRangeStart = 1053760, XrefRangeEnd = 1053792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Enable(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      ref DisableWhenNoPlayersInRangeSystem.Input input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_Enable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1053809, RefRangeEnd = 1053812, XrefRangeStart = 1053793, XrefRangeEnd = 1053809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EnableEntity(
      EntityCommandBuffer commandBuffer,
      ref DisableWhenNoPlayersInRangeSystem.Input input,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_EnableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DisableWhenNoPlayersInRangeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1053826, RefRangeEnd = 1053828, XrefRangeStart = 1053812, XrefRangeEnd = 1053826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053853, RefRangeEnd = 1053854, XrefRangeStart = 1053828, XrefRangeEnd = 1053853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDebugLogDisabledEntitiesJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr___GetEntityQuery_ForDebugLogDisabledEntitiesJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DisableWhenNoPlayersInRangeSystem()
    {
      Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DisableWhenNoPlayersInRangeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr);
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_EventPrefab));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__LastFrameEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_LastFrameEventQuery));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__StartSimulationGroupBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_StartSimulationGroupBarrier));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__UserActivityGridSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_UserActivityGridSystem));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_EnableEntities));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntitiesChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_EnableEntitiesChunkRange));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntitiesChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_DisableEntitiesChunkRange));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_EnableEntityQuery));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_DisableEntityQuery));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__SpreadOutEnableJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_SpreadOutEnableJob));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr_DisableFeatureRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (DisableFeatureRequested));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__FeatureIsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (_FeatureIsDisabled));
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>DebugLogDisabledEntitiesJob_entityQuery");
      DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>DebugLogDisabledEntitiesJob_profilerMarker");
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682872);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682873);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682874);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_Disable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682875);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_DisableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682876);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_Enable_Private_Static_Void_EntityCommandBuffer_Entity_byref_Input_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682877);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_EnableEntity_Private_Static_Void_EntityCommandBuffer_byref_Input_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682878);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682879);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682880);
      DisableWhenNoPlayersInRangeSystem.NativeMethodInfoPtr___GetEntityQuery_ForDebugLogDisabledEntitiesJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, 100682881);
    }

    public DisableWhenNoPlayersInRangeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity _EventPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EventPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EventPrefab)) = value;
      }
    }

    public unsafe EntityQuery _LastFrameEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__LastFrameEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__LastFrameEventQuery)) = value;
      }
    }

    public unsafe StartSimulationGroupBarrier _StartSimulationGroupBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__StartSimulationGroupBarrier));
        return pointer == System.IntPtr.Zero ? (StartSimulationGroupBarrier) null : new StartSimulationGroupBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__StartSimulationGroupBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UserActivityGridSystem _UserActivityGridSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__UserActivityGridSystem));
        return pointer == System.IntPtr.Zero ? (UserActivityGridSystem) null : new UserActivityGridSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__UserActivityGridSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeQueue<Entity> _EnableEntities
    {
      get
      {
        return *(NativeQueue<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChunkRange _EnableEntitiesChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntitiesChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntitiesChunkRange)) = value;
      }
    }

    public unsafe ChunkRange _DisableEntitiesChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntitiesChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntitiesChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _EnableEntityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__EnableEntityQuery)) = value;
      }
    }

    public unsafe EntityQuery _DisableEntityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__DisableEntityQuery)) = value;
      }
    }

    public unsafe bool _SpreadOutEnableJob
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__SpreadOutEnableJob));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__SpreadOutEnableJob)) = value;
      }
    }

    public unsafe bool DisableFeatureRequested
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr_DisableFeatureRequested));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr_DisableFeatureRequested)) = value;
      }
    }

    public unsafe bool _FeatureIsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__FeatureIsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr__FeatureIsDisabled)) = value;
      }
    }

    public unsafe EntityQuery __DebugLogDisabledEntitiesJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DebugLogDisabledEntitiesJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.NativeFieldInfoPtr___DebugLogDisabledEntitiesJob_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Input
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetWasDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBehaviourTreeInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroyWhenNoPlayersAreNear;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnChainConstants;
      private static readonly System.IntPtr NativeFieldInfoPtr_EventPrefab;
      [FieldOffset(0)]
      public BufferFromEntity<LinkedEntityGroup> GetLinkedEntityGroup;
      [FieldOffset(40)]
      public BufferFromEntity<AttachedBuffer> GetAttachedBuffer;
      [FieldOffset(80)]
      public ComponentDataFromEntity<Disabled> GetDisabled;
      [FieldOffset(112)]
      public ComponentDataFromEntity<WasDisabledBeforeNoPlayersInRange> GetWasDisabled;
      [FieldOffset(144)]
      public ComponentDataFromEntity<BehaviourTreeInstance> GetBehaviourTreeInstance;
      [FieldOffset(176)]
      public ComponentDataFromEntity<DestroyWhenNoCharacterNearbyAfterDuration> GetDestroyWhenNoPlayersAreNear;
      [FieldOffset(208)]
      public ComponentDataFromEntity<SpawnChainData.SpawnChainConstants> GetSpawnChainConstants;
      [FieldOffset(240)]
      public Entity EventPrefab;

      static Input()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (Input));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetLinkedEntityGroup));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetAttachedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetAttachedBuffer));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetDisabled));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetWasDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetWasDisabled));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetBehaviourTreeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetBehaviourTreeInstance));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetDestroyWhenNoPlayersAreNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetDestroyWhenNoPlayersAreNear));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_GetSpawnChainConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (GetSpawnChainConstants));
        DisableWhenNoPlayersInRangeSystem.Input.NativeFieldInfoPtr_EventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, nameof (EventPrefab));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.Input>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DisableEntitiesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Input;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanPreventDisableWhenNoPlayersInRangeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SyncBoundingBoxType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DisableWhenNoPlayersInRangeSystem.Input Input;
      [FieldOffset(248)]
      public UserActivityGrid UserActivityGrid;
      [FieldOffset(392)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(424)]
      public ComponentTypeHandle<CanPreventDisableWhenNoPlayersInRange> CanPreventDisableWhenNoPlayersInRangeType;
      [FieldOffset(456)]
      public ComponentTypeHandle<SyncBoundingBox> SyncBoundingBoxType;
      [FieldOffset(488)]
      public EntityTypeHandle EntityType;
      [FieldOffset(492)]
      public ChunkRange ChunkRange;
      [FieldOffset(504)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053383, XrefRangeEnd = 1053407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DisableEntitiesJob()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (DisableEntitiesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (Input));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_UserActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (UserActivityGrid));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (TranslationType));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_CanPreventDisableWhenNoPlayersInRangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (CanPreventDisableWhenNoPlayersInRangeType));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_SyncBoundingBoxType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (SyncBoundingBoxType));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (EntityType));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (ChunkRange));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, nameof (CommandBuffer));
        DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, 100682882);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.DisableEntitiesJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EnableEntitiesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UserActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SyncBoundingBoxType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EnableEntitiesWriter;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpreadOutWork;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public UserActivityGrid UserActivityGrid;
      [FieldOffset(144)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(176)]
      public ComponentTypeHandle<SyncBoundingBox> SyncBoundingBoxType;
      [FieldOffset(208)]
      public EntityTypeHandle EntityType;
      [FieldOffset(216)]
      public NativeQueue<Entity> EnableEntitiesWriter;
      [FieldOffset(240)]
      public ChunkRange ChunkRange;
      [FieldOffset(252)]
      public bool SpreadOutWork;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053407, XrefRangeEnd = 1053424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EnableEntitiesJob()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, nameof (EnableEntitiesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_UserActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (UserActivityGrid));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (TranslationType));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_SyncBoundingBoxType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (SyncBoundingBoxType));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (EntityType));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_EnableEntitiesWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (EnableEntitiesWriter));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (ChunkRange));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeFieldInfoPtr_SpreadOutWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, nameof (SpreadOutWork));
        DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, 100682883);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.EnableEntitiesJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DisableWhenNoPlayersInRangeSystem/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_enableEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_enableEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (enableEntities));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (input));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, 100682884);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, 100682885);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, data));
      }

      public unsafe DisableWhenNoPlayersInRangeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DisableWhenNoPlayersInRangeSystem) null : new DisableWhenNoPlayersInRangeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe NativeQueue<Entity> enableEntities
      {
        get
        {
          return *(NativeQueue<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_enableEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_enableEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DisableWhenNoPlayersInRangeSystem.Input input
      {
        get
        {
          return *(DisableWhenNoPlayersInRangeSystem.Input*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_input));
        }
        [param: In] set
        {
          *(DisableWhenNoPlayersInRangeSystem.Input*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_input)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DisableWhenNoPlayersInRangeSystem/<>c__DisplayClass17_1")]
    public sealed class __c__DisplayClass17_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_enableEntitiesWriter;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_1()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>c__DisplayClass17_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_enableEntitiesWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, nameof (enableEntitiesWriter));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, "CS$<>8__locals1");
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, 100682886);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, 100682887);
      }

      public __c__DisplayClass17_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1>.NativeClassPtr, data));
      }

      public unsafe NativeQueue<Entity>.ParallelWriter enableEntitiesWriter
      {
        get
        {
          return *(NativeQueue<Entity>.ParallelWriter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_enableEntitiesWriter));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_enableEntitiesWriter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<Entity>.ParallelWriter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
          return new DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.DisableWhenNoPlayersInRangeSystem/ProjectM.<>c__DisplayClass_DebugLogDisabledEntitiesJob")]
    public sealed class __c__DisplayClass_DebugLogDisabledEntitiesJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_enableEntitiesWriter;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053463, RefRangeEnd = 1053464, XrefRangeStart = 1053424, XrefRangeEnd = 1053463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053465, RefRangeEnd = 1053466, XrefRangeStart = 1053464, XrefRangeEnd = 1053465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053467, RefRangeEnd = 1053468, XrefRangeStart = 1053466, XrefRangeEnd = 1053467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053468, XrefRangeEnd = 1053470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053473, RefRangeEnd = 1053474, XrefRangeStart = 1053470, XrefRangeEnd = 1053473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053476, RefRangeEnd = 1053477, XrefRangeStart = 1053474, XrefRangeEnd = 1053476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DisableWhenNoPlayersInRangeSystem componentSystem,
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053477, XrefRangeEnd = 1053483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DebugLogDisabledEntitiesJob()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>c__DisplayClass_DebugLogDisabledEntitiesJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, "<>4__this");
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_enableEntitiesWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, nameof (enableEntitiesWriter));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, nameof (_runtimes));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682888);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682889);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682890);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682891);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682892);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682893);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, 100682894);
      }

      public __c__DisplayClass_DebugLogDisabledEntitiesJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_DebugLogDisabledEntitiesJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, data));
      }

      public unsafe DisableWhenNoPlayersInRangeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DisableWhenNoPlayersInRangeSystem) null : new DisableWhenNoPlayersInRangeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeQueue<Entity>.ParallelWriter enableEntitiesWriter
      {
        get
        {
          return *(NativeQueue<Entity>.ParallelWriter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_enableEntitiesWriter));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_enableEntitiesWriter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<Entity>.ParallelWriter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DisableWhenNoPlayersInRangeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr, 100682895);
          DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr, 100682896);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_DebugLogDisabledEntitiesJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DisableWhenNoPlayersInRangeSystem/ProjectM.<>c__DisplayClass_CreateEnableEventsJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateEnableEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_enableEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_0_0;
      [FieldOffset(0)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(16)]
      public NativeQueue<Entity> enableEntities;
      [FieldOffset(40)]
      public DisableWhenNoPlayersInRangeSystem.Input input;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053483, XrefRangeEnd = 1053492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053492, RefRangeEnd = 1053493, XrefRangeStart = 1053492, XrefRangeEnd = 1053492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053493, XrefRangeEnd = 1053494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1053495, RefRangeEnd = 1053496, XrefRangeStart = 1053494, XrefRangeEnd = 1053495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DisableWhenNoPlayersInRangeSystem componentSystem,
        ref DisableWhenNoPlayersInRangeSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateEnableEventsJob()
      {
        Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem>.NativeClassPtr, "<>c__DisplayClass_CreateEnableEventsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeFieldInfoPtr_enableEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, nameof (enableEntities));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, nameof (input));
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, 100682897);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, 100682898);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, 100682899);
        DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DisableWhenNoPlayersInRangeSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, 100682900);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableWhenNoPlayersInRangeSystem.__c__DisplayClass_CreateEnableEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
