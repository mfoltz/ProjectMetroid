// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.OrthogonalRotationExtension
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;

#nullable disable
namespace ProjectM.Terrain
{
  public static class OrthogonalRotationExtension : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InverseRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubtractRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0;

    [CallerCount(0)]
    public static unsafe OrthogonalRotation InverseRotation(this OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OrthogonalRotationExtension.NativeMethodInfoPtr_InverseRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OrthogonalRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766886, RefRangeEnd = 766887, XrefRangeStart = 766886, XrefRangeEnd = 766886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OrthogonalRotation AddRotation(
      this OrthogonalRotation rotation,
      OrthogonalRotation offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OrthogonalRotationExtension.NativeMethodInfoPtr_AddRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OrthogonalRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766887, RefRangeEnd = 766888, XrefRangeStart = 766887, XrefRangeEnd = 766887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OrthogonalRotation SubtractRotation(
      this OrthogonalRotation rotation,
      OrthogonalRotation offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OrthogonalRotationExtension.NativeMethodInfoPtr_SubtractRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OrthogonalRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766888, RefRangeEnd = 766890, XrefRangeStart = 766888, XrefRangeEnd = 766888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation ToTileRotation(this OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OrthogonalRotationExtension.NativeMethodInfoPtr_ToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    static OrthogonalRotationExtension()
    {
      Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (OrthogonalRotationExtension));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr);
      OrthogonalRotationExtension.NativeMethodInfoPtr_InverseRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr, 100667814);
      OrthogonalRotationExtension.NativeMethodInfoPtr_AddRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr, 100667815);
      OrthogonalRotationExtension.NativeMethodInfoPtr_SubtractRotation_Public_Static_OrthogonalRotation_OrthogonalRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr, 100667816);
      OrthogonalRotationExtension.NativeMethodInfoPtr_ToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrthogonalRotationExtension>.NativeClassPtr, 100667817);
    }

    public OrthogonalRotationExtension(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
