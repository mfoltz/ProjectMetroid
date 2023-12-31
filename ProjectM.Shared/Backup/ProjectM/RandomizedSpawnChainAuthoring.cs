// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RandomizedSpawnChainAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultConfiguration;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727909, XrefRangeEnd = 727924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstEntityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727924, XrefRangeEnd = 727930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool TryGetTileSnappingSettings(
      out TilePivotSettings pivotSettings,
      out TileSnapType snapType,
      out Nullable_Unboxed<HeightPlacementConfig> heightPlacementConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref heightPlacementConfig;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IChunkSummaryDataSource_FillTree(
      ChunkSummaryBuilder summary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summary);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomizedSpawnChainAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RandomizedSpawnChainAuthoring()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChainAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr);
      RandomizedSpawnChainAuthoring.NativeFieldInfoPtr_DefaultConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr, nameof (DefaultConfiguration));
      RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr, 100664459);
      RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr, 100664460);
      RandomizedSpawnChainAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr, 100664461);
      RandomizedSpawnChainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainAuthoring>.NativeClassPtr, 100664462);
    }

    public RandomizedSpawnChainAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RandomizedSpawnChainSettingsAuthoring DefaultConfiguration
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainAuthoring.NativeFieldInfoPtr_DefaultConfiguration));
        return pointer == System.IntPtr.Zero ? (RandomizedSpawnChainSettingsAuthoring) null : new RandomizedSpawnChainSettingsAuthoring(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainAuthoring.NativeFieldInfoPtr_DefaultConfiguration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
