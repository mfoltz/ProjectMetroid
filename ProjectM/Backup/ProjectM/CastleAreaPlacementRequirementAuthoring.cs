// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleAreaPlacementRequirementAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CastleAreaPlacementRequirementAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CastleAreaRequirement;
    private static readonly IntPtr NativeFieldInfoPtr_BlockPlacementOnRoads;
    private static readonly IntPtr NativeFieldInfoPtr_BlockPlacementNearVampires;
    private static readonly IntPtr NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState;
    private static readonly IntPtr NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989183, XrefRangeEnd = 989189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989189, XrefRangeEnd = 989192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989192, XrefRangeEnd = 989193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleAreaPlacementRequirementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleAreaPlacementRequirementAuthoring()
    {
      Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleAreaPlacementRequirementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr);
      CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_CastleAreaRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, nameof (CastleAreaRequirement));
      CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementOnRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, nameof (BlockPlacementOnRoads));
      CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementNearVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, nameof (BlockPlacementNearVampires));
      CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, nameof (AllowPlaceInObjectsInRepairState));
      CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, nameof (AllowTilesStickingOutOfTerritory));
      CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, 100676327);
      CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, 100676328);
      CastleAreaPlacementRequirementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAreaPlacementRequirementAuthoring>.NativeClassPtr, 100676329);
    }

    public CastleAreaPlacementRequirementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleAreaRequirementType CastleAreaRequirement
    {
      get
      {
        return *(CastleAreaRequirementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_CastleAreaRequirement));
      }
      [param: In] set
      {
        *(CastleAreaRequirementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_CastleAreaRequirement)) = value;
      }
    }

    public unsafe bool BlockPlacementOnRoads
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementOnRoads));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementOnRoads)) = value;
      }
    }

    public unsafe bool BlockPlacementNearVampires
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementNearVampires));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_BlockPlacementNearVampires)) = value;
      }
    }

    public unsafe bool AllowPlaceInObjectsInRepairState
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState)) = value;
      }
    }

    public unsafe bool AllowTilesStickingOutOfTerritory
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAreaPlacementRequirementAuthoring.NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory)) = value;
      }
    }
  }
}
