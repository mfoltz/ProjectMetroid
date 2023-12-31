// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleFloor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Roofs;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleFloor
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoofType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroundConnectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Impassable;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorNorth;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorEast;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorSouth;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorWest;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourFloorDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallNorth;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallEast;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallSouth;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallWest;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbourFloors_Public_CastleFloorNeighbourEnumerator_ComponentDataFromEntity_1_PlacementDestroyData_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbourFloor_Public_NeighbourData_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWall_Public_Entity_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNeighbourFloor_Public_Void_Entity_CardinalDirection_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetWall_Public_Void_Entity_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearFloors_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearWalls_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public CastleFloorTypes FloorType;
    [FieldOffset(1)]
    public RoofCategoryType RoofType;
    [FieldOffset(2)]
    public GroundConnectionType GroundConnectionType;
    [FieldOffset(3)]
    public bool Impassable;
    [FieldOffset(4)]
    public NeighbourData NeighbourFloorNorth;
    [FieldOffset(16)]
    public NeighbourData NeighbourFloorEast;
    [FieldOffset(28)]
    public NeighbourData NeighbourFloorSouth;
    [FieldOffset(40)]
    public NeighbourData NeighbourFloorWest;
    [FieldOffset(52)]
    public NeighbourData NeighbourFloorUp;
    [FieldOffset(64)]
    public NeighbourData NeighbourFloorDown;
    [FieldOffset(76)]
    public Entity WallNorth;
    [FieldOffset(84)]
    public Entity WallEast;
    [FieldOffset(92)]
    public Entity WallSouth;
    [FieldOffset(100)]
    public Entity WallWest;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794236, RefRangeEnd = 794237, XrefRangeStart = 794236, XrefRangeEnd = 794236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleFloorNeighbourEnumerator GetNeighbourFloors(
      ComponentDataFromEntity<PlacementDestroyData> getPlacementDestroyData,
      NeighbourFilter requireFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &getPlacementDestroyData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requireFilter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_GetNeighbourFloors_Public_CastleFloorNeighbourEnumerator_ComponentDataFromEntity_1_PlacementDestroyData_NeighbourFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleFloorNeighbourEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 794237, RefRangeEnd = 794246, XrefRangeStart = 794237, XrefRangeEnd = 794237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NeighbourData GetNeighbourFloor(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_GetNeighbourFloor_Public_NeighbourData_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NeighbourData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 794247, RefRangeEnd = 794251, XrefRangeStart = 794246, XrefRangeEnd = 794247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetWall(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_GetWall_Public_Entity_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794252, RefRangeEnd = 794255, XrefRangeStart = 794251, XrefRangeEnd = 794252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetNeighbourFloor(
      Entity tileModel,
      CardinalDirection direction,
      NeighbourFilter matchingFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &matchingFilter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_SetNeighbourFloor_Public_Void_Entity_CardinalDirection_NeighbourFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794255, RefRangeEnd = 794258, XrefRangeStart = 794255, XrefRangeEnd = 794255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWall(Entity tileModel, CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_SetWall_Public_Void_Entity_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794258, RefRangeEnd = 794260, XrefRangeStart = 794258, XrefRangeEnd = 794258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearFloors()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_ClearFloors_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794264, RefRangeEnd = 794266, XrefRangeStart = 794260, XrefRangeEnd = 794264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearWalls()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_ClearWalls_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794266, XrefRangeEnd = 794328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CastleFloor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CastleFloor()
    {
      Il2CppClassPointerStore<CastleFloor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleFloor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr);
      CastleFloor.NativeFieldInfoPtr_FloorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (FloorType));
      CastleFloor.NativeFieldInfoPtr_RoofType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (RoofType));
      CastleFloor.NativeFieldInfoPtr_GroundConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (GroundConnectionType));
      CastleFloor.NativeFieldInfoPtr_Impassable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (Impassable));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorNorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorNorth));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorEast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorEast));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorSouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorSouth));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorWest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorWest));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorUp));
      CastleFloor.NativeFieldInfoPtr_NeighbourFloorDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (NeighbourFloorDown));
      CastleFloor.NativeFieldInfoPtr_WallNorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (WallNorth));
      CastleFloor.NativeFieldInfoPtr_WallEast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (WallEast));
      CastleFloor.NativeFieldInfoPtr_WallSouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (WallSouth));
      CastleFloor.NativeFieldInfoPtr_WallWest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, nameof (WallWest));
      CastleFloor.NativeMethodInfoPtr_GetNeighbourFloors_Public_CastleFloorNeighbourEnumerator_ComponentDataFromEntity_1_PlacementDestroyData_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670029);
      CastleFloor.NativeMethodInfoPtr_GetNeighbourFloor_Public_NeighbourData_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670030);
      CastleFloor.NativeMethodInfoPtr_GetWall_Public_Entity_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670031);
      CastleFloor.NativeMethodInfoPtr_SetNeighbourFloor_Public_Void_Entity_CardinalDirection_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670032);
      CastleFloor.NativeMethodInfoPtr_SetWall_Public_Void_Entity_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670033);
      CastleFloor.NativeMethodInfoPtr_ClearFloors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670034);
      CastleFloor.NativeMethodInfoPtr_ClearWalls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670035);
      CastleFloor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, 100670036);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleFloor>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
