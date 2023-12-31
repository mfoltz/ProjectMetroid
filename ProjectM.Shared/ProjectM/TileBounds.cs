// Decompiled with JetBrains decompiler
// Type: ProjectM.TileBounds
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileBounds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_TilePosition_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_int2_TileRotation_BoundsMinMax_0;
    [FieldOffset(0)]
    public BoundsMinMax Value;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731988, RefRangeEnd = 731989, XrefRangeStart = 731986, XrefRangeEnd = 731988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax LocalToWorldBounds(
      TilePosition tilePosition,
      BoundsMinMax localBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localBounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBounds.NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_TilePosition_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731991, RefRangeEnd = 731992, XrefRangeStart = 731989, XrefRangeEnd = 731991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax LocalToWorldBounds(
      int2 tile,
      TileRotation tileRotation,
      BoundsMinMax localBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localBounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBounds.NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_int2_TileRotation_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBounds()
    {
      Il2CppClassPointerStore<TileBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBounds>.NativeClassPtr);
      TileBounds.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBounds>.NativeClassPtr, nameof (Value));
      TileBounds.NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_TilePosition_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBounds>.NativeClassPtr, 100664671);
      TileBounds.NativeMethodInfoPtr_LocalToWorldBounds_Public_Static_BoundsMinMax_int2_TileRotation_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBounds>.NativeClassPtr, 100664672);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileBounds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
