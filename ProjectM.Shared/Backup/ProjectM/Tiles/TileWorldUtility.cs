// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileWorldUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileWorldUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIntersectingCells_Public_Static_NativeArray_1_CellIntersection_BoundsMinMax_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIntersectingCellEnumerator_Public_Static_IntersectingTileCellEnumerator_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_byref_TileWorld_Byte_BoundsMinMax_T_NativeArray_1_T_FunctionPointer_1_GetLayerTilesDelegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_StandardMaskGetter_SingleFlag_byref_TileWorld_StandardLayerFlags_BoundsMinMax_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_SingleFlag_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileFlagsEnumerator_OR_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_MultiFlags_OR_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 793011, RefRangeEnd = 793028, XrefRangeStart = 792991, XrefRangeEnd = 793011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<CellIntersection> GetIntersectingCells(
      BoundsMinMax worldBounds,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.NativeMethodInfoPtr_GetIntersectingCells_Public_Static_NativeArray_1_CellIntersection_BoundsMinMax_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<CellIntersection>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793034, RefRangeEnd = 793037, XrefRangeStart = 793028, XrefRangeEnd = 793034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IntersectingTileCellEnumerator GetIntersectingCellEnumerator(
      BoundsMinMax bounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.NativeMethodInfoPtr_GetIntersectingCellEnumerator_Public_Static_IntersectingTileCellEnumerator_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(IntersectingTileCellEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void GetChunkTilesWithinWorldBounds<T>(
      ref TileWorld tileWorld,
      byte heightLevel,
      BoundsMinMax worldBounds,
      T invalidDefaultValue,
      NativeArray<T> result,
      FunctionPointer<GetLayerTilesDelegate> getLayerTiles)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) invalidDefaultValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref invalidDefaultValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getLayerTiles;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.MethodInfoStoreGeneric_GetChunkTilesWithinWorldBounds_Public_Static_Void_byref_TileWorld_Byte_BoundsMinMax_T_NativeArray_1_T_FunctionPointer_1_GetLayerTilesDelegate_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793041, RefRangeEnd = 793045, XrefRangeStart = 793037, XrefRangeEnd = 793041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileFlagEnumerator<StandardMaskGetter_SingleFlag> GetTileFlagEnumerator(
      [In] ref this TileWorld tileWorld,
      StandardLayerFlags flag,
      BoundsMinMax bounds,
      byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_StandardMaskGetter_SingleFlag_byref_TileWorld_StandardLayerFlags_BoundsMinMax_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileFlagEnumerator<StandardMaskGetter_SingleFlag>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793049, RefRangeEnd = 793050, XrefRangeStart = 793045, XrefRangeEnd = 793049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileFlagEnumerator<CollisionMaskGetter_SingleFlag> GetTileFlagEnumerator(
      [In] ref this TileWorld tileWorld,
      MapCollisionFlags flag,
      BoundsMinMax bounds,
      byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_SingleFlag_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileFlagEnumerator<CollisionMaskGetter_SingleFlag>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793054, RefRangeEnd = 793055, XrefRangeStart = 793050, XrefRangeEnd = 793054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileFlagEnumerator<CollisionMaskGetter_MultiFlags_OR> GetTileFlagsEnumerator_OR(
      [In] ref this TileWorld tileWorld,
      MapCollisionFlags flags,
      BoundsMinMax bounds,
      byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldUtility.NativeMethodInfoPtr_GetTileFlagsEnumerator_OR_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_MultiFlags_OR_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileFlagEnumerator<CollisionMaskGetter_MultiFlags_OR>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileWorldUtility()
    {
      Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileWorldUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr);
      TileWorldUtility.NativeMethodInfoPtr_GetIntersectingCells_Public_Static_NativeArray_1_CellIntersection_BoundsMinMax_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669818);
      TileWorldUtility.NativeMethodInfoPtr_GetIntersectingCellEnumerator_Public_Static_IntersectingTileCellEnumerator_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669819);
      TileWorldUtility.NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_byref_TileWorld_Byte_BoundsMinMax_T_NativeArray_1_T_FunctionPointer_1_GetLayerTilesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669820);
      TileWorldUtility.NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_StandardMaskGetter_SingleFlag_byref_TileWorld_StandardLayerFlags_BoundsMinMax_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669821);
      TileWorldUtility.NativeMethodInfoPtr_GetTileFlagEnumerator_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_SingleFlag_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669822);
      TileWorldUtility.NativeMethodInfoPtr_GetTileFlagsEnumerator_OR_Public_Static_TileFlagEnumerator_1_CollisionMaskGetter_MultiFlags_OR_byref_TileWorld_MapCollisionFlags_BoundsMinMax_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr, 100669823);
    }

    public TileWorldUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_GetChunkTilesWithinWorldBounds_Public_Static_Void_byref_TileWorld_Byte_BoundsMinMax_T_NativeArray_1_T_FunctionPointer_1_GetLayerTilesDelegate_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileWorldUtility.NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_byref_TileWorld_Byte_BoundsMinMax_T_NativeArray_1_T_FunctionPointer_1_GetLayerTilesDelegate_0, Il2CppClassPointerStore<TileWorldUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
