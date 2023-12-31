// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TilePivot
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TilePivot : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotType_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotType_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PositionToTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSnappedTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotatePivotInCenter_Private_Static_bool2_bool2_TileRotation_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 790432, RefRangeEnd = 790436, XrefRangeStart = 790421, XrefRangeEnd = 790432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetTileRotationOffset(
      this TilePivotSettings settings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790447, RefRangeEnd = 790449, XrefRangeStart = 790436, XrefRangeEnd = 790447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetTileRotationOffset(
      this TilePivotType pivotType,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pivotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotType_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 790451, RefRangeEnd = 790457, XrefRangeStart = 790449, XrefRangeEnd = 790451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 GetPivotOffset(
      this TilePivotSettings settings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790457, XrefRangeEnd = 790459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 GetPivotOffset(
      this TilePivotType pivotType,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pivotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotType_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790459, XrefRangeEnd = 790466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 PositionToTile(
      this TilePivotSettings settings,
      float2 position,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_PositionToTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 790471, RefRangeEnd = 790475, XrefRangeStart = 790466, XrefRangeEnd = 790471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 ToSnappedTile(
      this TilePivotSettings settings,
      float2 unsnappedTile,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unsnappedTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_ToSnappedTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790475, XrefRangeEnd = 790476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool2 GetPivotInCenterOfTile(this TilePivotSettings settings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &settings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 790486, RefRangeEnd = 790494, XrefRangeStart = 790476, XrefRangeEnd = 790486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool2 GetPivotInCenterOfTile(this TilePivotType pivotType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pivotType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool2 RotatePivotInCenter(bool2 pivotInCenter, TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pivotInCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivot.NativeMethodInfoPtr_RotatePivotInCenter_Private_Static_bool2_bool2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TilePivot()
    {
      Il2CppClassPointerStore<TilePivot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TilePivot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilePivot>.NativeClassPtr);
      TilePivot.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669535);
      TilePivot.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TilePivotType_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669536);
      TilePivot.NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669537);
      TilePivot.NativeMethodInfoPtr_GetPivotOffset_Public_Static_float2_TilePivotType_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669538);
      TilePivot.NativeMethodInfoPtr_PositionToTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669539);
      TilePivot.NativeMethodInfoPtr_ToSnappedTile_Public_Static_int2_TilePivotSettings_float2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669540);
      TilePivot.NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669541);
      TilePivot.NativeMethodInfoPtr_GetPivotInCenterOfTile_Public_Static_bool2_TilePivotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669542);
      TilePivot.NativeMethodInfoPtr_RotatePivotInCenter_Private_Static_bool2_bool2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivot>.NativeClassPtr, 100669543);
    }

    public TilePivot(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
