// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.RestrictPlacementArea
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RestrictPlacementArea
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictAllTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictSpecificTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictOnlyPlayerBuilding;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictOnlyAgainstEnemies;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public bool RestrictAllTypes;
    [FieldOffset(8)]
    public PlacementTypeData RestrictSpecificTypes;
    [FieldOffset(48)]
    public bool RestrictOnlyPlayerBuilding;
    [FieldOffset(49)]
    public bool RestrictOnlyAgainstEnemies;

    static RestrictPlacementArea()
    {
      Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (RestrictPlacementArea));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr);
      RestrictPlacementArea.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, nameof (Radius));
      RestrictPlacementArea.NativeFieldInfoPtr_RestrictAllTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, nameof (RestrictAllTypes));
      RestrictPlacementArea.NativeFieldInfoPtr_RestrictSpecificTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, nameof (RestrictSpecificTypes));
      RestrictPlacementArea.NativeFieldInfoPtr_RestrictOnlyPlayerBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, nameof (RestrictOnlyPlayerBuilding));
      RestrictPlacementArea.NativeFieldInfoPtr_RestrictOnlyAgainstEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, nameof (RestrictOnlyAgainstEnemies));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RestrictPlacementArea>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
