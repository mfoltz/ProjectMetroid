// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveSystem_Client_Update
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AiMoveSystem_Client_Update : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_SPEED;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SPEED;
    private static readonly System.IntPtr NativeFieldInfoPtr_DIST_THRESHOLD;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_DIST_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DIST;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DIST_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindTargetPos_Private_Static_Boolean_byref_EntityInput_byref_AiMove_Client_byref_Translation_byref_AiMove_Shared_byref_MapCollision_Double_Single_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Move_Private_Static_Void_byref_AiMove_Client_byref_EntityInput_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_byref_Translation_byref_NetworkInterpolated_Client_float2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SimulateServerPos_Private_Static_Void_byref_AiMove_Client_float2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clamp01_Private_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SlideTowardsServerPos_Public_Static_Void_byref_AiMove_Client_byref_Translation_byref_NetworkInterpolated_Shared_Double_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052421, XrefRangeEnd = 1052429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052429, XrefRangeEnd = 1052455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1052460, RefRangeEnd = 1052461, XrefRangeStart = 1052455, XrefRangeEnd = 1052460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindTargetPos(
      ref EntityInput entityInput,
      ref AiMove_Client aiMoveClient,
      [In] ref Translation translation,
      [In] ref AiMove_Shared aiMoveShared,
      [In] ref MapCollision mapCollision,
      double serverTime,
      float speed,
      out float2 result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_TryFindTargetPos_Private_Static_Boolean_byref_EntityInput_byref_AiMove_Client_byref_Translation_byref_AiMove_Shared_byref_MapCollision_Double_Single_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1052487, RefRangeEnd = 1052488, XrefRangeStart = 1052461, XrefRangeEnd = 1052487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Move(
      ref AiMove_Client aiMoveClient,
      ref EntityInput entityInput,
      ref Movement movement,
      ref DynamicBuffer<FloatModificationBuffer> floatMods,
      [In] ref NetworkInterpolated_Shared networkInterpolatedShared,
      [In] ref Translation translation,
      [In] ref NetworkInterpolated_Client networkInterpolatedClient,
      float2 targetWaypointPos,
      float speed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref aiMoveClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref floatMods;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &targetWaypointPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_Move_Private_Static_Void_byref_AiMove_Client_byref_EntityInput_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_byref_Translation_byref_NetworkInterpolated_Client_float2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052488, XrefRangeEnd = 1052489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SimulateServerPos(
      ref AiMove_Client aiMoveClient,
      float2 targetPos,
      float speed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref aiMoveClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_SimulateServerPos_Private_Static_Void_byref_AiMove_Client_float2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 257268, RefRangeEnd = 257288, XrefRangeStart = 257268, XrefRangeEnd = 257288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float Clamp01(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_Clamp01_Private_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1052492, RefRangeEnd = 1052493, XrefRangeStart = 1052489, XrefRangeEnd = 1052492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SlideTowardsServerPos(
      ref AiMove_Client aiMoveClient,
      ref Translation translation,
      [In] ref NetworkInterpolated_Shared networkInterpolatedShared,
      double serverTime,
      float deltaTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref aiMoveClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_SlideTowardsServerPos_Public_Static_Void_byref_AiMove_Client_byref_Translation_byref_NetworkInterpolated_Shared_Double_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AiMoveSystem_Client_Update()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052493, XrefRangeEnd = 1052511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1052551, RefRangeEnd = 1052552, XrefRangeStart = 1052511, XrefRangeEnd = 1052551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1052556, RefRangeEnd = 1052557, XrefRangeStart = 1052552, XrefRangeEnd = 1052556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiMoveSystem_Client_Update()
    {
      Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AiMoveSystem_Client_Update));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr);
      AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (_ServerDebugSettings));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (_ServerTimeAccessor));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (MIN_SPEED));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (MAX_SPEED));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_DIST_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (DIST_THRESHOLD));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_DIST_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (MIN_DIST_SQ));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (MAX_DIST));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, nameof (MAX_DIST_SQ));
      AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682754);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682755);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_TryFindTargetPos_Private_Static_Boolean_byref_EntityInput_byref_AiMove_Client_byref_Translation_byref_AiMove_Shared_byref_MapCollision_Double_Single_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682756);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_Move_Private_Static_Void_byref_AiMove_Client_byref_EntityInput_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_byref_Translation_byref_NetworkInterpolated_Client_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682757);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_SimulateServerPos_Private_Static_Void_byref_AiMove_Client_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682758);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_Clamp01_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682759);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_SlideTowardsServerPos_Public_Static_Void_byref_AiMove_Client_byref_Translation_byref_NetworkInterpolated_Shared_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682760);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682761);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682762);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682763);
      AiMoveSystem_Client_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, 100682764);
    }

    public AiMoveSystem_Client_Update(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe float MIN_SPEED
    {
      get
      {
        float minSpeed;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_SPEED, (void*) &minSpeed);
        return minSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_SPEED, (void*) &value);
      }
    }

    public static unsafe float MAX_SPEED
    {
      get
      {
        float maxSpeed;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_SPEED, (void*) &maxSpeed);
        return maxSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_SPEED, (void*) &value);
      }
    }

    public static unsafe float DIST_THRESHOLD
    {
      get
      {
        float distThreshold;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_DIST_THRESHOLD, (void*) &distThreshold);
        return distThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_DIST_THRESHOLD, (void*) &value);
      }
    }

    public static unsafe float MIN_DIST_SQ
    {
      get
      {
        float minDistSq;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_DIST_SQ, (void*) &minDistSq);
        return minDistSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MIN_DIST_SQ, (void*) &value);
      }
    }

    public static unsafe float MAX_DIST
    {
      get
      {
        float maxDist;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST, (void*) &maxDist);
        return maxDist;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST, (void*) &value);
      }
    }

    public static unsafe float MAX_DIST_SQ
    {
      get
      {
        float maxDistSq;
        IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST_SQ, (void*) &maxDistSq);
        return maxDistSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.NativeFieldInfoPtr_MAX_DIST_SQ, (void*) &value);
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveSystem_Client_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Client_Update/<>c__DisplayClass9_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass9_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMapCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNetworkInterpolatedClient;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<MapCollision> getMapCollision;
      [FieldOffset(32)]
      public ComponentDataFromEntity<NetworkInterpolated_Client> getNetworkInterpolatedClient;
      [FieldOffset(64)]
      public float deltaTime;
      [FieldOffset(72)]
      public ServerTime serverTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref EntityInput entityInput,
        ref AiMove_Shared aiMoveShared,
        ref AiMove_Client aiMoveClient,
        ref Translation translation,
        ref Movement movement,
        ref DynamicBuffer<FloatModificationBuffer> floatMods,
        [In] ref NetworkInterpolated_Shared networkInterpolatedShared)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveClient;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref floatMods;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr);
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeFieldInfoPtr_getMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, nameof (getMapCollision));
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeFieldInfoPtr_getNetworkInterpolatedClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, nameof (getNetworkInterpolatedClient));
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, nameof (deltaTime));
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, nameof (serverTime));
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, 100682765);
        AiMoveSystem_Client_Update.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, 100682766);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AiMoveSystem_Client_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getMapCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNetworkInterpolatedClient;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<MapCollision> getMapCollision;
      [FieldOffset(32)]
      public ComponentDataFromEntity<NetworkInterpolated_Client> getNetworkInterpolatedClient;
      [FieldOffset(64)]
      public float deltaTime;
      [FieldOffset(72)]
      public ServerTime serverTime;
      [FieldOffset(112)]
      public AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(352)]
      public unsafe AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052369, XrefRangeEnd = 1052379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref EntityInput entityInput,
        ref AiMove_Shared aiMoveShared,
        ref AiMove_Client aiMoveClient,
        ref Translation translation,
        ref Movement movement,
        ref DynamicBuffer<FloatModificationBuffer> floatMods,
        [In] ref NetworkInterpolated_Shared networkInterpolatedShared)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiMoveClient;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref floatMods;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052379, RefRangeEnd = 1052380, XrefRangeStart = 1052379, XrefRangeEnd = 1052379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiMoveSystem_Client_Update.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052380, RefRangeEnd = 1052381, XrefRangeStart = 1052380, XrefRangeEnd = 1052380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AiMoveSystem_Client_Update.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052381, XrefRangeEnd = 1052383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052407, RefRangeEnd = 1052408, XrefRangeStart = 1052383, XrefRangeEnd = 1052407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1052410, RefRangeEnd = 1052411, XrefRangeStart = 1052408, XrefRangeEnd = 1052410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiMoveSystem_Client_Update componentSystem,
        ref AiMoveSystem_Client_Update.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052411, XrefRangeEnd = 1052415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052415, XrefRangeEnd = 1052421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getMapCollision));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getNetworkInterpolatedClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getNetworkInterpolatedClient));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (deltaTime));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityInput_byref_AiMove_Shared_byref_AiMove_Client_byref_Translation_byref_Movement_byref_DynamicBuffer_1_FloatModificationBuffer_byref_NetworkInterpolated_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682767);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682768);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682769);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682770);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682771);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682772);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682773);
        AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100682774);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityInput;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveShared;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiMoveClient;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movement;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_floatMods;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkInterpolatedShared;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EntityInput> forParameter_entityInput;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Shared> forParameter_aiMoveShared;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<AiMove_Client> forParameter_aiMoveClient;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<Movement> forParameter_movement;
        [FieldOffset(168)]
        public LambdaParameterValueProvider_DynamicBuffer<FloatModificationBuffer> forParameter_floatMods;
        [FieldOffset(208)]
        public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared> forParameter_networkInterpolatedShared;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052270, RefRangeEnd = 1052271, XrefRangeStart = 1052248, XrefRangeEnd = 1052270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiMoveSystem_Client_Update componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052293, RefRangeEnd = 1052294, XrefRangeStart = 1052271, XrefRangeEnd = 1052293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityInput));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveShared));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiMoveClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiMoveClient));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movement));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_floatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_floatMods));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkInterpolatedShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkInterpolatedShared));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiMoveSystem_Client_Update_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100682775);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100682776);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityInput;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiMoveClient;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movement;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_floatMods;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkInterpolatedShared;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityInput>.Runtime runtime_entityInput;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Shared>.Runtime runtime_aiMoveShared;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AiMove_Client>.Runtime runtime_aiMoveClient;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Movement>.Runtime runtime_movement;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_DynamicBuffer<FloatModificationBuffer>.Runtime runtime_floatMods;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared>.Runtime runtime_networkInterpolatedShared;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityInput));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveShared));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiMoveClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiMoveClient));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movement));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_floatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_floatMods));
            AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkInterpolatedShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkInterpolatedShared));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AiMoveSystem_Client_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00004584$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004584$PostfixBurstDelegate");
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682777);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682778);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682779);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100682780);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AiMoveSystem_Client_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00004584$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052294, XrefRangeEnd = 1052308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052308, XrefRangeEnd = 1052326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052326, XrefRangeEnd = 1052341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1052368, RefRangeEnd = 1052369, XrefRangeStart = 1052341, XrefRangeEnd = 1052368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004584$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682781);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682782);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682783);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682784);
          AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100682786);
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
            IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiMoveSystem_Client_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
