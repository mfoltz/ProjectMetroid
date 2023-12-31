// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneTypeExtension
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Terrain
{
  public static class MapZoneTypeExtension : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToZoneFlags_Public_Static_MapZoneFlags_MapZoneType_MapZoneFlags_MapZoneFlags_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766610, RefRangeEnd = 766612, XrefRangeStart = 766601, XrefRangeEnd = 766610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MapZoneFlags ToZoneFlags(
      this MapZoneType mapZoneType,
      MapZoneFlags addCustomZoneFlags = MapZoneFlags.None,
      MapZoneFlags removeCustomZoneFlags = MapZoneFlags.None)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &mapZoneType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &addCustomZoneFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &removeCustomZoneFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneTypeExtension.NativeMethodInfoPtr_ToZoneFlags_Public_Static_MapZoneFlags_MapZoneType_MapZoneFlags_MapZoneFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapZoneFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapZoneTypeExtension()
    {
      Il2CppClassPointerStore<MapZoneTypeExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneTypeExtension));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneTypeExtension>.NativeClassPtr);
      MapZoneTypeExtension.NativeMethodInfoPtr_ToZoneFlags_Public_Static_MapZoneFlags_MapZoneType_MapZoneFlags_MapZoneFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneTypeExtension>.NativeClassPtr, 100667772);
    }

    public MapZoneTypeExtension(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
