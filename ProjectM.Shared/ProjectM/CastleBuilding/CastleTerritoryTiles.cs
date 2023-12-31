// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleTerritoryTiles
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleTerritoryTiles
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InsideBuildableTerritory;
    [FieldOffset(0)]
    public bool InsideBuildableTerritory;

    static CastleTerritoryTiles()
    {
      Il2CppClassPointerStore<CastleTerritoryTiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleTerritoryTiles));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryTiles>.NativeClassPtr);
      CastleTerritoryTiles.NativeFieldInfoPtr_InsideBuildableTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryTiles>.NativeClassPtr, nameof (InsideBuildableTerritory));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryTiles>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
