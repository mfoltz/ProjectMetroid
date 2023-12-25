// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofTileData
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoofTileData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RoofCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileBlobType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationOffset;
    [FieldOffset(0)]
    public RoofCategoryType RoofCategory;
    [FieldOffset(1)]
    public TileBlobRootType TileBlobType;
    [FieldOffset(4)]
    public OrthogonalRotation RotationOffset;

    static RoofTileData()
    {
      Il2CppClassPointerStore<RoofTileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (RoofTileData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTileData>.NativeClassPtr);
      RoofTileData.NativeFieldInfoPtr_RoofCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileData>.NativeClassPtr, nameof (RoofCategory));
      RoofTileData.NativeFieldInfoPtr_TileBlobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileData>.NativeClassPtr, nameof (TileBlobType));
      RoofTileData.NativeFieldInfoPtr_RotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileData>.NativeClassPtr, nameof (RotationOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTileData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
