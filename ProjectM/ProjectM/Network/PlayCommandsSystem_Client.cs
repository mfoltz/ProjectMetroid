// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PlayCommandsSystem_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  public class PlayCommandsSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveStopHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__DynamicCollisionCastResults;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149065, XrefRangeEnd = 1149095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayCommandsSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149095, XrefRangeEnd = 1149108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayCommandsSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149108, XrefRangeEnd = 1149181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayCommandsSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayCommandsSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149181, XrefRangeEnd = 1149199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayCommandsSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1149224, RefRangeEnd = 1149225, XrefRangeStart = 1149199, XrefRangeEnd = 1149224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1149229, RefRangeEnd = 1149230, XrefRangeStart = 1149225, XrefRangeEnd = 1149229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayCommandsSystem_Client()
    {
      Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (PlayCommandsSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr);
      PlayCommandsSystem_Client.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_TilePolygons));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_TileWorldSystem));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_CollisionSystem));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_CurveCollection));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_ServerDebugSettings));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_WorldFrame));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__MoveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_MoveStopHits));
      PlayCommandsSystem_Client.NativeFieldInfoPtr__DynamicCollisionCastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, nameof (_DynamicCollisionCastResults));
      PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      PlayCommandsSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691273);
      PlayCommandsSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691274);
      PlayCommandsSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691275);
      PlayCommandsSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691276);
      PlayCommandsSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691277);
      PlayCommandsSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691278);
      PlayCommandsSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, 100691279);
    }

    public PlayCommandsSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ColliderCastHit> _MoveStopHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__MoveStopHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__MoveStopHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<CastResult> _DynamicCollisionCastResults
    {
      get
      {
        return *(NativeList<CastResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__DynamicCollisionCastResults));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr__DynamicCollisionCastResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<CastResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Network.PlayCommandsSystem_Client/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_tilePolygons;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionDetection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMapCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCollisionRadius;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMoveStopTrigger;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPlayerCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileCollisionHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInputCommandStateHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_useTileCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_useDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveStopHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_dynamicCollisionCastResults;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref InputCommandDataProxy inputCommandDataProxy,
        [In] ref DynamicBuffer<InputCommandBufferElement> inputCommandBuffer,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr);
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (currentFrame));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (tilePolygons));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (tileWorld));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (worldType));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (collisionDetection));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getMapCollision));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getCollisionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getCollisionRadius));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getDynamicCollision));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getBuffableFlagState));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getTranslation));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getDead));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMoveStopTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getMoveStopTrigger));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getEntityCategory));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getPlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getPlayerCharacter));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getTeam));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getTileCollisionHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getTileGameplayHeightsHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getTileCollisionHistoryMetadataBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getInputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (getInputCommandStateHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (curveCollection));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useTileCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (useTileCollision));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (useDynamicCollision));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_moveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (moveStopHits));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_dynamicCollisionCastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (dynamicCollisionCastResults));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, nameof (collisionWorld));
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, 100691280);
        PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, 100691281);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass10_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass10_0>.NativeClassPtr, data));
      }

      public unsafe PlayCommandsSystem_Client __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PlayCommandsSystem_Client) null : new PlayCommandsSystem_Client(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int currentFrame
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_currentFrame));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_currentFrame)) = value;
        }
      }

      public unsafe TileMapCollisionMath.TilePolygons tilePolygons
      {
        get
        {
          return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tilePolygons));
        }
        [param: In] set
        {
          *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tilePolygons)) = value;
        }
      }

      public unsafe TileWorld tileWorld
      {
        get
        {
          return *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tileWorld));
        }
        [param: In] set
        {
          *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_tileWorld)) = value;
        }
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_worldType)) = value;
        }
      }

      public unsafe CollisionDetection collisionDetection
      {
        get
        {
          return *(CollisionDetection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionDetection));
        }
        [param: In] set
        {
          *(CollisionDetection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionDetection)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<MapCollision> getMapCollision
      {
        get
        {
          return *(ComponentDataFromEntity<MapCollision>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMapCollision));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMapCollision), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<MapCollision>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<CollisionRadius> getCollisionRadius
      {
        get
        {
          return *(ComponentDataFromEntity<CollisionRadius>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getCollisionRadius));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getCollisionRadius), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<CollisionRadius>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<DynamicCollision> getDynamicCollision
      {
        get
        {
          return *(ComponentDataFromEntity<DynamicCollision>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDynamicCollision));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDynamicCollision), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<DynamicCollision>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState
      {
        get
        {
          return *(ComponentDataFromEntity<BuffableFlagState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getBuffableFlagState));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getBuffableFlagState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<BuffableFlagState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Dead> getDead
      {
        get
        {
          return *(ComponentDataFromEntity<Dead>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDead));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getDead), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Dead>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger
      {
        get
        {
          return *(ComponentDataFromEntity<MoveStopTrigger>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMoveStopTrigger));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getMoveStopTrigger), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<MoveStopTrigger>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<EntityCategory> getEntityCategory
      {
        get
        {
          return *(ComponentDataFromEntity<EntityCategory>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getEntityCategory));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getEntityCategory), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<EntityCategory>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<PlayerCharacter> getPlayerCharacter
      {
        get
        {
          return *(ComponentDataFromEntity<PlayerCharacter>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getPlayerCharacter));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getPlayerCharacter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<PlayerCharacter>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Team> getTeam
      {
        get
        {
          return *(ComponentDataFromEntity<Team>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTeam));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTeam), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Team>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<TileCollisionHistoryElement> getTileCollisionHistoryBuffer
      {
        get
        {
          return *(BufferFromEntity<TileCollisionHistoryElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<TileCollisionHistoryElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<TileGameplayHeightsHistoryElement> getTileGameplayHeightsHistoryBuffer
      {
        get
        {
          return *(BufferFromEntity<TileGameplayHeightsHistoryElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<TileGameplayHeightsHistoryElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<TileCollisionHistoryMetadataElement> getTileCollisionHistoryMetadataBuffer
      {
        get
        {
          return *(BufferFromEntity<TileCollisionHistoryMetadataElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<TileCollisionHistoryMetadataElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<InputCommandStateHistoryBufferElement> getInputCommandStateHistoryBuffer
      {
        get
        {
          return *(BufferFromEntity<InputCommandStateHistoryBufferElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getInputCommandStateHistoryBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_getInputCommandStateHistoryBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<InputCommandStateHistoryBufferElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CurveCollection curveCollection
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_curveCollection));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_curveCollection)) = value;
        }
      }

      public unsafe bool useTileCollision
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useTileCollision));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useTileCollision)) = value;
        }
      }

      public unsafe bool useDynamicCollision
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useDynamicCollision));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_useDynamicCollision)) = value;
        }
      }

      public unsafe NativeList<ColliderCastHit> moveStopHits
      {
        get
        {
          return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_moveStopHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_moveStopHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<CastResult> dynamicCollisionCastResults
      {
        get
        {
          return *(NativeList<CastResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_dynamicCollisionCastResults));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_dynamicCollisionCastResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<CastResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCommandsSystem_Client.__c__DisplayClass10_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Network.PlayCommandsSystem_Client/ProjectM.Network.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_tilePolygons;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionDetection;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMapCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCollisionRadius;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getDead;
      private static readonly System.IntPtr NativeFieldInfoPtr_getMoveStopTrigger;
      private static readonly System.IntPtr NativeFieldInfoPtr_getEntityCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPlayerCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileCollisionHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInputCommandStateHistoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_useTileCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_useDynamicCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveStopHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_dynamicCollisionCastResults;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandData_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandState_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ClientNetworkSnapshotState_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Velocity_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MoveVelocity_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_8;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityAimData_9;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_10;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int currentFrame;
      [FieldOffset(8)]
      public TileMapCollisionMath.TilePolygons tilePolygons;
      [FieldOffset(88)]
      public TileWorld tileWorld;
      [FieldOffset(112)]
      public WorldType worldType;
      [FieldOffset(120)]
      public CollisionDetection collisionDetection;
      [FieldOffset(136)]
      public ComponentDataFromEntity<MapCollision> getMapCollision;
      [FieldOffset(168)]
      public ComponentDataFromEntity<CollisionRadius> getCollisionRadius;
      [FieldOffset(200)]
      public ComponentDataFromEntity<DynamicCollision> getDynamicCollision;
      [FieldOffset(232)]
      public ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState;
      [FieldOffset(264)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(296)]
      public ComponentDataFromEntity<Dead> getDead;
      [FieldOffset(328)]
      public ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger;
      [FieldOffset(360)]
      public ComponentDataFromEntity<EntityCategory> getEntityCategory;
      [FieldOffset(392)]
      public ComponentDataFromEntity<PlayerCharacter> getPlayerCharacter;
      [FieldOffset(424)]
      public ComponentDataFromEntity<Team> getTeam;
      [FieldOffset(456)]
      public BufferFromEntity<TileCollisionHistoryElement> getTileCollisionHistoryBuffer;
      [FieldOffset(496)]
      public BufferFromEntity<TileGameplayHeightsHistoryElement> getTileGameplayHeightsHistoryBuffer;
      [FieldOffset(536)]
      public BufferFromEntity<TileCollisionHistoryMetadataElement> getTileCollisionHistoryMetadataBuffer;
      [FieldOffset(576)]
      public BufferFromEntity<InputCommandStateHistoryBufferElement> getInputCommandStateHistoryBuffer;
      [FieldOffset(616)]
      public CurveCollection curveCollection;
      [FieldOffset(632)]
      public bool useTileCollision;
      [FieldOffset(633)]
      public bool useDynamicCollision;
      [FieldOffset(640)]
      public NativeList<ColliderCastHit> moveStopHits;
      [FieldOffset(656)]
      public NativeList<CastResult> dynamicCollisionCastResults;
      [FieldOffset(672)]
      public CollisionWorld collisionWorld;
      [FieldOffset(1016)]
      public ComponentDataFromEntity<IsSpellControlled> _ComponentDataFromEntity_IsSpellControlled_0;
      [FieldOffset(1048)]
      public ComponentDataFromEntity<InputCommandData> _ComponentDataFromEntity_InputCommandData_1;
      [FieldOffset(1080)]
      public ComponentDataFromEntity<InputCommandState> _ComponentDataFromEntity_InputCommandState_2;
      [FieldOffset(1112)]
      public ComponentDataFromEntity<ClientNetworkSnapshotState> _ComponentDataFromEntity_ClientNetworkSnapshotState_3;
      [FieldOffset(1144)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_4;
      [FieldOffset(1176)]
      public ComponentDataFromEntity<LastTranslation> _ComponentDataFromEntity_LastTranslation_5;
      [FieldOffset(1208)]
      public ComponentDataFromEntity<ProjectM.Velocity> _ComponentDataFromEntity_Velocity_6;
      [FieldOffset(1240)]
      public ComponentDataFromEntity<MoveVelocity> _ComponentDataFromEntity_MoveVelocity_7;
      [FieldOffset(1272)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_8;
      [FieldOffset(1304)]
      public ComponentDataFromEntity<EntityAimData> _ComponentDataFromEntity_EntityAimData_9;
      [FieldOffset(1336)]
      public ComponentDataFromEntity<Mounter> _ComponentDataFromEntity_Mounter_10;
      [FieldOffset(1368)]
      public PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1480)]
      public unsafe PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148872, XrefRangeEnd = 1149002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref InputCommandDataProxy inputCommandDataProxy,
        [In] ref DynamicBuffer<InputCommandBufferElement> inputCommandBuffer,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149002, RefRangeEnd = 1149003, XrefRangeStart = 1149002, XrefRangeEnd = 1149002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PlayCommandsSystem_Client.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149003, RefRangeEnd = 1149004, XrefRangeStart = 1149003, XrefRangeEnd = 1149003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PlayCommandsSystem_Client.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149004, XrefRangeEnd = 1149006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149018, RefRangeEnd = 1149019, XrefRangeStart = 1149006, XrefRangeEnd = 1149018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149054, RefRangeEnd = 1149055, XrefRangeStart = 1149019, XrefRangeEnd = 1149054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PlayCommandsSystem_Client componentSystem,
        ref PlayCommandsSystem_Client.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149055, XrefRangeEnd = 1149059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149059, XrefRangeEnd = 1149065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentFrame));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_tilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (tilePolygons));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (tileWorld));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (worldType));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_collisionDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (collisionDetection));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getMapCollision));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getCollisionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getCollisionRadius));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getDynamicCollision));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getBuffableFlagState));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTranslation));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getDead));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getMoveStopTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getMoveStopTrigger));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getEntityCategory));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getPlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getPlayerCharacter));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTeam));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTileCollisionHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTileGameplayHeightsHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTileGameplayHeightsHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTileCollisionHistoryMetadataBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getInputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getInputCommandStateHistoryBuffer));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (curveCollection));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_useTileCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (useTileCollision));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_useDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (useDynamicCollision));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_moveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (moveStopHits));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_dynamicCollisionCastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (dynamicCollisionCastResults));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (collisionWorld));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_IsSpellControlled_0));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandData_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_InputCommandData_1));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandState_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_InputCommandState_2));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ClientNetworkSnapshotState_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ClientNetworkSnapshotState_3));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_4));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_LastTranslation_5));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Velocity_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Velocity_6));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_MoveVelocity_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_MoveVelocity_7));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_8));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_EntityAimData_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityAimData_9));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Mounter_10));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InputCommandDataProxy_byref_DynamicBuffer_1_InputCommandBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691282);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691283);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691284);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691285);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691286);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691287);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691288);
        PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691289);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandDataProxy;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy> forParameter_inputCommandDataProxy;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement> forParameter_inputCommandBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1148785, RefRangeEnd = 1148786, XrefRangeStart = 1148775, XrefRangeEnd = 1148785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PlayCommandsSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1148796, RefRangeEnd = 1148797, XrefRangeStart = 1148786, XrefRangeEnd = 1148796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandDataProxy));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandBuffer));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayCommandsSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691290);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691291);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandDataProxy;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy>.Runtime runtime_inputCommandDataProxy;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement>.Runtime runtime_inputCommandBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandDataProxy));
            PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandBuffer));
            PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.PlayCommandsSystem_Client/ProjectM.Network.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_0000613F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000613F$PostfixBurstDelegate");
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691292);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691293);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691294);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691295);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Network.PlayCommandsSystem_Client/ProjectM.Network.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_0000613F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148797, XrefRangeEnd = 1148811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148811, XrefRangeEnd = 1148829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148829, XrefRangeEnd = 1148844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1148871, RefRangeEnd = 1148872, XrefRangeStart = 1148844, XrefRangeEnd = 1148871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000613F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691296);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691297);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691298);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691299);
          PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691301);
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
            IL2CPP.il2cpp_field_static_get_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PlayCommandsSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
