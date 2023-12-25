// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SpatialLookupParams
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpatialLookupParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyType;
    [FieldOffset(0)]
    public NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> LookupMap;
    [FieldOffset(16)]
    public ComponentDataFromEntity<TileBounds> BoundsType;
    [FieldOffset(48)]
    public ComponentDataFromEntity<DestroyTag> DestroyType;

    static SpatialLookupParams()
    {
      Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (SpatialLookupParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr);
      SpatialLookupParams.NativeFieldInfoPtr_LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr, nameof (LookupMap));
      SpatialLookupParams.NativeFieldInfoPtr_BoundsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr, nameof (BoundsType));
      SpatialLookupParams.NativeFieldInfoPtr_DestroyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr, nameof (DestroyType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpatialLookupParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
