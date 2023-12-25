// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveEntitySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class MoveEntitySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveStopHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoMovement_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoMovement_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDoMovement_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026024, XrefRangeEnd = 1026041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveEntitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026041, XrefRangeEnd = 1026047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveEntitySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026047, XrefRangeEnd = 1026097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveEntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveEntitySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026097, XrefRangeEnd = 1026115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveEntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026158, RefRangeEnd = 1026159, XrefRangeStart = 1026115, XrefRangeEnd = 1026158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDoMovement_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForDoMovement_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026163, RefRangeEnd = 1026164, XrefRangeStart = 1026159, XrefRangeEnd = 1026163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveEntitySystem()
    {
      Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveEntitySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr);
      MoveEntitySystem.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, nameof (_CurveCollection));
      MoveEntitySystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, nameof (_CollisionSystem));
      MoveEntitySystem.NativeFieldInfoPtr__MoveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, nameof (_MoveStopHits));
      MoveEntitySystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, nameof (_ServerTime));
      MoveEntitySystem.NativeFieldInfoPtr___DoMovement_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, "<>DoMovement_entityQuery");
      MoveEntitySystem.NativeFieldInfoPtr___DoMovement_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, "<>DoMovement_profilerMarker");
      MoveEntitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680187);
      MoveEntitySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680188);
      MoveEntitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680189);
      MoveEntitySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680190);
      MoveEntitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680191);
      MoveEntitySystem.NativeMethodInfoPtr___GetEntityQuery_ForDoMovement_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680192);
      MoveEntitySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, 100680193);
    }

    public MoveEntitySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ColliderCastHit> _MoveStopHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__MoveStopHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__MoveStopHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __DoMovement_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr___DoMovement_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr___DoMovement_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DoMovement_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr___DoMovement_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.NativeFieldInfoPtr___DoMovement_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.MoveEntitySystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMoveStopTrigger;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveStopHits;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref Translation translation,
        ref Velocity velocity,
        ref MoveVelocity moveVelocity,
        [In] ref Movement movement,
        [In] ref Rotation rotation,
        [In] ref EntityInput input,
        [In] ref NetworkInterpolated_Shared networkInterpolatedShared)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveVelocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr);
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (isServer));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (serverTime));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (curveCollection));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (deltaTime));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (collisionWorld));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getTranslation));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getDead));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getMoveStopTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getMoveStopTrigger));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getEntityCategory));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getDynamicCollision));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getBuffableFlagState));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getTeam));
        MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_moveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (moveStopHits));
        MoveEntitySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, 100680194);
        MoveEntitySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, 100680195);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe bool isServer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isServer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isServer)) = value;
        }
      }

      public unsafe MoveEntitySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MoveEntitySystem) null : new MoveEntitySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe CurveCollection curveCollection
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_curveCollection));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_curveCollection)) = value;
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Dead> getDead
      {
        get
        {
          return *(ComponentDataFromEntity<Dead>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDead));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDead), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Dead>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger
      {
        get
        {
          return *(ComponentDataFromEntity<MoveStopTrigger>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getMoveStopTrigger));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getMoveStopTrigger), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<MoveStopTrigger>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<EntityCategory> getEntityCategory
      {
        get
        {
          return *(ComponentDataFromEntity<EntityCategory>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getEntityCategory));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getEntityCategory), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<EntityCategory>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<DynamicCollision> getDynamicCollision
      {
        get
        {
          return *(ComponentDataFromEntity<DynamicCollision>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDynamicCollision));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getDynamicCollision), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<DynamicCollision>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState
      {
        get
        {
          return *(ComponentDataFromEntity<BuffableFlagState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getBuffableFlagState));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getBuffableFlagState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<BuffableFlagState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Team> getTeam
      {
        get
        {
          return *(ComponentDataFromEntity<Team>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTeam));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getTeam), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Team>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<ColliderCastHit> moveStopHits
      {
        get
        {
          return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_moveStopHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveEntitySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_moveStopHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.MoveEntitySystem/ProjectM.<>c__DisplayClass_DoMovement")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoMovement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMoveStopTrigger;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveStopHits;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool isServer;
      [FieldOffset(8)]
      public EntityManager entityManager;
      [FieldOffset(16)]
      public double serverTime;
      [FieldOffset(24)]
      public CurveCollection curveCollection;
      [FieldOffset(40)]
      public float deltaTime;
      [FieldOffset(48)]
      public CollisionWorld collisionWorld;
      [FieldOffset(392)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(424)]
      public ComponentDataFromEntity<Dead> getDead;
      [FieldOffset(456)]
      public ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger;
      [FieldOffset(488)]
      public ComponentDataFromEntity<EntityCategory> getEntityCategory;
      [FieldOffset(520)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(552)]
      public ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState;
      [FieldOffset(584)]
      public ComponentDataFromEntity<Team> getTeam;
      [FieldOffset(616)]
      public NativeList<ColliderCastHit> moveStopHits;
      [FieldOffset(632)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(664)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_1;
      [FieldOffset(696)]
      public ComponentDataFromEntity<MapCollision> _ComponentDataFromEntity_MapCollision_2;
      [FieldOffset(728)]
      public ComponentDataFromEntity<Mounter> _ComponentDataFromEntity_Mounter_3;
      [FieldOffset(760)]
      public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_4;
      [FieldOffset(792)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_5;
      [FieldOffset(824)]
      public MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1056)]
      public unsafe MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025894, XrefRangeEnd = 1025964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref Translation translation,
        ref Velocity velocity,
        ref MoveVelocity moveVelocity,
        [In] ref Movement movement,
        [In] ref Rotation rotation,
        [In] ref EntityInput input,
        [In] ref NetworkInterpolated_Shared networkInterpolatedShared)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveVelocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkInterpolatedShared;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025964, RefRangeEnd = 1025965, XrefRangeStart = 1025964, XrefRangeEnd = 1025964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MoveEntitySystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025965, RefRangeEnd = 1025966, XrefRangeStart = 1025965, XrefRangeEnd = 1025965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MoveEntitySystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025966, XrefRangeEnd = 1025968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025992, RefRangeEnd = 1025993, XrefRangeStart = 1025968, XrefRangeEnd = 1025992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1026013, RefRangeEnd = 1026014, XrefRangeStart = 1025993, XrefRangeEnd = 1026013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MoveEntitySystem componentSystem,
        ref MoveEntitySystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026014, XrefRangeEnd = 1026018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026018, XrefRangeEnd = 1026024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoMovement()
      {
        Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem>.NativeClassPtr, "<>c__DisplayClass_DoMovement");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (isServer));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (entityManager));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (serverTime));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (curveCollection));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (deltaTime));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (collisionWorld));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getTranslation));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getDead));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getMoveStopTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getMoveStopTrigger));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getEntityCategory));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getDynamicCollision));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getBuffableFlagState));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_getTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (getTeam));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_moveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (moveStopHits));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_1));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_MapCollision_2));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_Mounter_3));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_4));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_5));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (_runtimes));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_Velocity_byref_MoveVelocity_byref_Movement_byref_Rotation_byref_EntityInput_byref_NetworkInterpolated_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680196);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680197);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680198);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680199);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680200);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680201);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680202);
        MoveEntitySystem.__c__DisplayClass_DoMovement.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, 100680203);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MoveEntitySystem.__c__DisplayClass_DoMovement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_velocity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveVelocity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movement;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_input;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkInterpolatedShared;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Velocity> forParameter_velocity;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MoveVelocity> forParameter_moveVelocity;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Movement> forParameter_movement;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(168)]
        public LambdaParameterValueProvider_IComponentData<EntityInput> forParameter_input;
        [FieldOffset(200)]
        public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared> forParameter_networkInterpolatedShared;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025795, RefRangeEnd = 1025796, XrefRangeStart = 1025773, XrefRangeEnd = 1025795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MoveEntitySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025818, RefRangeEnd = 1025819, XrefRangeStart = 1025796, XrefRangeEnd = 1025818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_velocity));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveVelocity));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movement));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_input));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkInterpolatedShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkInterpolatedShared));
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveEntitySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, 100680204);
          MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, 100680205);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_velocity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveVelocity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movement;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_input;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkInterpolatedShared;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Velocity>.Runtime runtime_velocity;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<MoveVelocity>.Runtime runtime_moveVelocity;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Movement>.Runtime runtime_movement;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<EntityInput>.Runtime runtime_input;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<NetworkInterpolated_Shared>.Runtime runtime_networkInterpolatedShared;

          static Runtimes()
          {
            Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_velocity));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveVelocity));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movement));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_input));
            MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkInterpolatedShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkInterpolatedShared));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.MoveEntitySystem/ProjectM.<>c__DisplayClass_DoMovement/ProjectM.RunWithoutJobSystem_00003E31$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, "RunWithoutJobSystem_00003E31$PostfixBurstDelegate");
          MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680206);
          MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680207);
          MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680208);
          MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680209);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.MoveEntitySystem/ProjectM.<>c__DisplayClass_DoMovement/ProjectM.RunWithoutJobSystem_00003E31$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025819, XrefRangeEnd = 1025833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025833, XrefRangeEnd = 1025851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025851, XrefRangeEnd = 1025866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025893, RefRangeEnd = 1025894, XrefRangeStart = 1025866, XrefRangeEnd = 1025893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement>.NativeClassPtr, "RunWithoutJobSystem_00003E31$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680210);
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680211);
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680212);
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680213);
          MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680215);
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
            IL2CPP.il2cpp_field_static_get_value(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MoveEntitySystem.__c__DisplayClass_DoMovement.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
