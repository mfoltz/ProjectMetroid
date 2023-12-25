// Decompiled with JetBrains decompiler
// Type: HandleDismantleEventSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
public class HandleDismantleEventSystem : SystemBase
{
  private static readonly System.IntPtr NativeFieldInfoPtr__QueryDismantleEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
  private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
  private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
  private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr___DropInventoryJob_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryDismantle_Private_Void_Entity_Entity_SystemBase_GameDataSystem_EntityCommandBuffer_EntityCommandBuffer_ServerTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DropInventoryOnDismantle_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913799, XrefRangeEnd = 913833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleDismantleEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913833, XrefRangeEnd = 913834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleDismantleEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913834, XrefRangeEnd = 913869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleDismantleEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 913942, RefRangeEnd = 913943, XrefRangeStart = 913869, XrefRangeEnd = 913942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryDismantle(
    Entity character,
    Entity tileModelEntity,
    SystemBase systemBase,
    GameDataSystem gameDataSystem,
    EntityCommandBuffer spawnCommandBuffer,
    EntityCommandBuffer destroyCommandBuffer,
    ServerTime serverTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &character;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnCommandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.NativeMethodInfoPtr_TryDismantle_Private_Void_Entity_Entity_SystemBase_GameDataSystem_EntityCommandBuffer_EntityCommandBuffer_ServerTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914043, RefRangeEnd = 914044, XrefRangeStart = 913943, XrefRangeEnd = 914043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DropInventoryOnDismantle(Entity inventoryOwner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &inventoryOwner;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.NativeMethodInfoPtr_DropInventoryOnDismantle_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HandleDismantleEventSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914044, XrefRangeEnd = 914068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateForCompiler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleDismantleEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914072, RefRangeEnd = 914073, XrefRangeStart = 914068, XrefRangeEnd = 914072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Public_Static_Void_0()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HandleDismantleEventSystem()
  {
    Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HandleDismantleEventSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr);
    HandleDismantleEventSystem.NativeFieldInfoPtr__QueryDismantleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_QueryDismantleEvent));
    HandleDismantleEventSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_PlacementSystemData));
    HandleDismantleEventSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_SpawnBarrier));
    HandleDismantleEventSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_DestroyBarrier));
    HandleDismantleEventSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_GameDataSystem));
    HandleDismantleEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
    HandleDismantleEventSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
    HandleDismantleEventSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, "<>DropInventoryJob_profilerMarker");
    HandleDismantleEventSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_0));
    HandleDismantleEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663483);
    HandleDismantleEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663484);
    HandleDismantleEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663485);
    HandleDismantleEventSystem.NativeMethodInfoPtr_TryDismantle_Private_Void_Entity_Entity_SystemBase_GameDataSystem_EntityCommandBuffer_EntityCommandBuffer_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663486);
    HandleDismantleEventSystem.NativeMethodInfoPtr_DropInventoryOnDismantle_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663487);
    HandleDismantleEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663488);
    HandleDismantleEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663489);
    HandleDismantleEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, 100663490);
  }

  public HandleDismantleEventSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe EntityQuery _QueryDismantleEvent
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__QueryDismantleEvent));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__QueryDismantleEvent)) = value;
    }
  }

  public GetPlacementResult.SystemData _PlacementSystemData
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__PlacementSystemData);
      return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe SpawnBarrier _SpawnBarrier
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__SpawnBarrier));
      return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DestroyBarrier _DestroyBarrier
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__DestroyBarrier));
      return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameDataSystem _GameDataSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__GameDataSystem));
      return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabCollectionSystem _PrefabCollectionSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
      return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
  {
    get
    {
      return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__ServerDebugSettings));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe ProfilerMarker __DropInventoryJob_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_ServerTime_0
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_0));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleDismantleEventSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_0)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DropInventoryJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContainerPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_NativeList_1_Entity_0;
    [FieldOffset(0)]
    public BufferFromEntity<InventoryBuffer> GetInventoryBuffer;
    [FieldOffset(40)]
    public BufferFromEntity<InventoryInstanceElement> GetInventoryOwner;
    [FieldOffset(80)]
    public ComponentDataFromEntity<Translation> GetTranslation;
    [FieldOffset(112)]
    public EntityCommandBuffer CommandBuffer;
    [FieldOffset(128)]
    public Entity ContainerPrefab;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 913442, RefRangeEnd = 913443, XrefRangeStart = 913396, XrefRangeEnd = 913442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Execute(NativeList<Entity> entities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropInventoryJob()
    {
      Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, nameof (DropInventoryJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr);
      HandleDismantleEventSystem.DropInventoryJob.NativeFieldInfoPtr_GetInventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, nameof (GetInventoryBuffer));
      HandleDismantleEventSystem.DropInventoryJob.NativeFieldInfoPtr_GetInventoryOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, nameof (GetInventoryOwner));
      HandleDismantleEventSystem.DropInventoryJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, nameof (GetTranslation));
      HandleDismantleEventSystem.DropInventoryJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, nameof (CommandBuffer));
      HandleDismantleEventSystem.DropInventoryJob.NativeFieldInfoPtr_ContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, nameof (ContainerPrefab));
      HandleDismantleEventSystem.DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, 100663491);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleDismantleEventSystem.DropInventoryJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("HandleDismantleEventSystem/<>c__DisplayClass11_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass11_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_job;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DropInventoryOnDismantle_b__0_Internal_Void_0;
    [FieldOffset(0)]
    public NativeList<Entity> dropInventoryOnDeathEntities;
    [FieldOffset(16)]
    public HandleDismantleEventSystem.DropInventoryJob job;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass11_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _DropInventoryOnDismantle_b__0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__DropInventoryOnDismantle_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass11_0()
    {
      Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr);
      HandleDismantleEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
      HandleDismantleEventSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (job));
      HandleDismantleEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100663492);
      HandleDismantleEventSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__DropInventoryOnDismantle_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr, 100663493);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass11_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("HandleDismantleEventSystem/<>c__DisplayClass_DropInventoryJob")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_DropInventoryJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_job;
    private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleDismantleEventSystem_byref___c__DisplayClass11_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
    [FieldOffset(0)]
    public HandleDismantleEventSystem.DropInventoryJob job;
    [FieldOffset(136)]
    public NativeList<Entity> dropInventoryOnDeathEntities;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 913519, RefRangeEnd = 913520, XrefRangeStart = 913518, XrefRangeEnd = 913519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 913520, RefRangeEnd = 913522, XrefRangeStart = 913520, XrefRangeEnd = 913520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref HandleDismantleEventSystem.__c__DisplayClass11_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 913522, RefRangeEnd = 913524, XrefRangeStart = 913522, XrefRangeEnd = 913522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref HandleDismantleEventSystem.__c__DisplayClass11_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 913525, RefRangeEnd = 913526, XrefRangeStart = 913524, XrefRangeEnd = 913525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 913527, RefRangeEnd = 913529, XrefRangeStart = 913526, XrefRangeEnd = 913527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      HandleDismantleEventSystem componentSystem,
      ref HandleDismantleEventSystem.__c__DisplayClass11_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleDismantleEventSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913529, XrefRangeEnd = 913533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 913798, RefRangeEnd = 913799, XrefRangeStart = 913533, XrefRangeEnd = 913798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_DropInventoryJob()
    {
      Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleDismantleEventSystem>.NativeClassPtr, "<>c__DisplayClass_DropInventoryJob");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (job));
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663494);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663495);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663496);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663497);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleDismantleEventSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663498);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663499);
      HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100663500);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("HandleDismantleEventSystem/<>c__DisplayClass_DropInventoryJob/RunWithoutJobSystem_000000A6$PostfixBurstDelegate")]
    public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(void* jobData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        void* jobData,
        Il2CppSystem.AsyncCallback _param2,
        Il2CppSystem.Object _param3)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MulticastDelegateNPublicSealedVoObUnique()
      {
        Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, "RunWithoutJobSystem_000000A6$PostfixBurstDelegate");
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663501);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663502);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663503);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663504);
      }

      public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("HandleDismantleEventSystem/<>c__DisplayClass_DropInventoryJob/RunWithoutJobSystem_000000A6$BurstDirectCall")]
    public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913443, XrefRangeEnd = 913457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref _param0;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913457, XrefRangeEnd = 913475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe System.IntPtr GetFunctionPointer()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913475, XrefRangeEnd = 913490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Constructor()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 913517, RefRangeEnd = 913518, XrefRangeStart = 913490, XrefRangeEnd = 913517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Invoke(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ObjectNInternalAbstractSealedInPoDeInUnique()
      {
        Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, "RunWithoutJobSystem_000000A6$BurstDirectCall");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663505);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663506);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663507);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663508);
        HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663510);
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
          IL2CPP.il2cpp_field_static_get_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
          return pointer;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
        }
      }

      public static unsafe System.IntPtr DeferredCompilation
      {
        get
        {
          System.IntPtr deferredCompilation;
          IL2CPP.il2cpp_field_static_get_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
          return deferredCompilation;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleDismantleEventSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
        }
      }
    }
  }
}
