// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveSystem_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using ProjectM.Network;
using ProjectM.Pathfinding;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AiMoveSystem_Server : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AiMoveQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___AiMove_ForceLookAtTarget_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___WriteInterpolationData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ServerPopPathBufferJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ServerCopyPathBufferToAiMoveJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCircleDirAndDistance_OnCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCircleDirAndDistance_EveryFrame_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSeekDistance_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldForceLookAtTarget_Private_Static_Boolean_byref_AiMove_Server_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SchedulePreMoveJobs_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerPopPathBufferJob_Private_Static_Void_Single_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ServerCopyPathBufferToAiMoveJob_Private_Static_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTargetPositionFromPositionOrEntity_Private_Static_Boolean_byref_AiMove_Server_ComponentDataFromEntity_1_Translation_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetEntity_Private_Static_Entity_byref_AiMove_Server_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAiMove_ForceLookAtTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForWriteInterpolationData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForServerPopPathBufferJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForServerCopyPathBufferToAiMoveJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_OnCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_EveryFrame_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSeekDistance_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052945, XrefRangeEnd = 1053005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053005, XrefRangeEnd = 1053011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Server.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053011, XrefRangeEnd = 1053052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053052, RefRangeEnd = 1053053, XrefRangeStart = 1053052, XrefRangeEnd = 1053052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldForceLookAtTarget([In] ref AiMove_Server aiMoveServer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref aiMoveServer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_ShouldForceLookAtTarget_Private_Static_Boolean_byref_AiMove_Server_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053106, RefRangeEnd = 1053107, XrefRangeStart = 1053053, XrefRangeEnd = 1053106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SchedulePreMoveJobs(bool isNpcsEnabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &isNpcsEnabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_SchedulePreMoveJobs_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053122, RefRangeEnd = 1053123, XrefRangeStart = 1053107, XrefRangeEnd = 1053122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ServerPopPathBufferJob(
      float deltaTime,
      DynamicBuffer<PathBuffer> pathBuffer,
      [In] ref Translation translation,
      [In] ref MapCollision mapCollision,
      [In] ref Movement movement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pathBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_ServerPopPathBufferJob_Private_Static_Void_Single_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053135, RefRangeEnd = 1053136, XrefRangeStart = 1053123, XrefRangeEnd = 1053135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ServerCopyPathBufferToAiMoveJob(
      DynamicBuffer<PathBuffer> pathBuffer,
      ref AiMove_Shared aiMoveShared,
      [In] ref AiMove_Server aiMoveServer,
      [In] ref MapCollision mapCollision,
      [In] ref Translation translation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pathBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_ServerCopyPathBufferToAiMoveJob_Private_Static_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1053144, RefRangeEnd = 1053146, XrefRangeStart = 1053136, XrefRangeEnd = 1053144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTargetPositionFromPositionOrEntity(
      [In] ref AiMove_Server aiMoveServer,
      ComponentDataFromEntity<Translation> getTranslation,
      out float2 targetPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref aiMoveServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_TryGetTargetPositionFromPositionOrEntity_Private_Static_Boolean_byref_AiMove_Server_ComponentDataFromEntity_1_Translation_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053148, RefRangeEnd = 1053149, XrefRangeStart = 1053146, XrefRangeEnd = 1053148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetTargetEntity([In] ref AiMove_Server aiMoveServer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref aiMoveServer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr_GetTargetEntity_Private_Static_Entity_byref_AiMove_Server_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AiMoveSystem_Server()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053149, XrefRangeEnd = 1053172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053200, RefRangeEnd = 1053201, XrefRangeStart = 1053172, XrefRangeEnd = 1053200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAiMove_ForceLookAtTarget_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForAiMove_ForceLookAtTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053232, RefRangeEnd = 1053233, XrefRangeStart = 1053201, XrefRangeEnd = 1053232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForWriteInterpolationData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForWriteInterpolationData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053264, RefRangeEnd = 1053265, XrefRangeStart = 1053233, XrefRangeEnd = 1053264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForServerPopPathBufferJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForServerPopPathBufferJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053299, RefRangeEnd = 1053300, XrefRangeStart = 1053265, XrefRangeEnd = 1053299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForServerCopyPathBufferToAiMoveJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForServerCopyPathBufferToAiMoveJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053300, XrefRangeEnd = 1053316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCircleDirAndDistance_OnCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_OnCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053338, RefRangeEnd = 1053339, XrefRangeStart = 1053316, XrefRangeEnd = 1053338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCircleDirAndDistance_EveryFrame_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_EveryFrame_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1053367, RefRangeEnd = 1053368, XrefRangeStart = 1053339, XrefRangeEnd = 1053367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSeekDistance_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSeekDistance_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AiMoveSystem_Server()
    {
      Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AiMoveSystem_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr);
      AiMoveSystem_Server.NativeFieldInfoPtr__AiMoveQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, nameof (_AiMoveQuery));
      AiMoveSystem_Server.NativeFieldInfoPtr__ServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, nameof (_ServerDebugSettingsAccessor));
      AiMoveSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, nameof (_ServerTimeAccessor));
      AiMoveSystem_Server.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, nameof (_CurveCollectionSystem));
      AiMoveSystem_Server.NativeFieldInfoPtr___AiMove_ForceLookAtTarget_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>AiMove_ForceLookAtTarget_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___WriteInterpolationData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>WriteInterpolationData_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___ServerPopPathBufferJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>ServerPopPathBufferJob_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___ServerCopyPathBufferToAiMoveJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>ServerCopyPathBufferToAiMoveJob_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_OnCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>UpdateCircleDirAndDistance_OnCast_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_EveryFrame_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>UpdateCircleDirAndDistance_EveryFrame_entityQuery");
      AiMoveSystem_Server.NativeFieldInfoPtr___UpdateSeekDistance_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>UpdateSeekDistance_entityQuery");
      AiMoveSystem_Server.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682787);
      AiMoveSystem_Server.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682788);
      AiMoveSystem_Server.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682789);
      AiMoveSystem_Server.NativeMethodInfoPtr_ShouldForceLookAtTarget_Private_Static_Boolean_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682790);
      AiMoveSystem_Server.NativeMethodInfoPtr_SchedulePreMoveJobs_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682791);
      AiMoveSystem_Server.NativeMethodInfoPtr_ServerPopPathBufferJob_Private_Static_Void_Single_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682792);
      AiMoveSystem_Server.NativeMethodInfoPtr_ServerCopyPathBufferToAiMoveJob_Private_Static_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682793);
      AiMoveSystem_Server.NativeMethodInfoPtr_TryGetTargetPositionFromPositionOrEntity_Private_Static_Boolean_byref_AiMove_Server_ComponentDataFromEntity_1_Translation_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682794);
      AiMoveSystem_Server.NativeMethodInfoPtr_GetTargetEntity_Private_Static_Entity_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682795);
      AiMoveSystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682796);
      AiMoveSystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682797);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForAiMove_ForceLookAtTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682798);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForWriteInterpolationData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682799);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForServerPopPathBufferJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682800);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForServerCopyPathBufferToAiMoveJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682801);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_OnCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682802);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCircleDirAndDistance_EveryFrame_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682803);
      AiMoveSystem_Server.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSeekDistance_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, 100682804);
    }

    public AiMoveSystem_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _AiMoveQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__AiMoveQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__AiMoveQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__ServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__ServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __AiMove_ForceLookAtTarget_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___AiMove_ForceLookAtTarget_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___AiMove_ForceLookAtTarget_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __WriteInterpolationData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___WriteInterpolationData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___WriteInterpolationData_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ServerPopPathBufferJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___ServerPopPathBufferJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___ServerPopPathBufferJob_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ServerCopyPathBufferToAiMoveJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___ServerCopyPathBufferToAiMoveJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___ServerCopyPathBufferToAiMoveJob_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCircleDirAndDistance_OnCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_OnCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_OnCast_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCircleDirAndDistance_EveryFrame_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_EveryFrame_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateCircleDirAndDistance_EveryFrame_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSeekDistance_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateSeekDistance_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.NativeFieldInfoPtr___UpdateSeekDistance_entityQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AiMoveJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MovementType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AiMoveSharedType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AiMoveServerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityInputType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurveLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAIMove_Private_Void_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_byref_Translation_byref_Movement_byref_MapCollision_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentGoalDistance_Private_Static_Single_byref_AiMove_Server_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveToPositionOrEntity_Private_Boolean_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_float2_byref_float2_0;
      [FieldOffset(0)]
      public float DeltaTime;
      [FieldOffset(8)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(40)]
      public ComponentTypeHandle<Movement> MovementType;
      [FieldOffset(72)]
      public ComponentTypeHandle<Dead> DeadType;
      [FieldOffset(104)]
      public ComponentTypeHandle<MapCollision> MapCollisionType;
      [FieldOffset(136)]
      public ComponentTypeHandle<AiMove_Shared> AiMoveSharedType;
      [FieldOffset(168)]
      public ComponentTypeHandle<AiMove_Server> AiMoveServerType;
      [FieldOffset(200)]
      public ComponentTypeHandle<EntityInput> EntityInputType;
      [FieldOffset(232)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(264)]
      public CurveCollection CurveLookup;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052557, XrefRangeEnd = 1052604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052618, RefRangeEnd = 1052619, XrefRangeStart = 1052604, XrefRangeEnd = 1052618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateAIMove(
        ref AiMove_Server aiMoveServer,
        ref EntityInput entityInput,
        [In] ref AiMove_Shared aiMoveShared,
        [In] ref Translation translation,
        [In] ref Movement movement,
        [In] ref MapCollision mapCollision)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_UpdateAIMove_Private_Void_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_byref_Translation_byref_Movement_byref_MapCollision_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052619, RefRangeEnd = 1052620, XrefRangeStart = 1052619, XrefRangeEnd = 1052619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float GetCurrentGoalDistance([In] ref AiMove_Server aiMoveServer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_GetCurrentGoalDistance_Private_Static_Single_byref_AiMove_Server_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052630, RefRangeEnd = 1052631, XrefRangeStart = 1052620, XrefRangeEnd = 1052630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryMoveToPositionOrEntity(
        ref AiMove_Server aiMoveServer,
        ref EntityInput entityInput,
        [In] ref AiMove_Shared aiMoveShared,
        float2 position,
        out float2 targetPosition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetPosition;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_TryMoveToPositionOrEntity_Private_Boolean_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_float2_byref_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static AiMoveJob()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, nameof (AiMoveJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr);
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (DeltaTime));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (TranslationType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (MovementType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_DeadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (DeadType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_MapCollisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (MapCollisionType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_AiMoveSharedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (AiMoveSharedType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_AiMoveServerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (AiMoveServerType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_EntityInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (EntityInputType));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (GetTranslation));
        AiMoveSystem_Server.AiMoveJob.NativeFieldInfoPtr_CurveLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, nameof (CurveLookup));
        AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, 100682805);
        AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_UpdateAIMove_Private_Void_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_byref_Translation_byref_Movement_byref_MapCollision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, 100682806);
        AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_GetCurrentGoalDistance_Private_Static_Single_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, 100682807);
        AiMoveSystem_Server.AiMoveJob.NativeMethodInfoPtr_TryMoveToPositionOrEntity_Private_Boolean_byref_AiMove_Server_byref_EntityInput_byref_AiMove_Shared_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, 100682808);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.AiMoveJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_0_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_0_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_2_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6_0(
        ref TargetDirection targetDirection,
        ref DynamicBuffer<BoolModificationBuffer> rotateTowardsMouseModifications,
        [In] ref AiMove_Server aiMoveServer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref targetDirection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouseModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c.NativeMethodInfoPtr__OnUpdate_b__6_0_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__8_0(
        ref NetworkInterpolated_Shared networkInterpolated,
        [In] ref AiMove_Server aiMoveServer,
        [In] ref BehaviourTreeState state,
        [In] ref MiscAiGameplayData miscAiGameplayData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref networkInterpolated;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref state;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref miscAiGameplayData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c.NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_0_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__8_2(
        DynamicBuffer<PathBuffer> pathBuffer,
        ref AiMove_Shared aiMoveShared,
        [In] ref AiMove_Server aiMoveServer,
        [In] ref MapCollision mapCollision,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &pathBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c.NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_2_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr);
        AiMoveSystem_Server.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, "<>9");
        AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, "<>9__6_0");
        AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, "<>9__8_0");
        AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, "<>9__8_2");
        AiMoveSystem_Server.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, 100682810);
        AiMoveSystem_Server.__c.NativeMethodInfoPtr__OnUpdate_b__6_0_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, 100682811);
        AiMoveSystem_Server.__c.NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_0_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, 100682812);
        AiMoveSystem_Server.__c.NativeMethodInfoPtr__SchedulePreMoveJobs_b__8_2_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c>.NativeClassPtr, 100682813);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe AiMoveSystem_Server.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AiMoveSystem_Server.__c) null : new AiMoveSystem_Server.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RRI<TargetDirection, DynamicBuffer<BoolModificationBuffer>, AiMove_Server> __9__6_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__6_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RRI<TargetDirection, DynamicBuffer<BoolModificationBuffer>, AiMove_Server>) null : new RRI<TargetDirection, DynamicBuffer<BoolModificationBuffer>, AiMove_Server>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RIII<NetworkInterpolated_Shared, AiMove_Server, BehaviourTreeState, MiscAiGameplayData> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RIII<NetworkInterpolated_Shared, AiMove_Server, BehaviourTreeState, MiscAiGameplayData>) null : new RIII<NetworkInterpolated_Shared, AiMove_Server, BehaviourTreeState, MiscAiGameplayData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VRIII<DynamicBuffer<PathBuffer>, AiMove_Shared, AiMove_Server, MapCollision, Translation> __9__8_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VRIII<DynamicBuffer<PathBuffer>, AiMove_Shared, AiMove_Server, MapCollision, Translation>) null : new VRIII<DynamicBuffer<PathBuffer>, AiMove_Shared, AiMove_Server, MapCollision, Translation>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Server.__c.NativeFieldInfoPtr___9__8_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_elapsedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__1_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__3_Internal_Void_byref_AbilityPreCastFinishedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__4_Internal_Void_byref_AiMove_Server_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SchedulePreMoveJobs_b__5_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__1(
        DynamicBuffer<PathBuffer> pathBuffer,
        [In] ref Translation translation,
        [In] ref MapCollision mapCollision,
        [In] ref Movement movement)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &pathBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__1_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__3([In] ref AbilityPreCastFinishedEvent castFinishedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castFinishedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__3_Internal_Void_byref_AbilityPreCastFinishedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__4(ref AiMove_Server aiMoveServer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__4_Internal_Void_byref_AiMove_Server_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SchedulePreMoveJobs_b__5(
        ref AiMove_Server aiMoveServer,
        [In] ref AiMove_Shared aiMoveShared,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__5_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, nameof (deltaTime));
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_elapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, nameof (elapsedTime));
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, nameof (random));
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, nameof (getTranslation));
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, 100682814);
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__1_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, 100682815);
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__3_Internal_Void_byref_AbilityPreCastFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, 100682816);
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__4_Internal_Void_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, 100682817);
        AiMoveSystem_Server.__c__DisplayClass8_0.NativeMethodInfoPtr__SchedulePreMoveJobs_b__5_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, 100682818);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe AiMoveSystem_Server __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AiMoveSystem_Server) null : new AiMoveSystem_Server(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double elapsedTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_elapsedTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_elapsedTime)) = value;
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Server.__c__DisplayClass8_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_AiMove_ForceLookAtTarget")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AiMove_ForceLookAtTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
      [FieldOffset(0)]
      public AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052653, RefRangeEnd = 1052654, XrefRangeStart = 1052651, XrefRangeEnd = 1052653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref TargetDirection targetDirection,
        ref DynamicBuffer<BoolModificationBuffer> rotateTowardsMouseModifications,
        [In] ref AiMove_Server aiMoveServer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref targetDirection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotateTowardsMouseModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052654, XrefRangeEnd = 1052656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052667, RefRangeEnd = 1052668, XrefRangeStart = 1052656, XrefRangeEnd = 1052667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052669, RefRangeEnd = 1052670, XrefRangeStart = 1052668, XrefRangeEnd = 1052669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AiMove_ForceLookAtTarget()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_AiMove_ForceLookAtTarget");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TargetDirection_byref_DynamicBuffer_1_BoolModificationBuffer_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, 100682819);
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, 100682820);
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, 100682821);
        AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, 100682822);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_targetDirection;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotateTowardsMouseModifications;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveServer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TargetDirection> forParameter_targetDirection;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<BoolModificationBuffer> forParameter_rotateTowardsMouseModifications;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Server> forParameter_aiMoveServer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052640, RefRangeEnd = 1052641, XrefRangeStart = 1052631, XrefRangeEnd = 1052640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052650, RefRangeEnd = 1052651, XrefRangeStart = 1052641, XrefRangeEnd = 1052650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_targetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_targetDirection));
          AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotateTowardsMouseModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotateTowardsMouseModifications));
          AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveServer));
          AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, 100682823);
          AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, 100682824);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_targetDirection;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotateTowardsMouseModifications;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveServer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TargetDirection>.Runtime runtime_targetDirection;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<BoolModificationBuffer>.Runtime runtime_rotateTowardsMouseModifications;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Server>.Runtime runtime_aiMoveServer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_targetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_targetDirection));
            AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotateTowardsMouseModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotateTowardsMouseModifications));
            AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveServer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_AiMove_ForceLookAtTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_WriteInterpolationData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_WriteInterpolationData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
      [FieldOffset(0)]
      public AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052696, RefRangeEnd = 1052697, XrefRangeStart = 1052696, XrefRangeEnd = 1052696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref NetworkInterpolated_Shared networkInterpolated,
        [In] ref AiMove_Server aiMoveServer,
        [In] ref BehaviourTreeState state,
        [In] ref MiscAiGameplayData miscAiGameplayData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref networkInterpolated;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref state;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref miscAiGameplayData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052697, XrefRangeEnd = 1052699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052713, RefRangeEnd = 1052714, XrefRangeStart = 1052699, XrefRangeEnd = 1052713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052739, RefRangeEnd = 1052740, XrefRangeStart = 1052714, XrefRangeEnd = 1052739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_WriteInterpolationData()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_WriteInterpolationData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkInterpolated_Shared_byref_AiMove_Server_byref_BehaviourTreeState_byref_MiscAiGameplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, 100682825);
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, 100682826);
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, 100682827);
        AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, 100682828);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkInterpolated;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_state;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_miscAiGameplayData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared> forParameter_networkInterpolated;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Server> forParameter_aiMoveServer;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<BehaviourTreeState> forParameter_state;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<MiscAiGameplayData> forParameter_miscAiGameplayData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052682, RefRangeEnd = 1052683, XrefRangeStart = 1052670, XrefRangeEnd = 1052682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052695, RefRangeEnd = 1052696, XrefRangeStart = 1052683, XrefRangeEnd = 1052695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkInterpolated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkInterpolated));
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveServer));
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_state));
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_miscAiGameplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_miscAiGameplayData));
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, 100682829);
          AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, 100682830);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkInterpolated;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_state;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_miscAiGameplayData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared>.Runtime runtime_networkInterpolated;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Server>.Runtime runtime_aiMoveServer;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<BehaviourTreeState>.Runtime runtime_state;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<MiscAiGameplayData>.Runtime runtime_miscAiGameplayData;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkInterpolated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkInterpolated));
            AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveServer));
            AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_state));
            AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_miscAiGameplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_miscAiGameplayData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_WriteInterpolationData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_ServerPopPathBufferJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ServerPopPathBufferJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052767, RefRangeEnd = 1052768, XrefRangeStart = 1052766, XrefRangeEnd = 1052767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<PathBuffer> pathBuffer,
        [In] ref Translation translation,
        [In] ref MapCollision mapCollision,
        [In] ref Movement movement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &pathBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 979865, RefRangeEnd = 979889, XrefRangeStart = 979865, XrefRangeEnd = 979889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052768, XrefRangeEnd = 1052770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052784, RefRangeEnd = 1052785, XrefRangeStart = 1052770, XrefRangeEnd = 1052784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052787, RefRangeEnd = 1052788, XrefRangeStart = 1052785, XrefRangeEnd = 1052787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiMoveSystem_Server componentSystem,
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ServerPopPathBufferJob()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_ServerPopPathBufferJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, nameof (deltaTime));
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_Translation_byref_MapCollision_byref_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, 100682831);
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, 100682832);
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, 100682833);
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, 100682834);
        AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, 100682835);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pathBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movement;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<PathBuffer> forParameter_pathBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MapCollision> forParameter_mapCollision;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Movement> forParameter_movement;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052752, RefRangeEnd = 1052753, XrefRangeStart = 1052740, XrefRangeEnd = 1052752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052765, RefRangeEnd = 1052766, XrefRangeStart = 1052753, XrefRangeEnd = 1052765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pathBuffer));
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapCollision));
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movement));
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, 100682836);
          AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, 100682837);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pathBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapCollision;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movement;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<PathBuffer>.Runtime runtime_pathBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<MapCollision>.Runtime runtime_mapCollision;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Movement>.Runtime runtime_movement;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pathBuffer));
            AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapCollision));
            AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movement));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerPopPathBufferJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_ServerCopyPathBufferToAiMoveJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ServerCopyPathBufferToAiMoveJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
      [FieldOffset(0)]
      public AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(168)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052821, RefRangeEnd = 1052822, XrefRangeStart = 1052820, XrefRangeEnd = 1052821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<PathBuffer> pathBuffer,
        ref AiMove_Shared aiMoveShared,
        [In] ref AiMove_Server aiMoveServer,
        [In] ref MapCollision mapCollision,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &pathBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052822, XrefRangeEnd = 1052824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052841, RefRangeEnd = 1052842, XrefRangeStart = 1052824, XrefRangeEnd = 1052841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052843, RefRangeEnd = 1052844, XrefRangeStart = 1052842, XrefRangeEnd = 1052843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ServerCopyPathBufferToAiMoveJob()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_ServerCopyPathBufferToAiMoveJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_PathBuffer_byref_AiMove_Shared_byref_AiMove_Server_byref_MapCollision_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, 100682838);
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, 100682839);
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, 100682840);
        AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, 100682841);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pathBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveShared;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<PathBuffer> forParameter_pathBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Shared> forParameter_aiMoveShared;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Server> forParameter_aiMoveServer;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<MapCollision> forParameter_mapCollision;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052803, RefRangeEnd = 1052804, XrefRangeStart = 1052788, XrefRangeEnd = 1052803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052819, RefRangeEnd = 1052820, XrefRangeStart = 1052804, XrefRangeEnd = 1052819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pathBuffer));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveShared));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveServer));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapCollision));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, 100682842);
          AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, 100682843);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pathBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapCollision;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<PathBuffer>.Runtime runtime_pathBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Shared>.Runtime runtime_aiMoveShared;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Server>.Runtime runtime_aiMoveServer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<MapCollision>.Runtime runtime_mapCollision;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pathBuffer));
            AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveShared));
            AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveServer));
            AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapCollision));
            AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_ServerCopyPathBufferToAiMoveJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_UpdateCircleDirAndDistance_OnCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCircleDirAndDistance_OnCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_elapsedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AiMove_Server_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastFinishedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0;
      [FieldOffset(0)]
      public double elapsedTime;
      [FieldOffset(8)]
      public Unity.Mathematics.Random random;
      [FieldOffset(16)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_0;
      [FieldOffset(48)]
      public ComponentDataFromEntity<AiMove_Server> _ComponentDataFromEntity_AiMove_Server_1;
      [FieldOffset(80)]
      public AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052852, XrefRangeEnd = 1052865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityPreCastFinishedEvent castFinishedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castFinishedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastFinishedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1052865, RefRangeEnd = 1052867, XrefRangeStart = 1052865, XrefRangeEnd = 1052865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052867, XrefRangeEnd = 1052869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052874, RefRangeEnd = 1052875, XrefRangeStart = 1052869, XrefRangeEnd = 1052874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052883, RefRangeEnd = 1052884, XrefRangeStart = 1052875, XrefRangeEnd = 1052883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiMoveSystem_Server componentSystem,
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCircleDirAndDistance_OnCast()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_UpdateCircleDirAndDistance_OnCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr_elapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (elapsedTime));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (random));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_0));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr__ComponentDataFromEntity_AiMove_Server_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AiMove_Server_1));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, 100682844);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, 100682845);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, 100682846);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, 100682847);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, 100682848);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castFinishedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityPreCastFinishedEvent> forParameter_castFinishedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052847, RefRangeEnd = 1052848, XrefRangeStart = 1052844, XrefRangeEnd = 1052847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052851, RefRangeEnd = 1052852, XrefRangeStart = 1052848, XrefRangeEnd = 1052851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castFinishedEvent));
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr, 100682849);
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr, 100682850);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castFinishedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityPreCastFinishedEvent>.Runtime runtime_castFinishedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castFinishedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_OnCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_elapsedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0;
      [FieldOffset(0)]
      public double elapsedTime;
      [FieldOffset(8)]
      public Unity.Mathematics.Random random;
      [FieldOffset(16)]
      public AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052893, RefRangeEnd = 1052894, XrefRangeStart = 1052892, XrefRangeEnd = 1052893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref AiMove_Server aiMoveServer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1052865, RefRangeEnd = 1052867, XrefRangeStart = 1052865, XrefRangeEnd = 1052867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052894, XrefRangeEnd = 1052896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052901, RefRangeEnd = 1052902, XrefRangeStart = 1052896, XrefRangeEnd = 1052901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052904, RefRangeEnd = 1052905, XrefRangeStart = 1052902, XrefRangeEnd = 1052904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiMoveSystem_Server componentSystem,
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeFieldInfoPtr_elapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, nameof (elapsedTime));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, nameof (random));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, 100682851);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, 100682852);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, 100682853);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, 100682854);
        AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, 100682855);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveServer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Server> forParameter_aiMoveServer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052887, RefRangeEnd = 1052888, XrefRangeStart = 1052884, XrefRangeEnd = 1052887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052891, RefRangeEnd = 1052892, XrefRangeStart = 1052888, XrefRangeEnd = 1052891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveServer));
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr, 100682856);
          AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr, 100682857);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveServer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Server>.Runtime runtime_aiMoveServer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveServer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateCircleDirAndDistance_EveryFrame.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Server/ProjectM.<>c__DisplayClass_UpdateSeekDistance")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSeekDistance
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(32)]
      public AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052926, RefRangeEnd = 1052927, XrefRangeStart = 1052925, XrefRangeEnd = 1052926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AiMove_Server aiMoveServer,
        [In] ref AiMove_Shared aiMoveShared,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref aiMoveServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052927, RefRangeEnd = 1052928, XrefRangeStart = 1052927, XrefRangeEnd = 1052927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052928, XrefRangeEnd = 1052930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052941, RefRangeEnd = 1052942, XrefRangeStart = 1052930, XrefRangeEnd = 1052941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052944, RefRangeEnd = 1052945, XrefRangeStart = 1052942, XrefRangeEnd = 1052944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiMoveSystem_Server componentSystem,
        ref AiMoveSystem_Server.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSeekDistance()
      {
        Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server>.NativeClassPtr, "<>c__DisplayClass_UpdateSeekDistance");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr);
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, nameof (getTranslation));
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AiMove_Server_byref_AiMove_Shared_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, 100682858);
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, 100682859);
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, 100682860);
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, 100682861);
        AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, 100682862);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveShared;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Server> forParameter_aiMoveServer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Shared> forParameter_aiMoveShared;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052914, RefRangeEnd = 1052915, XrefRangeStart = 1052905, XrefRangeEnd = 1052914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Server componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052924, RefRangeEnd = 1052925, XrefRangeStart = 1052915, XrefRangeEnd = 1052924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveServer));
          AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveShared));
          AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, 100682863);
          AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, 100682864);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Server>.Runtime runtime_aiMoveServer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Shared>.Runtime runtime_aiMoveShared;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveServer));
            AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveShared));
            AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Server.__c__DisplayClass_UpdateSeekDistance.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
