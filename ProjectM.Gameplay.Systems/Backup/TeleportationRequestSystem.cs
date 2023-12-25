// Decompiled with JetBrains decompiler
// Type: ProjectM.TeleportationRequestSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class TeleportationRequestSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkPortalManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__TeleportRequestQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheatDistanceRangeSquared;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportationRequest_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleTeleportationRequest_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetAndFollowers_Private_Static_NativeList_1_TeleportTarget_Entity_BufferFromEntity_1_FollowerBuffer_ComponentDataFromEntity_1_Translation_ComponentDataFromEntity_1_Dead_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TeleportTargetsToPosition_Private_Static_Void_NativeList_1_TeleportTarget_float3_Nullable_Unboxed_1_Single_Entity_ComponentDataFromEntity_1_TravelBuff_ComponentDataFromEntity_1_TeleportBuff_byref_BuffSpawner_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportationRequest_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422126, XrefRangeEnd = 1422139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportationRequestSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportationRequestSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422139, XrefRangeEnd = 1422183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportationRequestSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1422225, RefRangeEnd = 1422226, XrefRangeStart = 1422183, XrefRangeEnd = 1422225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<TeleportationRequestSystem.TeleportTarget> GetTargetAndFollowers(
      Entity target,
      BufferFromEntity<FollowerBuffer> getFollowers,
      ComponentDataFromEntity<Translation> getTranslation,
      ComponentDataFromEntity<Dead> getDead,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getFollowers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getDead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.NativeMethodInfoPtr_GetTargetAndFollowers_Private_Static_NativeList_1_TeleportTarget_Entity_BufferFromEntity_1_FollowerBuffer_ComponentDataFromEntity_1_Translation_ComponentDataFromEntity_1_Dead_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<TeleportationRequestSystem.TeleportTarget>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1422265, RefRangeEnd = 1422266, XrefRangeStart = 1422226, XrefRangeEnd = 1422265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TeleportTargetsToPosition(
      NativeList<TeleportationRequestSystem.TeleportTarget> targets,
      float3 targetPosition,
      Nullable_Unboxed<float> targetCameraRotation,
      Entity travelBuffPrefab,
      ComponentDataFromEntity<TravelBuff> getTravelBuff,
      ComponentDataFromEntity<TeleportBuff> getTeleportBuff,
      ref BuffUtility.BuffSpawner buffSpawner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &targets;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetCameraRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &travelBuffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTravelBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTeleportBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffSpawner;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.NativeMethodInfoPtr_TeleportTargetsToPosition_Private_Static_Void_NativeList_1_TeleportTarget_float3_Nullable_Unboxed_1_Single_Entity_ComponentDataFromEntity_1_TravelBuff_ComponentDataFromEntity_1_TeleportBuff_byref_BuffSpawner_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TeleportationRequestSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422266, XrefRangeEnd = 1422299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TeleportationRequestSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422299, XrefRangeEnd = 1422315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleTeleportationRequest_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportationRequest_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1422319, RefRangeEnd = 1422320, XrefRangeStart = 1422315, XrefRangeEnd = 1422319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TeleportationRequestSystem()
    {
      Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (TeleportationRequestSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr);
      TeleportationRequestSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      TeleportationRequestSystem.NativeFieldInfoPtr__ChunkPortalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (_ChunkPortalManager));
      TeleportationRequestSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      TeleportationRequestSystem.NativeFieldInfoPtr__TeleportRequestQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (_TeleportRequestQuery));
      TeleportationRequestSystem.NativeFieldInfoPtr_CheatDistanceRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (CheatDistanceRangeSquared));
      TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, "<>HandleTeleportationRequest_entityQuery");
      TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, "<>HandleTeleportationRequest_profilerMarker");
      TeleportationRequestSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669772);
      TeleportationRequestSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669773);
      TeleportationRequestSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669774);
      TeleportationRequestSystem.NativeMethodInfoPtr_GetTargetAndFollowers_Private_Static_NativeList_1_TeleportTarget_Entity_BufferFromEntity_1_FollowerBuffer_ComponentDataFromEntity_1_Translation_ComponentDataFromEntity_1_Dead_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669775);
      TeleportationRequestSystem.NativeMethodInfoPtr_TeleportTargetsToPosition_Private_Static_Void_NativeList_1_TeleportTarget_float3_Nullable_Unboxed_1_Single_Entity_ComponentDataFromEntity_1_TravelBuff_ComponentDataFromEntity_1_TeleportBuff_byref_BuffSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669776);
      TeleportationRequestSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669777);
      TeleportationRequestSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669778);
      TeleportationRequestSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleTeleportationRequest_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669779);
      TeleportationRequestSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, 100669780);
    }

    public TeleportationRequestSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkObjectManager _ChunkPortalManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__ChunkPortalManager));
        return pointer == System.IntPtr.Zero ? (ChunkObjectManager) null : new ChunkObjectManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__ChunkPortalManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _TeleportRequestQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__TeleportRequestQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr__TeleportRequestQuery)) = value;
      }
    }

    public static unsafe int CheatDistanceRangeSquared
    {
      get
      {
        int distanceRangeSquared;
        IL2CPP.il2cpp_field_static_get_value(TeleportationRequestSystem.NativeFieldInfoPtr_CheatDistanceRangeSquared, (void*) &distanceRangeSquared);
        return distanceRangeSquared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TeleportationRequestSystem.NativeFieldInfoPtr_CheatDistanceRangeSquared, (void*) &value);
      }
    }

    public unsafe EntityQuery __HandleTeleportationRequest_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleTeleportationRequest_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.NativeFieldInfoPtr___HandleTeleportationRequest_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TeleportTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      [FieldOffset(0)]
      public float3 FromTranslation;
      [FieldOffset(12)]
      public Entity Entity;

      static TeleportTarget()
      {
        Il2CppClassPointerStore<TeleportationRequestSystem.TeleportTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, nameof (TeleportTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequestSystem.TeleportTarget>.NativeClassPtr);
        TeleportationRequestSystem.TeleportTarget.NativeFieldInfoPtr_FromTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.TeleportTarget>.NativeClassPtr, nameof (FromTranslation));
        TeleportationRequestSystem.TeleportTarget.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.TeleportTarget>.NativeClassPtr, nameof (Entity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequestSystem.TeleportTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.TeleportationRequestSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_defaultTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeleportBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_allChunkPortals;
      private static readonly System.IntPtr NativeFieldInfoPtr_netherSpawnPositions;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFollowers;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TeleportationRequest_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref TeleportationRequest teleportationRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref teleportationRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TeleportationRequest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr);
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_defaultTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (defaultTravelBuff));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (prefabMap));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getTravelBuff));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getTeleportBuff));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getTranslation));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_allChunkPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (allChunkPortals));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_netherSpawnPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (netherSpawnPositions));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (random));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getFollowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getFollowers));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getDead));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (buffSpawner));
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669781);
        TeleportationRequestSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TeleportationRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669782);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID defaultTravelBuff
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_defaultTravelBuff));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_defaultTravelBuff)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<TravelBuff> getTravelBuff
      {
        get
        {
          return *(ComponentDataFromEntity<TravelBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTravelBuff));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTravelBuff), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<TravelBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<TeleportBuff> getTeleportBuff
      {
        get
        {
          return *(ComponentDataFromEntity<TeleportBuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTeleportBuff));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTeleportBuff), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<TeleportBuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe TeleportationRequestSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TeleportationRequestSystem) null : new TeleportationRequestSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>> allChunkPortals
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_allChunkPortals));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_allChunkPortals), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<NetherSpawnPositionData> netherSpawnPositions
      {
        get
        {
          return *(NativeList<NetherSpawnPositionData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_netherSpawnPositions));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_netherSpawnPositions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<NetherSpawnPositionData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe BufferFromEntity<FollowerBuffer> getFollowers
      {
        get
        {
          return *(BufferFromEntity<FollowerBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getFollowers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getFollowers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<FollowerBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Dead> getDead
      {
        get
        {
          return *(ComponentDataFromEntity<Dead>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getDead));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getDead), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Dead>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BuffUtility.BuffSpawner buffSpawner
      {
        get
        {
          return *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buffSpawner));
        }
        [param: In] set
        {
          *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TeleportationRequestSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buffSpawner)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.TeleportationRequestSystem/ProjectM.<>c__DisplayClass_HandleTeleportationRequest")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleTeleportationRequest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_defaultTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeleportBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_allChunkPortals;
      private static readonly System.IntPtr NativeFieldInfoPtr_netherSpawnPositions;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_getFollowers;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChunkPortal_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChunkWaypoint_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ReturnToNetherWaypoint_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleWaypoint_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_StartGraveyardExitWaypoint_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TeleportationRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabGUID defaultTravelBuff;
      [FieldOffset(8)]
      public PrefabLookupMap prefabMap;
      [FieldOffset(56)]
      public ComponentDataFromEntity<TravelBuff> getTravelBuff;
      [FieldOffset(88)]
      public ComponentDataFromEntity<TeleportBuff> getTeleportBuff;
      [FieldOffset(120)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(152)]
      public NativeHashMap<TerrainChunk, FixedList512<ChunkPortalData>> allChunkPortals;
      [FieldOffset(168)]
      public NativeList<NetherSpawnPositionData> netherSpawnPositions;
      [FieldOffset(184)]
      public Unity.Mathematics.Random random;
      [FieldOffset(192)]
      public BufferFromEntity<FollowerBuffer> getFollowers;
      [FieldOffset(232)]
      public ComponentDataFromEntity<Dead> getDead;
      [FieldOffset(264)]
      public BuffUtility.BuffSpawner buffSpawner;
      [FieldOffset(392)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_0;
      [FieldOffset(424)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_1;
      [FieldOffset(456)]
      public ComponentDataFromEntity<ChunkPortal> _ComponentDataFromEntity_ChunkPortal_2;
      [FieldOffset(488)]
      public ComponentDataFromEntity<ChunkWaypoint> _ComponentDataFromEntity_ChunkWaypoint_3;
      [FieldOffset(520)]
      public ComponentDataFromEntity<ReturnToNetherWaypoint> _ComponentDataFromEntity_ReturnToNetherWaypoint_4;
      [FieldOffset(552)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_5;
      [FieldOffset(584)]
      public ComponentDataFromEntity<CastleWaypoint> _ComponentDataFromEntity_CastleWaypoint_6;
      [FieldOffset(616)]
      public ComponentDataFromEntity<StartGraveyardExitWaypoint> _ComponentDataFromEntity_StartGraveyardExitWaypoint_7;
      [FieldOffset(648)]
      public TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(688)]
      public unsafe TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421925, XrefRangeEnd = 1422078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref TeleportationRequest teleportationRequest)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref teleportationRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TeleportationRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1422078, RefRangeEnd = 1422079, XrefRangeStart = 1422078, XrefRangeEnd = 1422078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TeleportationRequestSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1422079, RefRangeEnd = 1422080, XrefRangeStart = 1422079, XrefRangeEnd = 1422079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TeleportationRequestSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422080, XrefRangeEnd = 1422082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1422088, RefRangeEnd = 1422089, XrefRangeStart = 1422082, XrefRangeEnd = 1422088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1422115, RefRangeEnd = 1422116, XrefRangeStart = 1422089, XrefRangeEnd = 1422115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TeleportationRequestSystem componentSystem,
        ref TeleportationRequestSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422116, XrefRangeEnd = 1422120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422120, XrefRangeEnd = 1422126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleTeleportationRequest()
      {
        Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem>.NativeClassPtr, "<>c__DisplayClass_HandleTeleportationRequest");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_defaultTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (defaultTravelBuff));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (prefabMap));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_getTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (getTravelBuff));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_getTeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (getTeleportBuff));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (getTranslation));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_allChunkPortals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (allChunkPortals));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_netherSpawnPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (netherSpawnPositions));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (random));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_getFollowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (getFollowers));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (getDead));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (buffSpawner));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_Team_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_0));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_1));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_ChunkPortal_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChunkPortal_2));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_ChunkWaypoint_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChunkWaypoint_3));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_ReturnToNetherWaypoint_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_ReturnToNetherWaypoint_4));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_5));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_CastleWaypoint_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleWaypoint_6));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__ComponentDataFromEntity_StartGraveyardExitWaypoint_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_ComponentDataFromEntity_StartGraveyardExitWaypoint_7));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (_runtimes));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TeleportationRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669783);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669784);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669785);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669786);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669787);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669788);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669789);
        TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, 100669790);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_teleportationRequest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<TeleportationRequest> forParameter_teleportationRequest;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421844, RefRangeEnd = 1421845, XrefRangeStart = 1421840, XrefRangeEnd = 1421844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TeleportationRequestSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421849, RefRangeEnd = 1421850, XrefRangeStart = 1421845, XrefRangeEnd = 1421849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_teleportationRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_teleportationRequest));
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TeleportationRequestSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, 100669791);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, 100669792);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_teleportationRequest;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TeleportationRequest>.Runtime runtime_teleportationRequest;

          static Runtimes()
          {
            Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_teleportationRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_teleportationRequest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TeleportationRequestSystem/ProjectM.<>c__DisplayClass_HandleTeleportationRequest/ProjectM.RunWithoutJobSystem_00000F69$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, "RunWithoutJobSystem_00000F69$PostfixBurstDelegate");
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669793);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669794);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669795);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669796);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TeleportationRequestSystem/ProjectM.<>c__DisplayClass_HandleTeleportationRequest/ProjectM.RunWithoutJobSystem_00000F69$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421850, XrefRangeEnd = 1421864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421864, XrefRangeEnd = 1421882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421882, XrefRangeEnd = 1421897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1421924, RefRangeEnd = 1421925, XrefRangeStart = 1421897, XrefRangeEnd = 1421924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest>.NativeClassPtr, "RunWithoutJobSystem_00000F69$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669797);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669798);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669799);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669800);
          TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669802);
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
            IL2CPP.il2cpp_field_static_get_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TeleportationRequestSystem.__c__DisplayClass_HandleTeleportationRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
