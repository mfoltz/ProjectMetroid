// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBoundsHelpers
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileBoundsHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_NativeArray_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCombinedNestedBounds_Private_Static_Boolean_EntityManager_Entity_byref_BoundsMinMax_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085716, RefRangeEnd = 1085717, XrefRangeStart = 1085715, XrefRangeEnd = 1085716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetMergedBounds(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBoundsHelpers.NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085717, XrefRangeEnd = 1085722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetMergedBounds(
      EntityManager entityManager,
      NativeArray<Entity> entities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entities;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBoundsHelpers.NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_NativeArray_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1085752, RefRangeEnd = 1085755, XrefRangeStart = 1085722, XrefRangeEnd = 1085752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCombinedNestedBounds(
      EntityManager entityManager,
      Entity parentEntity,
      out BoundsMinMax bounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref bounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBoundsHelpers.NativeMethodInfoPtr_TryGetCombinedNestedBounds_Private_Static_Boolean_EntityManager_Entity_byref_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBoundsHelpers()
    {
      Il2CppClassPointerStore<TileBoundsHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileBoundsHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBoundsHelpers>.NativeClassPtr);
      TileBoundsHelpers.NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBoundsHelpers>.NativeClassPtr, 100685519);
      TileBoundsHelpers.NativeMethodInfoPtr_GetMergedBounds_Public_Static_BoundsMinMax_EntityManager_NativeArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBoundsHelpers>.NativeClassPtr, 100685520);
      TileBoundsHelpers.NativeMethodInfoPtr_TryGetCombinedNestedBounds_Private_Static_Boolean_EntityManager_Entity_byref_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBoundsHelpers>.NativeClassPtr, 100685521);
    }

    public TileBoundsHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
