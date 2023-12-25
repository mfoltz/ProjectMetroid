// Decompiled with JetBrains decompiler
// Type: ProjectM.Wallpaper_NotSplit
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Wallpaper_NotSplit
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveStyleOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveVariationOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideOrientation;
    [FieldOffset(0)]
    public WallpaperOrientationData Data;
    [FieldOffset(4)]
    public byte ActiveStyleOverride;
    [FieldOffset(5)]
    public byte ActiveVariationOverride;
    [FieldOffset(6)]
    public WallpaperOrientation OverrideOrientation;

    static Wallpaper_NotSplit()
    {
      Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Wallpaper_NotSplit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr);
      Wallpaper_NotSplit.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr, nameof (Data));
      Wallpaper_NotSplit.NativeFieldInfoPtr_ActiveStyleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr, nameof (ActiveStyleOverride));
      Wallpaper_NotSplit.NativeFieldInfoPtr_ActiveVariationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr, nameof (ActiveVariationOverride));
      Wallpaper_NotSplit.NativeFieldInfoPtr_OverrideOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr, nameof (OverrideOrientation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Wallpaper_NotSplit>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
