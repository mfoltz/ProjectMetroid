// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingHeightPickingComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Physics;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingHeightPickingComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilterFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverridePickingPivot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsePlayerPickingPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewHeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapToClosestStandardHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConfig_Public_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1127190, RefRangeEnd = 1127191, XrefRangeStart = 1127178, XrefRangeEnd = 1127190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeightPlacementConfig GetConfig()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingHeightPickingComponent.NativeMethodInfoPtr_GetConfig_Public_HeightPlacementConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HeightPlacementConfig*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingHeightPickingComponent.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127191, XrefRangeEnd = 1127192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingHeightPickingComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingHeightPickingComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingHeightPickingComponent()
    {
      Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingHeightPickingComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr);
      CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_CollisionFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, nameof (CollisionFilterFlags));
      CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_OverridePickingPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, nameof (OverridePickingPivot));
      CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_UsePlayerPickingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, nameof (UsePlayerPickingPlane));
      CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_PreviewHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, nameof (PreviewHeightOffset));
      CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_SnapToClosestStandardHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, nameof (SnapToClosestStandardHeight));
      CastleBuildingHeightPickingComponent.NativeMethodInfoPtr_GetConfig_Public_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, 100689527);
      CastleBuildingHeightPickingComponent.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Virtual_Final_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, 100689528);
      CastleBuildingHeightPickingComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingHeightPickingComponent>.NativeClassPtr, 100689529);
    }

    public CastleBuildingHeightPickingComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CollisionFilterFlags CollisionFilterFlags
    {
      get
      {
        return *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_CollisionFilterFlags));
      }
      [param: In] set
      {
        *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_CollisionFilterFlags)) = value;
      }
    }

    public unsafe Transform OverridePickingPivot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_OverridePickingPivot));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_OverridePickingPivot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UsePlayerPickingPlane
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_UsePlayerPickingPlane));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_UsePlayerPickingPlane)) = value;
      }
    }

    public unsafe float PreviewHeightOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_PreviewHeightOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_PreviewHeightOffset)) = value;
      }
    }

    public unsafe bool SnapToClosestStandardHeight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_SnapToClosestStandardHeight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingHeightPickingComponent.NativeFieldInfoPtr_SnapToClosestStandardHeight)) = value;
      }
    }
  }
}
