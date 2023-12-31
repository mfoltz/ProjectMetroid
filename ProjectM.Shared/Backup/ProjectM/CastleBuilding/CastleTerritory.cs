// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleTerritory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleTerritory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsGlobalDebugTerritory;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryIndex;
    [FieldOffset(0)]
    public MapZoneId ZoneId;
    [FieldOffset(12)]
    public Entity CastleHeart;
    [FieldOffset(20)]
    public BoundsMinMax WorldBounds;
    [FieldOffset(36)]
    public bool IsGlobalDebugTerritory;
    [FieldOffset(37)]
    public byte MinHeightLevel;
    [FieldOffset(38)]
    public byte MaxHeightLevel;
    [FieldOffset(40)]
    public int CastleTerritoryIndex;

    static CastleTerritory()
    {
      Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleTerritory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr);
      CastleTerritory.NativeFieldInfoPtr_ZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (ZoneId));
      CastleTerritory.NativeFieldInfoPtr_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (CastleHeart));
      CastleTerritory.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (WorldBounds));
      CastleTerritory.NativeFieldInfoPtr_IsGlobalDebugTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (IsGlobalDebugTerritory));
      CastleTerritory.NativeFieldInfoPtr_MinHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (MinHeightLevel));
      CastleTerritory.NativeFieldInfoPtr_MaxHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (MaxHeightLevel));
      CastleTerritory.NativeFieldInfoPtr_CastleTerritoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, nameof (CastleTerritoryIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
