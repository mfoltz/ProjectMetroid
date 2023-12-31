// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Malee;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SpawnChainAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChainConfiguration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildPrefabBindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalTransitionAttemptCooldown;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAutoChainConfig_Private_Boolean_SpawnChainAssetElement_byref_AutoChainTransition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertAutoChainData_Public_Boolean_AutoChainTransition_byref_AutoChainTransitionConstants_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidChild_Public_Boolean_ChildPrefabBinding_Boolean_byref_ElementName_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigurationForChild_Private_SpawnChainAssetElement_ChildPrefabBinding_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMainElement_Public_SpawnChainAssetElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVisualElement_Public_SpawnChainAssetElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileSettingsElement_Public_SpawnChainAssetElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728090, XrefRangeEnd = 728350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728369, RefRangeEnd = 728370, XrefRangeStart = 728350, XrefRangeEnd = 728369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAutoChainConfig(
      SpawnChainAssetElement chainElement,
      out SharedSpawnChainConfiguration.AutoChainTransition transitionData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chainElement);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_TryGetAutoChainConfig_Private_Boolean_SpawnChainAssetElement_byref_AutoChainTransition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SharedSpawnChainConfiguration.AutoChainTransition local = ref transitionData;
      System.IntPtr pointer = zero;
      SharedSpawnChainConfiguration.AutoChainTransition autoChainTransition = pointer == System.IntPtr.Zero ? (SharedSpawnChainConfiguration.AutoChainTransition) null : new SharedSpawnChainConfiguration.AutoChainTransition(pointer);
      local = autoChainTransition;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728370, XrefRangeEnd = 728380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConvertAutoChainData(
      SharedSpawnChainConfiguration.AutoChainTransition transitionData,
      out AutoChainTransitionConstants result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transitionData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_TryConvertAutoChainData_Public_Boolean_AutoChainTransition_byref_AutoChainTransitionConstants_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728399, RefRangeEnd = 728400, XrefRangeStart = 728380, XrefRangeEnd = 728399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidChild(
      SpawnChainAuthoring.ChildPrefabBinding child,
      bool logErrors,
      out SpawnChainData.ElementName nativeElementName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logErrors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref nativeElementName;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_IsValidChild_Public_Boolean_ChildPrefabBinding_Boolean_byref_ElementName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 728408, RefRangeEnd = 728410, XrefRangeStart = 728400, XrefRangeEnd = 728408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAssetElement GetConfigurationForChild(
      SpawnChainAuthoring.ChildPrefabBinding spawnChainChild)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spawnChainChild);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_GetConfigurationForChild_Private_SpawnChainAssetElement_ChildPrefabBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728417, RefRangeEnd = 728418, XrefRangeStart = 728410, XrefRangeEnd = 728417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAssetElement GetMainElement()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_GetMainElement_Public_SpawnChainAssetElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728418, XrefRangeEnd = 728425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAssetElement GetVisualElement()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_GetVisualElement_Public_SpawnChainAssetElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728425, XrefRangeEnd = 728432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAssetElement GetTileSettingsElement()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_GetTileSettingsElement_Public_SpawnChainAssetElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728432, XrefRangeEnd = 728438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainAuthoring()
    {
      Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr);
      SpawnChainAuthoring.NativeFieldInfoPtr_SpawnChainAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (SpawnChainAsset));
      SpawnChainAuthoring.NativeFieldInfoPtr_ChainConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (ChainConfiguration));
      SpawnChainAuthoring.NativeFieldInfoPtr_ChildPrefabBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (ChildPrefabBindings));
      SpawnChainAuthoring.NativeFieldInfoPtr_GlobalTransitionAttemptCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (GlobalTransitionAttemptCooldown));
      SpawnChainAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664476);
      SpawnChainAuthoring.NativeMethodInfoPtr_TryGetAutoChainConfig_Private_Boolean_SpawnChainAssetElement_byref_AutoChainTransition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664477);
      SpawnChainAuthoring.NativeMethodInfoPtr_TryConvertAutoChainData_Public_Boolean_AutoChainTransition_byref_AutoChainTransitionConstants_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664478);
      SpawnChainAuthoring.NativeMethodInfoPtr_IsValidChild_Public_Boolean_ChildPrefabBinding_Boolean_byref_ElementName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664479);
      SpawnChainAuthoring.NativeMethodInfoPtr_GetConfigurationForChild_Private_SpawnChainAssetElement_ChildPrefabBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664480);
      SpawnChainAuthoring.NativeMethodInfoPtr_GetMainElement_Public_SpawnChainAssetElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664481);
      SpawnChainAuthoring.NativeMethodInfoPtr_GetVisualElement_Public_SpawnChainAssetElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664482);
      SpawnChainAuthoring.NativeMethodInfoPtr_GetTileSettingsElement_Public_SpawnChainAssetElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664483);
      SpawnChainAuthoring.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664484);
      SpawnChainAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664485);
      SpawnChainAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, 100664486);
    }

    public SpawnChainAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnChainAsset SpawnChainAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_SpawnChainAsset));
        return pointer == System.IntPtr.Zero ? (SpawnChainAsset) null : new SpawnChainAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_SpawnChainAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SharedSpawnChainConfiguration ChainConfiguration
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_ChainConfiguration));
        return pointer == System.IntPtr.Zero ? (SharedSpawnChainConfiguration) null : new SharedSpawnChainConfiguration(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_ChainConfiguration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAuthoring.ChildPrefabArray ChildPrefabBindings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_ChildPrefabBindings));
        return pointer == System.IntPtr.Zero ? (SpawnChainAuthoring.ChildPrefabArray) null : new SpawnChainAuthoring.ChildPrefabArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.NativeFieldInfoPtr_ChildPrefabBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe float GlobalTransitionAttemptCooldown
    {
      get
      {
        float transitionAttemptCooldown;
        IL2CPP.il2cpp_field_static_get_value(SpawnChainAuthoring.NativeFieldInfoPtr_GlobalTransitionAttemptCooldown, (void*) &transitionAttemptCooldown);
        return transitionAttemptCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpawnChainAuthoring.NativeFieldInfoPtr_GlobalTransitionAttemptCooldown, (void*) &value);
      }
    }

    [Serializable]
    public class ChildPrefabArray : ReorderableArray<SpawnChainAuthoring.ChildPrefabBinding>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728087, XrefRangeEnd = 728090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ChildPrefabArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.ChildPrefabArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChildPrefabArray()
      {
        Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (ChildPrefabArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabArray>.NativeClassPtr);
        SpawnChainAuthoring.ChildPrefabArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabArray>.NativeClassPtr, 100664487);
      }

      public ChildPrefabArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class ChildPrefabBinding : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChainElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ChildPrefabBinding()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainAuthoring.ChildPrefabBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChildPrefabBinding()
      {
        Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainAuthoring>.NativeClassPtr, nameof (ChildPrefabBinding));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr);
        SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_ChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr, nameof (ChainElement));
        SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr, nameof (Prefab));
        SpawnChainAuthoring.ChildPrefabBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAuthoring.ChildPrefabBinding>.NativeClassPtr, 100664488);
      }

      public ChildPrefabBinding(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpawnChainAssetElement ChainElement
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_ChainElement));
          return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_ChainElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WeakAssetReference<PrefabGuidComponent> Prefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_Prefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAuthoring.ChildPrefabBinding.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
