// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileDatasComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileDatasComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanMoveAfterSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_PivotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomPivotPoint;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PivotSettings_Public_get_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveVersion_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAttachBufferRequirements_Private_Void_byref_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCalculateTileBounds_Public_Boolean_Il2CppStructArray_1_TileBrushType_byref_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTotalBounds_Public_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsForTiles_Public_Static_BoundsMinMax_IEnumerable_1_T_Func_2_T_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTilesForBrushType_Private_Il2CppStructArray_1_int2_TileBrushType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectSpaceTileBounds_Public_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalTileRotation_Public_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe TilePivotSettings PivotSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_get_PivotSettings_Public_get_TilePivotSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TilePivotSettings*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Version
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int ActiveVersion
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_get_ActiveVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085755, XrefRangeEnd = 1085787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085787, XrefRangeEnd = 1085794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileDatasComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1085823, RefRangeEnd = 1085825, XrefRangeStart = 1085794, XrefRangeEnd = 1085823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAttachBufferRequirements(
      out bool needsParentBuffer,
      out bool needsChildrenBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref needsParentBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref needsChildrenBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_GetAttachBufferRequirements_Private_Void_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085825, XrefRangeEnd = 1085846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryCalculateTileBounds(
      Il2CppStructArray<TileBrushType> brushTypesPriorityOrder,
      out BoundsMinMax bounds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brushTypesPriorityOrder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_TryCalculateTileBounds_Public_Boolean_Il2CppStructArray_1_TileBrushType_byref_BoundsMinMax_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085846, XrefRangeEnd = 1085894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax CalculateTotalBounds()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_CalculateTotalBounds_Public_BoundsMinMax_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085909, RefRangeEnd = 1085910, XrefRangeStart = 1085894, XrefRangeEnd = 1085909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetBoundsForTiles<T>(
      IEnumerable<T> tiles,
      Il2CppSystem.Func<T, int2> getTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tiles);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getTile);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.MethodInfoStoreGeneric_GetBoundsForTiles_Public_Static_BoundsMinMax_IEnumerable_1_T_Func_2_T_int2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085937, RefRangeEnd = 1085938, XrefRangeStart = 1085910, XrefRangeEnd = 1085937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppStructArray<int2> GetTilesForBrushType(TileBrushType brushType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &brushType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_GetTilesForBrushType_Private_Il2CppStructArray_1_int2_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int2>) null : new Il2CppStructArray<int2>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085938, XrefRangeEnd = 1085940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085940, XrefRangeEnd = 1085950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetObjectSpaceTileBounds(BoundsMinMax localBounds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localBounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_GetObjectSpaceTileBounds_Public_BoundsMinMax_BoundsMinMax_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085950, XrefRangeEnd = 1085954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileRotation GetGlobalTileRotation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr_GetGlobalTileRotation_Public_TileRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085954, XrefRangeEnd = 1085962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileDatasComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileDatasComponent()
    {
      Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileDatasComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr);
      TileDatasComponent.NativeFieldInfoPtr_CanMoveAfterSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, nameof (CanMoveAfterSpawn));
      TileDatasComponent.NativeFieldInfoPtr_TileDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, nameof (TileDatas));
      TileDatasComponent.NativeFieldInfoPtr_TileModelLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, nameof (TileModelLayer));
      TileDatasComponent.NativeFieldInfoPtr_PivotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, nameof (PivotType));
      TileDatasComponent.NativeFieldInfoPtr_CustomPivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, nameof (CustomPivotPoint));
      TileDatasComponent.NativeMethodInfoPtr_get_PivotSettings_Public_get_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685522);
      TileDatasComponent.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685523);
      TileDatasComponent.NativeMethodInfoPtr_get_ActiveVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685524);
      TileDatasComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685525);
      TileDatasComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685526);
      TileDatasComponent.NativeMethodInfoPtr_GetAttachBufferRequirements_Private_Void_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685527);
      TileDatasComponent.NativeMethodInfoPtr_TryCalculateTileBounds_Public_Boolean_Il2CppStructArray_1_TileBrushType_byref_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685528);
      TileDatasComponent.NativeMethodInfoPtr_CalculateTotalBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685529);
      TileDatasComponent.NativeMethodInfoPtr_GetBoundsForTiles_Public_Static_BoundsMinMax_IEnumerable_1_T_Func_2_T_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685530);
      TileDatasComponent.NativeMethodInfoPtr_GetTilesForBrushType_Private_Il2CppStructArray_1_int2_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685531);
      TileDatasComponent.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685532);
      TileDatasComponent.NativeMethodInfoPtr_GetObjectSpaceTileBounds_Public_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685533);
      TileDatasComponent.NativeMethodInfoPtr_GetGlobalTileRotation_Public_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685534);
      TileDatasComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, 100685535);
    }

    public TileDatasComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool CanMoveAfterSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_CanMoveAfterSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_CanMoveAfterSpawn)) = value;
      }
    }

    public unsafe List<TileBrushData> TileDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_TileDatas));
        return pointer == System.IntPtr.Zero ? (List<TileBrushData>) null : new List<TileBrushData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_TileDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelLayerEnum TileModelLayer
    {
      get
      {
        return *(TileModelLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_TileModelLayer));
      }
      [param: In] set
      {
        *(TileModelLayerEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_TileModelLayer)) = value;
      }
    }

    public unsafe TilePivotType PivotType
    {
      get
      {
        return *(TilePivotType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_PivotType));
      }
      [param: In] set
      {
        *(TilePivotType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_PivotType)) = value;
      }
    }

    public unsafe float2 CustomPivotPoint
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_CustomPivotPoint));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileDatasComponent.NativeFieldInfoPtr_CustomPivotPoint)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Tiles.TileDatasComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryCalculateTileBounds_b__14_0_Internal_int2_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CalculateTotalBounds_b__15_0_Internal_int2_int2_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(231)]
      [CachedScanResults(RefRangeStart = 76210, RefRangeEnd = 76441, XrefRangeStart = 76210, XrefRangeEnd = 76441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int2 _TryCalculateTileBounds_b__14_0(int2 x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.__c.NativeMethodInfoPtr__TryCalculateTileBounds_b__14_0_Internal_int2_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(231)]
      [CachedScanResults(RefRangeStart = 76210, RefRangeEnd = 76441, XrefRangeStart = 76210, XrefRangeEnd = 76441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int2 _CalculateTotalBounds_b__15_0(int2 x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileDatasComponent.__c.NativeMethodInfoPtr__CalculateTotalBounds_b__15_0_Internal_int2_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr);
        TileDatasComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, "<>9");
        TileDatasComponent.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, "<>9__14_0");
        TileDatasComponent.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, "<>9__15_0");
        TileDatasComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, 100685537);
        TileDatasComponent.__c.NativeMethodInfoPtr__TryCalculateTileBounds_b__14_0_Internal_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, 100685538);
        TileDatasComponent.__c.NativeMethodInfoPtr__CalculateTotalBounds_b__15_0_Internal_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDatasComponent.__c>.NativeClassPtr, 100685539);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TileDatasComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TileDatasComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TileDatasComponent.__c) null : new TileDatasComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TileDatasComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<int2, int2> __9__14_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TileDatasComponent.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int2, int2>) null : new Il2CppSystem.Func<int2, int2>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TileDatasComponent.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<int2, int2> __9__15_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TileDatasComponent.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int2, int2>) null : new Il2CppSystem.Func<int2, int2>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TileDatasComponent.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_GetBoundsForTiles_Public_Static_BoundsMinMax_IEnumerable_1_T_Func_2_T_int2_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDatasComponent.NativeMethodInfoPtr_GetBoundsForTiles_Public_Static_BoundsMinMax_IEnumerable_1_T_Func_2_T_int2_0, Il2CppClassPointerStore<TileDatasComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
