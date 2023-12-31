// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeDataAsLongs
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementTypeDataAsLongs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BasicFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntranceFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_LiquidFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_MustMatchAll;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlacementTypeData_PlacementTypeDataAsLongs_0;
    [FieldOffset(0)]
    public long BasicFlags;
    [FieldOffset(8)]
    public long ObjectFlags;
    [FieldOffset(16)]
    public byte TerrainFlags;
    [FieldOffset(24)]
    public long FloorFlags;
    [FieldOffset(32)]
    public byte UnitFlags;
    [FieldOffset(33)]
    public byte WallFlags;
    [FieldOffset(34)]
    public byte EntranceFlags;
    [FieldOffset(35)]
    public byte LiquidFlags;
    [FieldOffset(36)]
    public bool MustMatchAll;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 790030, RefRangeEnd = 790047, XrefRangeStart = 790030, XrefRangeEnd = 790030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator PlacementTypeData(PlacementTypeDataAsLongs placementTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &placementTypes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeDataAsLongs.NativeMethodInfoPtr_op_Implicit_Public_Static_PlacementTypeData_PlacementTypeDataAsLongs_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementTypeData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PlacementTypeDataAsLongs()
    {
      Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (PlacementTypeDataAsLongs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr);
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_BasicFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (BasicFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_ObjectFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (ObjectFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_TerrainFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (TerrainFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_FloorFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (FloorFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_UnitFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (UnitFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_WallFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (WallFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_EntranceFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (EntranceFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_LiquidFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (LiquidFlags));
      PlacementTypeDataAsLongs.NativeFieldInfoPtr_MustMatchAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, nameof (MustMatchAll));
      PlacementTypeDataAsLongs.NativeMethodInfoPtr_op_Implicit_Public_Static_PlacementTypeData_PlacementTypeDataAsLongs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, 100669517);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementTypeDataAsLongs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
