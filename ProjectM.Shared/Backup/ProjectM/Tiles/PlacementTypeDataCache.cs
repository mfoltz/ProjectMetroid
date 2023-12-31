// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeDataCache
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  public static class PlacementTypeDataCache : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AllAttachmentFlags;

    static PlacementTypeDataCache()
    {
      Il2CppClassPointerStore<PlacementTypeDataCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (PlacementTypeDataCache));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementTypeDataCache>.NativeClassPtr);
      PlacementTypeDataCache.NativeFieldInfoPtr_AllAttachmentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeDataCache>.NativeClassPtr, nameof (AllAttachmentFlags));
    }

    public PlacementTypeDataCache(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Nullable_Unboxed<PlacementTypeData> AllAttachmentFlags
    {
      get
      {
        Nullable_Unboxed<PlacementTypeData> allAttachmentFlags;
        IL2CPP.il2cpp_field_static_get_value(PlacementTypeDataCache.NativeFieldInfoPtr_AllAttachmentFlags, (void*) &allAttachmentFlags);
        return allAttachmentFlags;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlacementTypeDataCache.NativeFieldInfoPtr_AllAttachmentFlags, (void*) &value);
      }
    }
  }
}
