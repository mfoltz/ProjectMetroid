// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Tiles;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Behaviours
{
  public class BehaviourTreeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionDetectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiPrioritizationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__CleanupDeadBehaviourTreeQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleWorkstationQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiDamageTakenEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TransitionEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiDebugEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__Randoms;
    private static readonly System.IntPtr NativeFieldInfoPtr__DependencyBuilder;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341790, XrefRangeEnd = 1341873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341873, XrefRangeEnd = 1341891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341891, XrefRangeEnd = 1341898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TimeOfDay GetTimeOfDay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TimeOfDay*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341898, XrefRangeEnd = 1342223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342223, XrefRangeEnd = 1342294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342294, XrefRangeEnd = 1342310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342310, XrefRangeEnd = 1342326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342330, RefRangeEnd = 1342331, XrefRangeStart = 1342326, XrefRangeEnd = 1342330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342335, RefRangeEnd = 1342336, XrefRangeStart = 1342331, XrefRangeEnd = 1342335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeSystem()
    {
      Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr);
      BehaviourTreeSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      BehaviourTreeSystem.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_PostUpdateBarrier));
      BehaviourTreeSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      BehaviourTreeSystem.NativeFieldInfoPtr__CollisionDetectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_CollisionDetectionSystem));
      BehaviourTreeSystem.NativeFieldInfoPtr__AiPrioritizationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_AiPrioritizationSystem));
      BehaviourTreeSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BehaviourTreeSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      BehaviourTreeSystem.NativeFieldInfoPtr__CleanupDeadBehaviourTreeQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_CleanupDeadBehaviourTreeQuery));
      BehaviourTreeSystem.NativeFieldInfoPtr__CastleWorkstationQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_CastleWorkstationQuery));
      BehaviourTreeSystem.NativeFieldInfoPtr__AiDamageTakenEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_AiDamageTakenEventQuery));
      BehaviourTreeSystem.NativeFieldInfoPtr__TransitionEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_TransitionEventQuery));
      BehaviourTreeSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      BehaviourTreeSystem.NativeFieldInfoPtr__AiDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_AiDebugEnabled));
      BehaviourTreeSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_ServerTime));
      BehaviourTreeSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_WorldFrame));
      BehaviourTreeSystem.NativeFieldInfoPtr__Randoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_Randoms));
      BehaviourTreeSystem.NativeFieldInfoPtr__DependencyBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_DependencyBuilder));
      BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      BehaviourTreeSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_9));
      BehaviourTreeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665152);
      BehaviourTreeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665153);
      BehaviourTreeSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665154);
      BehaviourTreeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665155);
      BehaviourTreeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665156);
      BehaviourTreeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665157);
      BehaviourTreeSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665158);
      BehaviourTreeSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665159);
      BehaviourTreeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665160);
      BehaviourTreeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, 100665161);
    }

    public BehaviourTreeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionDetectionSystem_Server _CollisionDetectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CollisionDetectionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionDetectionSystem_Server) null : new CollisionDetectionSystem_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CollisionDetectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AiPrioritizationSystem _AiPrioritizationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiPrioritizationSystem));
        return pointer == System.IntPtr.Zero ? (AiPrioritizationSystem) null : new AiPrioritizationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiPrioritizationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _CleanupDeadBehaviourTreeQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CleanupDeadBehaviourTreeQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CleanupDeadBehaviourTreeQuery)) = value;
      }
    }

    public unsafe EntityQuery _CastleWorkstationQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CastleWorkstationQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__CastleWorkstationQuery)) = value;
      }
    }

    public unsafe EntityQuery _AiDamageTakenEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiDamageTakenEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiDamageTakenEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _TransitionEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TransitionEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__TransitionEventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<AiDebugEnabled> _AiDebugEnabled
    {
      get
      {
        return *(SingletonAccessor<AiDebugEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiDebugEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__AiDebugEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<AiDebugEnabled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<Unity.Mathematics.Random> _Randoms
    {
      get
      {
        return *(NativeArray<Unity.Mathematics.Random>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__Randoms));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__Randoms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Unity.Mathematics.Random>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<JobHandle> _DependencyBuilder
    {
      get
      {
        return *(NativeList<JobHandle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__DependencyBuilder));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__DependencyBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<JobHandle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_9
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BehaviourTreeJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_JobData;
      private static readonly System.IntPtr NativeFieldInfoPtr__Partials;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrioritizedEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBehaviourTree;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBehaviourTreeInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBlackboardElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNodeInstanceElement;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBehaviourTree_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Private_Void_byref_BehaviourTreeBlob_UInt16_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnTo_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandTransition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Transition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_GenericEnemyState_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Err_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_FixedString128_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AbortThisAndChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddToRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ShouldTick_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetRunningChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_NativeList_1_UInt16_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ExpandAction_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StoreScrubSnapshot_Private_Void_byref_BehaviourTreeExpansionContext_UInt16_BehaviourSnapshotType_Nullable_Unboxed_1_BehaviourTreeResult_0;
      [FieldOffset(0)]
      public BehaviourTreeJobData JobData;
      [FieldOffset(2360)]
      public NativeSlice<AiPrioritizationSystem.Entry> PrioritizedEntities;
      [FieldOffset(2376)]
      public ComponentDataFromEntity<BehaviourTree> GetBehaviourTree;
      [FieldOffset(2408)]
      public ComponentDataFromEntity<BehaviourTreeInstance> GetBehaviourTreeInstance;
      [FieldOffset(2440)]
      public BufferFromEntity<BlackboardElement> GetBlackboardElement;
      [FieldOffset(2480)]
      public BufferFromEntity<BehaviourTreeNodeInstanceElement> GetNodeInstanceElement;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341027, XrefRangeEnd = 1341033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341055, RefRangeEnd = 1341056, XrefRangeStart = 1341033, XrefRangeEnd = 1341055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Execute_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341066, RefRangeEnd = 1341067, XrefRangeStart = 1341056, XrefRangeEnd = 1341066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateBehaviourTree(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_UpdateBehaviourTree_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 1341094, RefRangeEnd = 1341109, XrefRangeStart = 1341067, XrefRangeEnd = 1341094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Expand(
        ref BehaviourTreeBlob treeBlob,
        ushort nodeIndex,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Expand_Private_Void_byref_BehaviourTreeBlob_UInt16_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1341129, RefRangeEnd = 1341139, XrefRangeStart = 1341109, XrefRangeEnd = 1341129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnTo(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ushort childNodeIndex,
        ref BehaviourTreeExpansionContext context,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnTo_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341144, RefRangeEnd = 1341145, XrefRangeStart = 1341139, XrefRangeEnd = 1341144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandRoot(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341149, RefRangeEnd = 1341150, XrefRangeStart = 1341145, XrefRangeEnd = 1341149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandTransition(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandTransition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1341172, RefRangeEnd = 1341174, XrefRangeStart = 1341150, XrefRangeEnd = 1341172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Transition(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        GenericEnemyState newState,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Transition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_GenericEnemyState_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToRoot(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341178, RefRangeEnd = 1341179, XrefRangeStart = 1341174, XrefRangeEnd = 1341178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandSequence(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341188, RefRangeEnd = 1341189, XrefRangeStart = 1341179, XrefRangeEnd = 1341188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToSequence(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ushort childNodeIndex,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341211, RefRangeEnd = 1341212, XrefRangeStart = 1341189, XrefRangeEnd = 1341211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandParallel(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341220, RefRangeEnd = 1341221, XrefRangeStart = 1341212, XrefRangeEnd = 1341220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Err(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ushort childNodeIndex,
        FixedString128 message,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &message;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Err_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_FixedString128_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341255, RefRangeEnd = 1341256, XrefRangeStart = 1341221, XrefRangeEnd = 1341255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToParallel(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ushort childNodeIndex,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341260, RefRangeEnd = 1341261, XrefRangeStart = 1341256, XrefRangeEnd = 1341260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandSelector(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341270, RefRangeEnd = 1341271, XrefRangeStart = 1341261, XrefRangeEnd = 1341270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToSelector(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ushort childNodeIndex,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341278, RefRangeEnd = 1341279, XrefRangeStart = 1341271, XrefRangeEnd = 1341278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandRandom(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341281, RefRangeEnd = 1341282, XrefRangeStart = 1341279, XrefRangeEnd = 1341281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToRandom(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341295, RefRangeEnd = 1341296, XrefRangeStart = 1341282, XrefRangeEnd = 1341295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandRandomSelector(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341315, RefRangeEnd = 1341316, XrefRangeStart = 1341296, XrefRangeEnd = 1341315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToRandomSelector(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341320, RefRangeEnd = 1341321, XrefRangeStart = 1341316, XrefRangeEnd = 1341320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandInverter(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341324, RefRangeEnd = 1341325, XrefRangeStart = 1341321, XrefRangeEnd = 1341324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToInverter(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341329, RefRangeEnd = 1341330, XrefRangeStart = 1341325, XrefRangeEnd = 1341329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandSucceeder(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341332, RefRangeEnd = 1341333, XrefRangeStart = 1341330, XrefRangeEnd = 1341332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToSucceeder(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341337, RefRangeEnd = 1341338, XrefRangeStart = 1341333, XrefRangeEnd = 1341337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandFailer(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341340, RefRangeEnd = 1341341, XrefRangeStart = 1341338, XrefRangeEnd = 1341340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToFailer(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341346, RefRangeEnd = 1341347, XrefRangeStart = 1341341, XrefRangeEnd = 1341346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandRepeater(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341361, RefRangeEnd = 1341362, XrefRangeStart = 1341347, XrefRangeEnd = 1341361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReturnToRepeater(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr,
        BehaviourTreeResult result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1341382, RefRangeEnd = 1341384, XrefRangeStart = 1341362, XrefRangeEnd = 1341382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AbortThisAndChildren(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_AbortThisAndChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1341395, RefRangeEnd = 1341397, XrefRangeStart = 1341384, XrefRangeEnd = 1341395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddToRunning(
        ushort nodeIndex,
        ref BehaviourTreeExpansionContext context,
        bool shouldTick)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &shouldTick;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_AddToRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1341406, RefRangeEnd = 1341411, XrefRangeStart = 1341397, XrefRangeEnd = 1341406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RemoveFromRunning(
        ushort nodeIndex,
        ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_RemoveFromRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341419, RefRangeEnd = 1341420, XrefRangeStart = 1341411, XrefRangeEnd = 1341419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool ShouldTick(ushort nodeIndex, ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ShouldTick_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341428, RefRangeEnd = 1341429, XrefRangeStart = 1341420, XrefRangeEnd = 1341428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsRunning(ushort nodeIndex, ref BehaviourTreeExpansionContext context)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_IsRunning_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1341439, RefRangeEnd = 1341441, XrefRangeStart = 1341429, XrefRangeEnd = 1341439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void GetRunningChildren(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        ref NativeList<ushort> result,
        int depth)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_GetRunningChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_NativeList_1_UInt16_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1341454, RefRangeEnd = 1341456, XrefRangeStart = 1341441, XrefRangeEnd = 1341454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ExpandAction(
        ref BehaviourTreeBlob treeBlob,
        ref BehaviourTreeNode node,
        ref BehaviourTreeExpansionContext context,
        NodeDataPtr nodeDataPtr)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref treeBlob;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref node;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeDataPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandAction_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StoreScrubSnapshot(
        ref BehaviourTreeExpansionContext context,
        ushort executedNodeIndex,
        BehaviourSnapshotType snapshotType,
        Nullable_Unboxed<BehaviourTreeResult> executionResult)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &executedNodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &executionResult;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_StoreScrubSnapshot_Private_Void_byref_BehaviourTreeExpansionContext_UInt16_BehaviourSnapshotType_Nullable_Unboxed_1_BehaviourTreeResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BehaviourTreeJob()
      {
        Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, nameof (BehaviourTreeJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr);
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_JobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (JobData));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr__Partials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (_Partials));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_PrioritizedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (PrioritizedEntities));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_GetBehaviourTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (GetBehaviourTree));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_GetBehaviourTreeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (GetBehaviourTreeInstance));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_GetBlackboardElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (GetBlackboardElement));
        BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr_GetNodeInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, nameof (GetNodeInstanceElement));
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665162);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Execute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665163);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_UpdateBehaviourTree_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665164);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Expand_Private_Void_byref_BehaviourTreeBlob_UInt16_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665165);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnTo_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665166);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665167);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandTransition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665168);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Transition_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_GenericEnemyState_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665169);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRoot_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665170);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665171);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSequence_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665172);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665173);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_Err_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_FixedString128_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665174);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToParallel_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665175);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665176);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_UInt16_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665177);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665178);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRandom_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665179);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665180);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRandomSelector_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665181);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665182);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToInverter_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665183);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665184);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToSucceeder_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665185);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665186);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToFailer_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665187);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665188);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ReturnToRepeater_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665189);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_AbortThisAndChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665190);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_AddToRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665191);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_RemoveFromRunning_Private_Void_UInt16_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665192);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ShouldTick_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665193);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_IsRunning_Private_Boolean_UInt16_byref_BehaviourTreeExpansionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665194);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_GetRunningChildren_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_byref_NativeList_1_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665195);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_ExpandAction_Private_Void_byref_BehaviourTreeBlob_byref_BehaviourTreeNode_byref_BehaviourTreeExpansionContext_NodeDataPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665196);
        BehaviourTreeSystem.BehaviourTreeJob.NativeMethodInfoPtr_StoreScrubSnapshot_Private_Void_byref_BehaviourTreeExpansionContext_UInt16_BehaviourSnapshotType_Nullable_Unboxed_1_BehaviourTreeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, 100665197);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.BehaviourTreeJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe BehaviourTreePartials _Partials
      {
        get
        {
          BehaviourTreePartials partials;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr__Partials, (void*) &partials);
          return partials;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.BehaviourTreeJob.NativeFieldInfoPtr__Partials, (void*) &value);
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/<>c__DisplayClass20_0")]
    public sealed class __c__DisplayClass20_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_behaviourTreeJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyTransitionEventCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Int32_byref_ToggleDisabledEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass20_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref ExternalBehaviourTreeTransitionRequest request)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        int nativeThreadIndex,
        [In] ref ToggleDisabledEvent toggleDisabledEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &nativeThreadIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref toggleDisabledEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Int32_byref_ToggleDisabledEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass20_0()
      {
        Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>c__DisplayClass20_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr);
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_behaviourTreeJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (behaviourTreeJobData));
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_destroyTransitionEventCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (destroyTransitionEventCommandBuffer));
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, 100665199);
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, 100665200);
        BehaviourTreeSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Int32_byref_ToggleDisabledEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, 100665201);
      }

      public __c__DisplayClass20_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass20_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass20_0>.NativeClassPtr, data));
      }

      public unsafe BehaviourTreeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BehaviourTreeSystem) null : new BehaviourTreeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BehaviourTreeJobData behaviourTreeJobData
      {
        get
        {
          return *(BehaviourTreeJobData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_behaviourTreeJobData));
        }
        [param: In] set
        {
          *(BehaviourTreeJobData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_behaviourTreeJobData)) = value;
        }
      }

      public unsafe EntityCommandBuffer destroyTransitionEventCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_destroyTransitionEventCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_destroyTransitionEventCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_behaviourTreeJobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyTransitionEventCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BlackboardElement_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeNodeInstanceElement_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeInstance_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTree_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BehaviourTreeJobData behaviourTreeJobData;
      [FieldOffset(2360)]
      public EntityCommandBuffer destroyTransitionEventCommandBuffer;
      [FieldOffset(2376)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(2408)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_1;
      [FieldOffset(2440)]
      public BufferFromEntity<BlackboardElement> _BufferFromEntity_BlackboardElement_2;
      [FieldOffset(2480)]
      public BufferFromEntity<BehaviourTreeNodeInstanceElement> _BufferFromEntity_BehaviourTreeNodeInstanceElement_3;
      [FieldOffset(2520)]
      public ComponentDataFromEntity<BehaviourTreeInstance> _ComponentDataFromEntity_BehaviourTreeInstance_4;
      [FieldOffset(2552)]
      public ComponentDataFromEntity<BehaviourTree> _ComponentDataFromEntity_BehaviourTree_5;
      [FieldOffset(2584)]
      public BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2624)]
      public unsafe BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341541, XrefRangeEnd = 1341565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ExternalBehaviourTreeTransitionRequest request)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341566, RefRangeEnd = 1341567, XrefRangeStart = 1341565, XrefRangeEnd = 1341566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341568, RefRangeEnd = 1341569, XrefRangeStart = 1341567, XrefRangeEnd = 1341568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341569, XrefRangeEnd = 1341571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341577, RefRangeEnd = 1341578, XrefRangeStart = 1341571, XrefRangeEnd = 1341577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341598, RefRangeEnd = 1341599, XrefRangeStart = 1341578, XrefRangeEnd = 1341598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BehaviourTreeSystem componentSystem,
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341599, XrefRangeEnd = 1341603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341603, XrefRangeEnd = 1341609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_behaviourTreeJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (behaviourTreeJobData));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_destroyTransitionEventCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (destroyTransitionEventCommandBuffer));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_1));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_BlackboardElement_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_BufferFromEntity_BlackboardElement_2));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeNodeInstanceElement_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_BufferFromEntity_BehaviourTreeNodeInstanceElement_3));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeInstance_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTreeInstance_4));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTree_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTree_5));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ExternalBehaviourTreeTransitionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665202);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665203);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665204);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665205);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665206);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665207);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665208);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665209);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_request;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ExternalBehaviourTreeTransitionRequest> forParameter_request;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341460, RefRangeEnd = 1341461, XrefRangeStart = 1341456, XrefRangeEnd = 1341460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BehaviourTreeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341465, RefRangeEnd = 1341466, XrefRangeStart = 1341461, XrefRangeEnd = 1341465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_request));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665210);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665211);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_request;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ExternalBehaviourTreeTransitionRequest>.Runtime runtime_request;

          static Runtimes()
          {
            Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_request));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Behaviours.RunWithoutJobSystem_000005EA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000005EA$PostfixBurstDelegate");
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665212);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665213);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665214);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665215);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Behaviours.RunWithoutJobSystem_000005EA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341466, XrefRangeEnd = 1341480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341480, XrefRangeEnd = 1341498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341498, XrefRangeEnd = 1341513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341540, RefRangeEnd = 1341541, XrefRangeStart = 1341513, XrefRangeEnd = 1341540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000005EA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665216);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665217);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665218);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665219);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665221);
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
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeInstance_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BlackboardElement_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeNodeInstanceElement_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTree_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpawnTransform_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_VBloodUnit_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_8;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_9;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_byref_ToggleDisabledEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<BehaviourTreeInstance> _ComponentDataFromEntity_BehaviourTreeInstance_0;
      [FieldOffset(32)]
      public BufferFromEntity<BlackboardElement> _BufferFromEntity_BlackboardElement_1;
      [FieldOffset(72)]
      public BufferFromEntity<BehaviourTreeNodeInstanceElement> _BufferFromEntity_BehaviourTreeNodeInstanceElement_2;
      [FieldOffset(112)]
      public ComponentDataFromEntity<BehaviourTree> _ComponentDataFromEntity_BehaviourTree_3;
      [FieldOffset(144)]
      public ComponentDataFromEntity<SpawnTransform> _ComponentDataFromEntity_SpawnTransform_4;
      [FieldOffset(176)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_5;
      [FieldOffset(208)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_6;
      [FieldOffset(240)]
      public ComponentDataFromEntity<VBloodUnit> _ComponentDataFromEntity_VBloodUnit_7;
      [FieldOffset(272)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_8;
      [FieldOffset(304)]
      public ComponentDataFromEntity<LastTranslation> _ComponentDataFromEntity_LastTranslation_9;
      [FieldOffset(336)]
      public BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(376)]
      public unsafe BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341694, XrefRangeEnd = 1341740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        int nativeThreadIndex,
        [In] ref ToggleDisabledEvent toggleDisabledEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &nativeThreadIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref toggleDisabledEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_byref_ToggleDisabledEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341740, XrefRangeEnd = 1341742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341747, RefRangeEnd = 1341748, XrefRangeStart = 1341742, XrefRangeEnd = 1341747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1341779, RefRangeEnd = 1341780, XrefRangeStart = 1341748, XrefRangeEnd = 1341779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BehaviourTreeSystem componentSystem,
        ref BehaviourTreeSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341780, XrefRangeEnd = 1341784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341784, XrefRangeEnd = 1341790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeInstance_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTreeInstance_0));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__BufferFromEntity_BlackboardElement_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_BufferFromEntity_BlackboardElement_1));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeNodeInstanceElement_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_BufferFromEntity_BehaviourTreeNodeInstanceElement_2));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTree_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTree_3));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnTransform_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpawnTransform_4));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_5));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_6));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_VBloodUnit_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_VBloodUnit_7));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_8));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_LastTranslation_9));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_byref_ToggleDisabledEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665222);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665223);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665224);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665225);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665226);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665227);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665228);
        BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665229);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_nativeThreadIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_toggleDisabledEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_NativeThreadIndex forParameter_nativeThreadIndex;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ToggleDisabledEvent> forParameter_toggleDisabledEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341613, RefRangeEnd = 1341614, XrefRangeStart = 1341609, XrefRangeEnd = 1341613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BehaviourTreeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341618, RefRangeEnd = 1341619, XrefRangeStart = 1341614, XrefRangeEnd = 1341618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_nativeThreadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_nativeThreadIndex));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_toggleDisabledEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_toggleDisabledEvent));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665230);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665231);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_nativeThreadIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_toggleDisabledEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_NativeThreadIndex.Runtime runtime_nativeThreadIndex;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ToggleDisabledEvent>.Runtime runtime_toggleDisabledEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_nativeThreadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_nativeThreadIndex));
            BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_toggleDisabledEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_toggleDisabledEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.Behaviours.RunWithoutJobSystem_000005F3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000005F3$PostfixBurstDelegate");
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665232);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665233);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665234);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665235);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeSystem/ProjectM.Behaviours.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.Behaviours.RunWithoutJobSystem_000005F3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341619, XrefRangeEnd = 1341633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341633, XrefRangeEnd = 1341651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341651, XrefRangeEnd = 1341666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1341693, RefRangeEnd = 1341694, XrefRangeStart = 1341666, XrefRangeEnd = 1341693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000005F3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665236);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665237);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665238);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665239);
          BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665241);
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
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
