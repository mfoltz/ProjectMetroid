// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRoomWall
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRoomWall
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorNorth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorEast;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorSouth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorWest;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloor_Public_Entity_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFloor_Public_Void_Entity_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearFloors_Public_Void_0;
    [FieldOffset(0)]
    public Entity FloorNorth;
    [FieldOffset(8)]
    public Entity FloorEast;
    [FieldOffset(16)]
    public Entity FloorSouth;
    [FieldOffset(24)]
    public Entity FloorWest;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1128980, RefRangeEnd = 1128983, XrefRangeStart = 1128979, XrefRangeEnd = 1128980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetFloor(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRoomWall.NativeMethodInfoPtr_GetFloor_Public_Entity_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1128983, RefRangeEnd = 1128986, XrefRangeStart = 1128983, XrefRangeEnd = 1128983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFloor(Entity tileModel, CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRoomWall.NativeMethodInfoPtr_SetFloor_Public_Void_Entity_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128990, RefRangeEnd = 1128991, XrefRangeStart = 1128986, XrefRangeEnd = 1128990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearFloors()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRoomWall.NativeMethodInfoPtr_ClearFloors_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleRoomWall()
    {
      Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleRoomWall));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr);
      CastleRoomWall.NativeFieldInfoPtr_FloorNorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, nameof (FloorNorth));
      CastleRoomWall.NativeFieldInfoPtr_FloorEast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, nameof (FloorEast));
      CastleRoomWall.NativeFieldInfoPtr_FloorSouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, nameof (FloorSouth));
      CastleRoomWall.NativeFieldInfoPtr_FloorWest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, nameof (FloorWest));
      CastleRoomWall.NativeMethodInfoPtr_GetFloor_Public_Entity_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, 100689713);
      CastleRoomWall.NativeMethodInfoPtr_SetFloor_Public_Void_Entity_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, 100689714);
      CastleRoomWall.NativeMethodInfoPtr_ClearFloors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, 100689715);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRoomWall>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
