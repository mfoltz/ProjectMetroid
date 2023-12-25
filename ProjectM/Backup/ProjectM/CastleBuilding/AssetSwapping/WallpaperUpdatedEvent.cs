// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.WallpaperUpdatedEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WallpaperUpdatedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallpaperEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Orientation;
    [FieldOffset(0)]
    public Entity Owner;
    [FieldOffset(8)]
    public Entity WallpaperEntity;
    [FieldOffset(16)]
    public WallpaperOrientation Orientation;

    static WallpaperUpdatedEvent()
    {
      Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (WallpaperUpdatedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr);
      WallpaperUpdatedEvent.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr, nameof (Owner));
      WallpaperUpdatedEvent.NativeFieldInfoPtr_WallpaperEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr, nameof (WallpaperEntity));
      WallpaperUpdatedEvent.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr, nameof (Orientation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperUpdatedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
