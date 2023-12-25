// Decompiled with JetBrains decompiler
// Type: ProjectM.PavementBonusSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class PavementBonusSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410679, XrefRangeEnd = 1410708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PavementBonusSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410708, XrefRangeEnd = 1410744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PavementBonusSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PavementBonusSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PavementBonusSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PavementBonusSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PavementBonusSystem()
    {
      Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (PavementBonusSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr);
      PavementBonusSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      PavementBonusSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, nameof (_ModificationSystem));
      PavementBonusSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, nameof (_ChunkRange));
      PavementBonusSystem.NativeFieldInfoPtr__TargetQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, nameof (_TargetQuery));
      PavementBonusSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, 100668638);
      PavementBonusSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, 100668639);
      PavementBonusSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, 100668640);
      PavementBonusSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, 100668641);
    }

    public PavementBonusSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _TargetQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__TargetQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PavementBonusSystem.NativeFieldInfoPtr__TargetQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdatePavementBonusJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PavementBonusType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MovementType;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloatModificationBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePositionFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileDataFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PavementBonusSourceFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachToParentsBufferFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModificationStructure;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(40)]
      public ComponentTypeHandle<PavementBonus> PavementBonusType;
      [FieldOffset(72)]
      public ComponentTypeHandle<Movement> MovementType;
      [FieldOffset(104)]
      public BufferTypeHandle<FloatModificationBuffer> FloatModificationBufferType;
      [FieldOffset(144)]
      public ComponentDataFromEntity<CastleFloor> CastleFloorFromEntity;
      [FieldOffset(176)]
      public ComponentDataFromEntity<TilePosition> TilePositionFromEntity;
      [FieldOffset(208)]
      public ComponentDataFromEntity<TileData> TileDataFromEntity;
      [FieldOffset(240)]
      public ComponentDataFromEntity<PavementBonusSource> PavementBonusSourceFromEntity;
      [FieldOffset(272)]
      public BufferFromEntity<CastleBuildingAttachToParentsBuffer> AttachToParentsBufferFromEntity;
      [FieldOffset(312)]
      public ModificationStructure ModificationStructure;
      [FieldOffset(344)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(424)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410629, XrefRangeEnd = 1410679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PavementBonusSystem.UpdatePavementBonusJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdatePavementBonusJob()
      {
        Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PavementBonusSystem>.NativeClassPtr, nameof (UpdatePavementBonusJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr);
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (EntityType));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (TranslationType));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_PavementBonusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (PavementBonusType));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (MovementType));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_FloatModificationBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (FloatModificationBufferType));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_CastleFloorFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (CastleFloorFromEntity));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_TilePositionFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (TilePositionFromEntity));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_TileDataFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (TileDataFromEntity));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_PavementBonusSourceFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (PavementBonusSourceFromEntity));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_AttachToParentsBufferFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (AttachToParentsBufferFromEntity));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_ModificationStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (ModificationStructure));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (SpatialLookupParams));
        PavementBonusSystem.UpdatePavementBonusJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, nameof (ChunkRange));
        PavementBonusSystem.UpdatePavementBonusJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, 100668642);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PavementBonusSystem.UpdatePavementBonusJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
