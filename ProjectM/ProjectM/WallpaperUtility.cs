// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WallpaperUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentMeshVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentColorVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrientationForRotation_Public_Static_WallpaperOrientation_Single_ObjectSplits_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrientationIndex_Public_Static_Int32_ObjectSplits_WallpaperOrientation_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1082386, RefRangeEnd = 1082387, XrefRangeStart = 1082381, XrefRangeEnd = 1082386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe byte GetCurrentMeshVariationIndex(
      EntityManager entityManager,
      Entity entity,
      ObjectSplits splitsPerStyle,
      WallpaperOrientation targetOrientation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitsPerStyle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetOrientation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperUtility.NativeMethodInfoPtr_GetCurrentMeshVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1082392, RefRangeEnd = 1082394, XrefRangeStart = 1082387, XrefRangeEnd = 1082392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe byte GetCurrentColorVariationIndex(
      EntityManager entityManager,
      Entity entity,
      ObjectSplits splitsPerStyle,
      WallpaperOrientation targetOrientation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitsPerStyle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetOrientation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperUtility.NativeMethodInfoPtr_GetCurrentColorVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1082404, RefRangeEnd = 1082406, XrefRangeStart = 1082394, XrefRangeEnd = 1082404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WallpaperOrientation GetOrientationForRotation(
      float rotation,
      ObjectSplits splitsPerStyle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &splitsPerStyle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperUtility.NativeMethodInfoPtr_GetOrientationForRotation_Public_Static_WallpaperOrientation_Single_ObjectSplits_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WallpaperOrientation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1082410, RefRangeEnd = 1082411, XrefRangeStart = 1082406, XrefRangeEnd = 1082410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetOrientationIndex(
      ObjectSplits objectSplits,
      WallpaperOrientation orientation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &objectSplits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orientation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperUtility.NativeMethodInfoPtr_GetOrientationIndex_Public_Static_Int32_ObjectSplits_WallpaperOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WallpaperUtility()
    {
      Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr);
      WallpaperUtility.NativeMethodInfoPtr_GetCurrentMeshVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr, 100685248);
      WallpaperUtility.NativeMethodInfoPtr_GetCurrentColorVariationIndex_Public_Static_Byte_EntityManager_Entity_ObjectSplits_WallpaperOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr, 100685249);
      WallpaperUtility.NativeMethodInfoPtr_GetOrientationForRotation_Public_Static_WallpaperOrientation_Single_ObjectSplits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr, 100685250);
      WallpaperUtility.NativeMethodInfoPtr_GetOrientationIndex_Public_Static_Int32_ObjectSplits_WallpaperOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperUtility>.NativeClassPtr, 100685251);
    }

    public WallpaperUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
