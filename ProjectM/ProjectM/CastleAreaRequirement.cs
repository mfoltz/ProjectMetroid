// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleAreaRequirement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleAreaRequirement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequirementType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockPlacementOnRoads;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockPlacementNearVampires;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory;
    [FieldOffset(0)]
    public CastleAreaRequirementType RequirementType;
    [FieldOffset(4)]
    public bool BlockPlacementOnRoads;
    [FieldOffset(5)]
    public bool BlockPlacementNearVampires;
    [FieldOffset(6)]
    public bool AllowPlaceInObjectsInRepairState;
    [FieldOffset(7)]
    public bool AllowTilesStickingOutOfTerritory;

    static CastleAreaRequirement()
    {
      Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleAreaRequirement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr);
      CastleAreaRequirement.NativeFieldInfoPtr_RequirementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, nameof (RequirementType));
      CastleAreaRequirement.NativeFieldInfoPtr_BlockPlacementOnRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, nameof (BlockPlacementOnRoads));
      CastleAreaRequirement.NativeFieldInfoPtr_BlockPlacementNearVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, nameof (BlockPlacementNearVampires));
      CastleAreaRequirement.NativeFieldInfoPtr_AllowPlaceInObjectsInRepairState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, nameof (AllowPlaceInObjectsInRepairState));
      CastleAreaRequirement.NativeFieldInfoPtr_AllowTilesStickingOutOfTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, nameof (AllowTilesStickingOutOfTerritory));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAreaRequirement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
