// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantSummonIfIdleOutsideTerritorySystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using ProjectM.CastleBuilding;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ServantSummonIfIdleOutsideTerritorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInTerritory_Private_Static_Boolean_byref_Translation_byref_ServantConnectedCoffin_byref_ComponentDataFromEntity_1_CastleHeartConnection_byref_ComponentDataFromEntity_1_CastleHeart_byref_ComponentDataFromEntity_1_CastleTerritory_byref_BufferFromEntity_1_CastleTerritoryTiles_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419947, XrefRangeEnd = 1419968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419968, XrefRangeEnd = 1420016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1420051, RefRangeEnd = 1420052, XrefRangeStart = 1420016, XrefRangeEnd = 1420051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInTerritory(
      [In] ref Translation translation,
      [In] ref ServantConnectedCoffin servantConnectedCoffin,
      [In] ref ComponentDataFromEntity<CastleHeartConnection> getCastleHeartConnection,
      [In] ref ComponentDataFromEntity<CastleHeart> getCastleHeart,
      [In] ref ComponentDataFromEntity<CastleTerritory> getCastleTerritory,
      [In] ref BufferFromEntity<CastleTerritoryTiles> getCastleTerritoryTiles)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantConnectedCoffin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleHeartConnection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleTerritoryTiles;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_IsInTerritory_Private_Static_Boolean_byref_Translation_byref_ServantConnectedCoffin_byref_ComponentDataFromEntity_1_CastleHeartConnection_byref_ComponentDataFromEntity_1_CastleHeart_byref_ComponentDataFromEntity_1_CastleTerritory_byref_BufferFromEntity_1_CastleTerritoryTiles_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantSummonIfIdleOutsideTerritorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantSummonIfIdleOutsideTerritorySystem()
    {
      Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ServantSummonIfIdleOutsideTerritorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr);
      ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, nameof (_Query));
      ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, nameof (_ChunkRange));
      ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, 100669563);
      ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, 100669564);
      ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_IsInTerritory_Private_Static_Boolean_byref_Translation_byref_ServantConnectedCoffin_byref_ComponentDataFromEntity_1_CastleHeartConnection_byref_ComponentDataFromEntity_1_CastleHeart_byref_ComponentDataFromEntity_1_CastleTerritory_byref_BufferFromEntity_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, 100669565);
      ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, 100669566);
      ServantSummonIfIdleOutsideTerritorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, 100669567);
    }

    public ServantSummonIfIdleOutsideTerritorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSummonIfIdleOutsideTerritorySystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FindSomeIdleServantsOutsideTerritoryJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_BehaviourTreeStateType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantConnectedCoffinType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeartConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTerritory;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTerritoryTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(40)]
      public ComponentTypeHandle<BehaviourTreeState> BehaviourTreeStateType;
      [FieldOffset(72)]
      public ComponentTypeHandle<ServantConnectedCoffin> ServantConnectedCoffinType;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleHeartConnection> GetCastleHeartConnection;
      [FieldOffset(136)]
      public ComponentDataFromEntity<CastleHeart> GetCastleHeart;
      [FieldOffset(168)]
      public ComponentDataFromEntity<CastleTerritory> GetCastleTerritory;
      [FieldOffset(200)]
      public BufferFromEntity<CastleTerritoryTiles> GetCastleTerritoryTiles;
      [FieldOffset(240)]
      public NativeQueue<Entity> Result;
      [FieldOffset(264)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419921, XrefRangeEnd = 1419947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FindSomeIdleServantsOutsideTerritoryJob()
      {
        Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem>.NativeClassPtr, nameof (FindSomeIdleServantsOutsideTerritoryJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr);
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (EntityType));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (TranslationType));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_BehaviourTreeStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (BehaviourTreeStateType));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_ServantConnectedCoffinType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (ServantConnectedCoffinType));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_GetCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (GetCastleHeartConnection));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_GetCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (GetCastleHeart));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_GetCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (GetCastleTerritory));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_GetCastleTerritoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (GetCastleTerritoryTiles));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (Result));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, nameof (ChunkRange));
        ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, 100669568);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantSummonIfIdleOutsideTerritorySystem.FindSomeIdleServantsOutsideTerritoryJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
